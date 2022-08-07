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
            CreateMap<CategoryViewModel, Category>();
        }
    }
}
