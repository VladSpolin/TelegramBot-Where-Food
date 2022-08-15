using AutoMapper;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;
using TelegramBot.Model;
using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.BusinessLogic.Services.Implementations
{
    public class TimetableService : ITimetableService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public TimetableService(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void Create(TimetableViewModel model)
        {
            var mapped = _mapper.Map<Timetable>(model);
            mapped.RestaurantId = model.RestaurantId;
            mapped.ItsRestaurant = _mapper.Map<Restaurant>(model.ItsRestaurant);
            _context.Timetables.Add(mapped);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Timetables.Remove(GetTimetable(id).FirstOrDefault());
            _context.SaveChanges();
        }

        public void Edit(int id, TimetableViewModel model)
        {
            var timetable = GetTimetable(id).FirstOrDefault();
            var mapped = _mapper.Map<TimetableViewModel, Timetable>(model, timetable);
            mapped.ItsRestaurant = _mapper.Map<Restaurant>(model.ItsRestaurant);
            _context.Timetables.Update(mapped);
            _context.SaveChanges();
        }

        public TimetableViewModel Get(int id)
        {
            return _mapper.Map<Timetable, TimetableViewModel>(GetTimetable(id).FirstOrDefault());

        }

        public IEnumerable<Timetable> GetAll()
        {
            if (_context.Timetables == null) throw new Exception("Timetable not found.");
            return _context.Timetables.ToList();
        }


        private IQueryable<Timetable> GetTimetable(int id)
        {
            if (!_context.Timetables.Any(x => x.Id == id)) throw new Exception("Timetable not found.");

            return _context.Timetables.Where(x => x.Id == id);
        }

    }
}
