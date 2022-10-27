using AutoMapper;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model;
using TelegramBot.Model.DataBaseModels;
using Microsoft.EntityFrameworkCore;

namespace TelegramBot.BusinessLogic.Services.Implementations
{
    public class CategoryService: ICategoryService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public CategoryService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(CategoryViewModel model)
        {
            var category = _mapper.Map<CategoryViewModel, Category>(model);

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Categories.Remove(GetCategory(id).FirstOrDefault());
            _context.SaveChanges();
        }

        private IQueryable<Category> GetCategory(int id)
        {
            if (!_context.Categories.Any(x => x.Id == id)) throw new Exception("Category not found.");

            return _context.Categories.Where(x => x.Id == id);
        }

        public CategoryViewModel Get(int id)
        {
            var category = GetCategory(id).FirstOrDefault();
            var mapped = _mapper.Map<Category, CategoryViewModel>(category);
            mapped.Restaurants = _mapper.Map<List<RestaurantViewModel>>(category.Restaurants);
            return mapped;
        }

        public IEnumerable<Category> GetCategories()
        {
            if (_context.Categories == null) throw new Exception("Categories not found.");
            return _context.Categories.ToList();
        }

        public CategoryViewModel GetByName(string name)
        {
            if (!_context.Categories.Any(x => x.Name == name)) throw new Exception("Category not found.");

            var category = _context.Categories.Include(x=>x.Restaurants).ThenInclude(x=>x.Timetables).Where(x => x.Name == name).FirstOrDefault();
            var mapped = _mapper.Map<Category, CategoryViewModel>(category);
            mapped.Restaurants = _mapper.Map<List<Restaurant>, List<RestaurantViewModel>>(category.Restaurants);
            return mapped;
        }

        public bool IsExists(string name)
        {
            return _context.Categories.Any(x => x.Name == name);
        }





        public void Edit(int id, CategoryViewModel model)
        {
            var category = GetCategory(id).FirstOrDefault();
            var mapped = _mapper.Map<CategoryViewModel, Category>(model, category);
            mapped.Restaurants = _mapper.Map<List<Restaurant>>(model.Restaurants);
            _context.Categories.Update(mapped);
            _context.SaveChanges();
        }
    }
}
