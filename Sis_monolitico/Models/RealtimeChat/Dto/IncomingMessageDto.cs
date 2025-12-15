namespace Sis_monolitico.Models.RealtimeChat.Dto
{
    /// <summary>
    /// DTO que el cliente envía al WebSocket del microservicio.
    /// Coincide con ChatWebSocketHandler.IncomingMessage (Spring).
    /// </summary>
    public sealed class IncomingMessageDto
    {
        public string? type { get; set; }      // JOIN_ROOM, TEXT_MESSAGE
        public string? roomId { get; set; }
        public string? senderId { get; set; }
        public string? content { get; set; }   // texto del chat
    }
}
