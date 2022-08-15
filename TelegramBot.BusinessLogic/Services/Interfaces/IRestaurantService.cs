using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Interfaces
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetRestaurants();
        RestaurantViewModel Get(int id);
        RestaurantViewModel GetByName(string name);
        void Create(RestaurantViewModel model);
        void Delete(int id);
        void Edit(int id, RestaurantViewModel model);
    }
}
