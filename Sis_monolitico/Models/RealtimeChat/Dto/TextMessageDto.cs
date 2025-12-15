namespace Sis_monolitico.Models.RealtimeChat.Dto
{
    /// <summary>
    /// Mensaje recibido desde el server cuando alguien envía texto.
    /// Coincide con payload TEXT_MESSAGE que emite Spring.
    /// </summary>
    public sealed class TextMessageDto
    {
        public string? type { get; set; }      // TEXT_MESSAGE
        public string? roomId { get; set; }
        public string? senderId { get; set; }
        public string? content { get; set; }
    }
}
