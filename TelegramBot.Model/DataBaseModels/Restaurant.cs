

namespace TelegramBot.Model.DataBaseModels
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Category> Categories { get; set; }
    }
}
