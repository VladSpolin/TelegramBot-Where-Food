using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        CategoryViewModel Get(int id);
        CategoryViewModel GetByName(string name);
        Category GetByNameCategory(string name);
        void Create(CategoryViewModel model);
        void Delete(int id);
        bool IsExists(string name);
        void Edit(int id, CategoryViewModel model);
    }
}
