

namespace TelegramBot.Model.DataBaseModels
{
    public class Timetable
    {
        public int Id { get; set; }
        public int? RestaurantId { get; set; }
        public Restaurant ItsRestaurant { get; set; }
        public DayOfWeek Day { get; set; }
        public TimeSpan Opened { get; set; }
        public TimeSpan Closed { get; set; }
    }
}
 