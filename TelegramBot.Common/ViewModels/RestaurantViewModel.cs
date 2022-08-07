

namespace TelegramBot.Common.ViewModels
{
    public class RestaurantViewModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
    }
}
