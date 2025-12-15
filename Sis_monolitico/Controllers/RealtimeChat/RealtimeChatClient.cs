using System;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Sis_monolitico.Models.RealtimeChat.Dto;

namespace Sis_monolitico.Controllers.RealtimeChat
{
    /// <summary>
    /// Cliente WebSocket puro (ClientWebSocket) para consumir:
    /// ws://localhost:8080/ws/chat
    ///
    /// Protocolo (según tu Spring):
    /// - Cliente -> Server:
    ///   { type:"JOIN_ROOM", senderId:"user-1", roomId:"room-1" }
    ///   { type:"TEXT_MESSAGE", roomId:"room-1", senderId:"user-1", content:"hola" }
    ///
    /// - Server -> Cliente:
    ///   { type:"TEXT_MESSAGE", roomId:"room-1", senderId:"user-1", content:"hola" }
    ///   { type:"USER_JOINED", roomId:"room-1", userId:"user-2" }
    /// </summary>
    public sealed class RealtimeChatClient : IAsyncDisposable
    {
        private ClientWebSocket? _ws;
        private CancellationTokenSource? _loopCts;
        private Task? _loopTask;

        public event Action<TextMessageDto>? TextMessageReceived;
        public event Action<UserJoinedDto>? UserJoined;

        /// <summary>
        /// Conecta y manda JOIN_ROOM.
        /// </summary>
        public async Task ConnectAsync(string wsUrl, string userId, string roomId, CancellationToken ct)
        {
            // Si ya estaba conectado, primero desconectamos
            await DisconnectAsync(CancellationToken.None);

            _ws = new ClientWebSocket();
            await _ws.ConnectAsync(new Uri(wsUrl), ct);

            // JOIN_ROOM (igual que tu cliente HTML)
            var join = new IncomingMessageDto
            {
                type = "JOIN_ROOM",
                senderId = userId,
                roomId = roomId
            };

            await SendInternalAsync(join, ct);

            // Loop receptor en background
            _loopCts = new CancellationTokenSource();
            _loopTask = Task.Run(() => ReceiveLoopAsync(_loopCts.Token));
        }

        /// <summary>
        /// Envía un mensaje de texto a la sala.
        /// </summary>
        public Task SendTextAsync(string roomId, string userId, string content, CancellationToken ct)
        {
            var msg = new IncomingMessageDto
            {
                type = "TEXT_MESSAGE",
                roomId = roomId,
                senderId = userId,
                content = content
            };

            return SendInternalAsync(msg, ct);
        }

        /// <summary>
        /// Cierra el socket.
        /// </summary>
        public async Task DisconnectAsync(CancellationToken ct)
        {
            try
            {
                _loopCts?.Cancel();

                if (_ws != null && _ws.State == WebSocketState.Open)
                    await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "client-close", ct);
            }
            catch
            {
                // Evitamos reventar la app por cierre
            }
            finally
            {
                _ws?.Dispose();
                _ws = null;
            }
        }

        private async Task SendInternalAsync(IncomingMessageDto payload, CancellationToken ct)
        {
            if (_ws == null || _ws.State != WebSocketState.Open)
                throw new InvalidOperationException("WebSocket no está conectado.");

            // Tus DTO ya están en camelCase, por eso serializamos tal cual
            var json = JsonSerializer.Serialize(payload);
            var bytes = Encoding.UTF8.GetBytes(json);

            await _ws.SendAsync(bytes, WebSocketMessageType.Text, true, ct);
        }

        private async Task ReceiveLoopAsync(CancellationToken ct)
        {
            if (_ws == null) return;

            var buffer = new byte[64 * 1024];

            while (!ct.IsCancellationRequested && _ws.State == WebSocketState.Open)
            {
                WebSocketReceiveResult result;

                using var ms = new MemoryStream();

                do
                {
                    result = await _ws.ReceiveAsync(buffer, ct);

                    if (result.MessageType == WebSocketMessageType.Close)
                        return;

                    ms.Write(buffer, 0, result.Count);
                }
                while (!result.EndOfMessage);

                var json = Encoding.UTF8.GetString(ms.ToArray());

                try
                {
                    using var doc = JsonDocument.Parse(json);

                    if (!doc.RootElement.TryGetProperty("type", out var typeProp))
                        continue;

                    var type = typeProp.GetString();

                    if (type == "TEXT_MESSAGE")
                    {
                        var msg = JsonSerializer.Deserialize<TextMessageDto>(json);
                        if (msg != null) TextMessageReceived?.Invoke(msg);
                    }
                    else if (type == "USER_JOINED")
                    {
                        var joined = JsonSerializer.Deserialize<UserJoinedDto>(json);
                        if (joined != null) UserJoined?.Invoke(joined);
                    }
                }
                catch
                {
                    // Si llega un JSON inválido o distinto, lo ignoramos
                }
            }
        }

        public async ValueTask DisposeAsync()
        {
            await DisconnectAsync(CancellationToken.None);
        }
    }
}
