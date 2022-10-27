

namespace TelegramBot.Model.DataBaseModels
{
    public class RequestHistory
    {
        public int Id { get; set; }
        public string Command { get; set; }
        public DateTime Time { get; set; }
    }
}
