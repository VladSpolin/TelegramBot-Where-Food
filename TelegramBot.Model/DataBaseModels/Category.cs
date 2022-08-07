

namespace TelegramBot.Model.DataBaseModels
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
