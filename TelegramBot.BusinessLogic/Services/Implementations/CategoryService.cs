using AutoMapper;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

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
            _context.Categories.Remove(GetCategoty(id).FirstOrDefault());
            _context.SaveChanges();
        }

        private IQueryable<Category> GetCategoty(int id)
        {
            if (!_context.Categories.Any(x => x.Id == id)) throw new Exception("Category not found.");

            return _context.Categories.Where(x => x.Id == id);
        }

        public CategoryViewModel Get(int id)
        {
            return _mapper.Map<Category, CategoryViewModel>(GetCategoty(id).FirstOrDefault());
        }

        public IEnumerable<Category> GetCategories()
        {
            if (_context.Categories == null) throw new Exception("Categories not found.");
            return _context.Categories.ToList();
        }

        public CategoryViewModel GetByName(string name)
        {
            if (!_context.Categories.Any(x => x.Name == name)) throw new Exception("Category not found.");

            var category = _context.Categories.Where(x => x.Name == name).FirstOrDefault();
            var mapped = _mapper.Map<Category, CategoryViewModel>(category);
            //mapped.Restaurants = category.Restaurants;
            return mapped;
        }

        public bool IsExists(string name)
        {
            return _context.Categories.Any(x => x.Name == name);
        }





        public Category GetByNameCategory(string name)
        {
            if (!_context.Categories.Any(x => x.Name == name)) throw new Exception("Category not found.");
          
            return _context.Categories.Where(x => x.Name == name).FirstOrDefault();
        }




    }
}
