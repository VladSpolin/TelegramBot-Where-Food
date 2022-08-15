using AutoMapper;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Implementations
{
    public class RestaurantService : IRestaurantService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public RestaurantService(ApplicationContext context, IMapper mapper)
        {
            _context= context;
            _mapper = mapper;
        }
        public void Create(RestaurantViewModel model)
        {
            var restaurant = _mapper.Map<RestaurantViewModel, Restaurant>(model);

            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Restaurants.Remove(GetRestaurant(id).FirstOrDefault());
            _context.SaveChanges();
        }

        private IQueryable<Restaurant> GetRestaurant(int id)
        {
            if (!_context.Restaurants.Any(x => x.Id == id)) throw new Exception("Restaurant not found.");

            return _context.Restaurants.Where(x => x.Id == id);
        }

        public RestaurantViewModel Get(int id)
        {
            return _mapper.Map<Restaurant, RestaurantViewModel>(GetRestaurant(id).FirstOrDefault());
        }

        public RestaurantViewModel GetByName(string name)
        {
            if (!_context.Restaurants.Any(x => x.Name == name)) throw new Exception("Restaurant not found.");

            var restaurant = _context.Restaurants.Where(x => x.Name == name).FirstOrDefault();
            return _mapper.Map<Restaurant, RestaurantViewModel>(restaurant);
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            if (_context.Restaurants == null) throw new Exception("Restaurants not found.");
            return _context.Restaurants.ToList();
        }

        public void Edit(int id, RestaurantViewModel model)
        {
            var restaurant = GetRestaurant(id).FirstOrDefault();
            var mapped = _mapper.Map<RestaurantViewModel, Restaurant>(model ,restaurant);
            mapped.Categories=_mapper.Map<List<Category>>(model.Categories);
            mapped.Timetables = _mapper.Map<List<Timetable>>(model.Timetables);
            _context.Restaurants.Update(mapped);
            _context.SaveChanges();
            
        }
    }
}
