

namespace TelegramBot.Common.ViewModels
{
    public class TimetableViewModel
    {
        public int? RestaurantId { get; set; }
        public RestaurantViewModel ItsRestaurant { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Opened { get; set; }
        public TimeSpan Closed { get; set; }
    }
}
