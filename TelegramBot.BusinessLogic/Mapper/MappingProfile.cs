using AutoMapper;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.Common.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RestaurantViewModel, Restaurant>();
            CreateMap<Restaurant, RestaurantViewModel>();
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();
            CreateMap<TimetableViewModel, Timetable>();
            CreateMap<Timetable, TimetableViewModel>();
        }
    }
}
