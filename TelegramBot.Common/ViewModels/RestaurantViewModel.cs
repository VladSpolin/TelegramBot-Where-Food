

namespace TelegramBot.Common.ViewModels
{
    public class RestaurantViewModel
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Link { get; set; }
        public string PhotoLink { get; set; }
        public List<CategoryViewModel> Categories { get; set; }
        public List<TimetableViewModel> Timetables { get; set; }
    }
}
