using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sis_monolitico.Controllers.RealtimeChat;
using Sis_monolitico.Models.RealtimeChat.Dto;

namespace Sis_monolitico.Views
{
    public partial class FrmGroupChat : Form
    {
        private readonly RealtimeChatClient _chatClient = new();
        private CancellationTokenSource? _cts;

        // Como tu login no tiene userId real, generamos uno simple por ejecución
        private readonly string _userId = "user-" + Guid.NewGuid().ToString("N")[..6];

        // Tu endpoint real (según tu microservicio)
        private const string WsUrl = "ws://localhost:8080/ws/chat";

        public FrmGroupChat()
        {
            InitializeComponent();

            // Eventos UI
            btnConnect.Click += async (_, _) => await ConnectAsync();
            btnSend.Click += async (_, _) => await SendAsync();

            // Eventos WS
            _chatClient.UserJoined += OnUserJoined;
            _chatClient.TextMessageReceived += OnTextMessage;
        }

        private async Task ConnectAsync()
        {
            try
            {
                _cts?.Cancel();
                _cts = new CancellationTokenSource();

                var roomId = txtRoomId.Text.Trim();
                if (string.IsNullOrWhiteSpace(roomId))
                    return;

                await _chatClient.ConnectAsync(WsUrl, _userId, roomId, _cts.Token);

                AddSystemLine($"Conectado ✔ | userId={_userId} | room={roomId}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error conectando WS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SendAsync()
        {
            try
            {
                var roomId = txtRoomId.Text.Trim();
                var text = txtMessage.Text.Trim();

                if (string.IsNullOrWhiteSpace(roomId) || string.IsNullOrWhiteSpace(text))
                    return;

                await _chatClient.SendTextAsync(roomId, _userId, text, CancellationToken.None);
                txtMessage.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error enviando", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnUserJoined(UserJoinedDto joined)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => OnUserJoined(joined)));
                return;
            }

            AddSystemLine($"👤 {joined.userId} se unió a {joined.roomId}");
        }

        private void OnTextMessage(TextMessageDto msg)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => OnTextMessage(msg)));
                return;
            }

            var sender = msg.senderId ?? "?";
            var content = msg.content ?? "";
            var isMine = sender == _userId;

            AddChatBubble(sender, content, isMine);
        }

        // ===== UI helpers (burbujas simples) =====

        private void AddSystemLine(string text)
        {
            AddChatBubble("SYSTEM", text, isMine: false, isSystem: true);
        }

        private void AddChatBubble(string sender, string text, bool isMine, bool isSystem = false)
        {
            var bubble = new Panel
            {
                AutoSize = true,
                MaximumSize = new Size(pnlMessages.Width - 40, 0),
                Padding = new Padding(10),
                Margin = new Padding(10),
                BackColor =
                    isSystem ? Color.FromArgb(40, 40, 60) :
                    isMine ? Color.FromArgb(120, 90, 255) :
                             Color.FromArgb(30, 30, 46)
            };

            var lbl = new Label
            {
                AutoSize = true,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                Text = isSystem ? text : $"{sender}: {text}"
            };

            bubble.Controls.Add(lbl);
            bubble.Dock = DockStyle.Top;

            pnlMessages.Controls.Add(bubble);
            pnlMessages.Controls.SetChildIndex(bubble, 0);
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                _cts?.Cancel();
                await _chatClient.DisconnectAsync(CancellationToken.None);
            }
            catch { }
        }
    }
}
