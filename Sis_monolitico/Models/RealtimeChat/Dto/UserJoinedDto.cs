namespace Sis_monolitico.Models.RealtimeChat.Dto
{
    /// <summary>
    /// Evento recibido desde el server cuando un usuario entra a la sala.
    /// Coincide con payload USER_JOINED que emite Spring.
    /// </summary>
    public sealed class UserJoinedDto
    {
        public string? type { get; set; }   // USER_JOINED
        public string? roomId { get; set; }
        public string? userId { get; set; }
    }
}
