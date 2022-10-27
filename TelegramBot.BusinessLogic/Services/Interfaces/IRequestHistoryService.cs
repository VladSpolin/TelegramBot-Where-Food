using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Interfaces
{
    public interface IRequestHistoryService
    {
        IEnumerable<RequestHistory> GetAll();
        RequestHistory Get(int id);
        void Create(RequestHistory requestHistory );
        void Delete(int id);
    }
}
