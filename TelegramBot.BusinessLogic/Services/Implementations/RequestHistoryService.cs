using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Model;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Implementations
{
    public class RequestHistoryService: IRequestHistoryService
    {
        private readonly ApplicationContext _context;

        public RequestHistoryService(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(RequestHistory requestHistory)
        {

            _context.HistoryRequests.Add(requestHistory);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.HistoryRequests.Remove(Get(id));
            _context.SaveChanges();
        }

        public RequestHistory Get(int id)
        {
            if (!_context.HistoryRequests.Any(x => x.Id == id)) throw new Exception("Request not found.");

            return _context.HistoryRequests.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<RequestHistory> GetAll()
        {
            if (_context.HistoryRequests == null) throw new Exception("Requests not found.");
            return _context.HistoryRequests.ToList();
        }
    }
}
