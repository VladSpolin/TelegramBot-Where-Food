
using TelegramBot.Common.ViewModels;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Interfaces
{
    public interface ITimetableService
    {
        IEnumerable<Timetable> GetAll();
        TimetableViewModel Get(int id);
        void Create(TimetableViewModel model);
        void Delete(int id);
        void Edit(int id, TimetableViewModel model);
    }
}
