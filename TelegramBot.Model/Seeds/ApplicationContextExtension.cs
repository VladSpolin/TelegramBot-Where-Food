using TelegramBot.Model.DataBaseModels;

namespace TelegramBot.Model.Seeds
{
    public static class ApplicationContextExtension
    {
        public static void Seed(this ApplicationContext context)
        {
            var sushi = new Category { Name = "Суши" };
            var pizza = new Category { Name = "Пицца" };
            var burger = new Category { Name = "Бургеры" };
            var coffee = new Category { Name = "Кофе" };
            var shaurma = new Category { Name = "Шаурма" };
            var dessert = new Category { Name = "Десерты" };
            List<Category> categories = new List<Category> { sushi, pizza, burger, coffee, shaurma, dessert };
            foreach (var category in categories)
            {
                if(!context.Categories.Any(x=>x.Name == category.Name))
                    context.Categories.Add(category);
            }
            context.SaveChanges();





            var lakomkaMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(22, 00, 00) };
            var lakomkaTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(22, 00,0) };
            var lakomkaWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(22, 00, 0) };
            var lakomkaThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 00, 0), Closed = new TimeSpan(22, 00, 0) };
            var lakomkaFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 00, 0), Closed = new TimeSpan(22, 00,0) };
            var lakomkaSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 00, 0), Closed = new TimeSpan(22, 00, 0) };
            var lakomkaSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 00, 0), Closed = new TimeSpan(22, 00, 0) };

            var shavermaMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(12, 00, 0), Closed = new TimeSpan(23, 00,0) };
            var shavermaTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(12, 00, 0), Closed = new TimeSpan(23, 00,0) };
            var shavermaWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var shavermaThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var shavermaFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var shavermaSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var shavermaSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };

            var lavashMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };
            var lavashSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 00,0), Closed = new TimeSpan(23, 00,0) };

            var perecMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };
            var perecSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(9, 00,0), Closed = new TimeSpan(19, 00,0) };

            var capibaraMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 40,0) };
            var capibaraTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };
            var capibaraWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };
            var capibaraThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };
            var capibaraFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };
            var capibaraSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };
            var capibaraSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(21, 45,0) };

            var trikitaMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var trikitaSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };

            var krutimMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };
            var krutimSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(22, 0,0) };

            var pizzastationMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };
            var pizzastationSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 30,0) };

            var italianaMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(00, 0,0) };
            var italianaSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(00, 0,0) };

            var unionMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var unionSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };

            var uinstonMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };
            var uinstonSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(00, 0,0) };

            var kfcMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kfcSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(23, 0,0) };

            var mymoMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };
            var mymoSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(11, 0,0), Closed = new TimeSpan(23, 0,0) };

            var obzhoraMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };
            var obzhoraSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(12, 0,0), Closed = new TimeSpan(22, 0,0) };

            var molokoMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(8, 0,0), Closed = new TimeSpan(00, 0,0) };
            var molokoTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(8, 0,0), Closed = new TimeSpan(00, 0,0) };
            var molokoWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(8, 0,0), Closed = new TimeSpan(00, 0,0) };
            var molokoThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(8, 0,0), Closed = new TimeSpan(00, 0,0) };
            var molokoFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(9, 0,0), Closed = new TimeSpan(01, 0,0) };
            var molokoSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(01, 0,0) };
            var molokoSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(00, 0,0) };

            var paragraphMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var paragraphSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };

            var zefirMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var zefirSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };

            var kolosMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kolosTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,0) };
            var kolosWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,00) };
            var kolosThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,00) };
            var kolosFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 0,00) };
            var kolosSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 00,0) };
            var kolosSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(10, 0,0), Closed = new TimeSpan(23, 00,0) };

            var fighterMd = new Timetable { Day = DayOfWeek.Monday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterTd = new Timetable { Day = DayOfWeek.Tuesday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterWd = new Timetable { Day = DayOfWeek.Wednesday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterThd = new Timetable { Day = DayOfWeek.Thursday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterFd = new Timetable { Day = DayOfWeek.Friday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterSatd = new Timetable { Day = DayOfWeek.Saturday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };
            var fighterSund = new Timetable { Day = DayOfWeek.Sunday, Opened = new TimeSpan(12, 00,0), Closed = new TimeSpan(23, 00,0) };

            var timetables = new List<Timetable> {
                lakomkaMd, lakomkaTd, lakomkaWd, lakomkaThd, lakomkaFd, lakomkaSatd, lakomkaSund,
                shavermaMd, shavermaWd, shavermaThd, shavermaTd, shavermaSatd, shavermaSund, shavermaFd,
                lavashMd, lavashTd, lavashWd, lavashThd, lavashFd, lavashSatd, lavashSund,
                perecMd, perecTd, perecWd, perecThd, perecFd, perecSatd, perecSund,
                capibaraMd, capibaraTd, capibaraWd, capibaraThd, capibaraWd, capibaraSatd, capibaraSund,
                trikitaMd, trikitaTd, trikitaWd, trikitaThd,trikitaFd, trikitaSatd, trikitaSund,
                krutimMd, krutimTd, krutimWd, krutimThd, krutimFd, krutimSatd, krutimSund,
                pizzastationMd, pizzastationTd, pizzastationWd, pizzastationThd, pizzastationFd, pizzastationSatd, pizzastationSund,
                italianaMd, italianaTd, italianaWd, italianaThd, italianaFd, italianaSatd, italianaSund,
                unionMd, unionTd, unionWd, unionThd, unionFd, unionSatd, unionSund,
                uinstonMd, uinstonTd, uinstonWd, uinstonThd, uinstonFd, uinstonSatd, uinstonSund,
                kfcMd, kfcTd, kfcWd, kfcThd, kfcFd, kfcSatd, kfcSund,
                mymoMd, mymoTd, mymoWd, mymoThd, mymoFd, mymoSatd, mymoSund,
                obzhoraFd, obzhoraTd, obzhoraWd, obzhoraThd, obzhoraMd, obzhoraSatd, obzhoraSund,
                molokoMd, molokoTd, molokoWd, molokoThd, molokoFd, molokoSatd, molokoSund,
                paragraphMd, paragraphTd, paragraphWd, paragraphThd, paragraphFd, paragraphSatd, paragraphSund,
                zefirMd, zefirTd, zefirWd, zefirThd, zefirFd, zefirSatd, zefirSund,
                kolosFd, kolosTd, kolosWd, kolosThd, kolosMd, kolosSatd, kolosSund,
                fighterFd, fighterTd, fighterWd, fighterThd, fighterMd, fighterSund, fighterSatd
            };





            var restaurants = new List<Restaurant> {
                new Restaurant{Name="Лакомка", Adress="ул. Белова 2" , Categories=new List<Category>{ dessert } ,Link="https://www.instagram.com/lakomkapinsk/", PhotoLink="https://avatars.mds.yandex.net/get-altay/6159907/2a0000018278e7371de74891cb6d82d8a133/XXXL",Timetables = new List<Timetable>{ lakomkaMd, lakomkaTd, lakomkaWd, lakomkaThd, lakomkaFd, lakomkaSatd, lakomkaSund, }},
                new Restaurant{Name="Шаверма", Adress="Железнодорожная 50", Categories=new List<Category>{ shaurma } ,Link="https://www.instagram.com/shaverma.pinsk/", PhotoLink="https://avatars.mds.yandex.net/get-altay/1547687/2a0000016c39043ef3b0e19cfdde2442eefa/XXXL",Timetables = new List<Timetable>{ shavermaMd, shavermaWd, shavermaThd, shavermaTd, shavermaSatd, shavermaSund, shavermaFd, }},
                new Restaurant{Name="Лаваш", Adress="ул. Брестская 19", Categories=new List<Category>{ shaurma } ,Link="https://vk.com/lavashmarvel/", PhotoLink="https://avatars.mds.yandex.net/get-altay/1870294/2a0000016ee156ba7d5f24aa903fd1876a52/XXXL",Timetables = new List<Timetable>{ lavashMd, lavashTd, lavashWd, lavashThd, lavashFd, lavashSatd, lavashSund, }},
                new Restaurant{Name="Перец", Adress="Торговый комплекс, ул. Карла Маркса 29", Categories=new List<Category>{ shaurma },Link="https://vk.com/perec.pinsk/" ,PhotoLink="https://sun9-76.userapi.com/impg/kzk1XNMvzSpysFuwT9C7ppeYU5QPwymUc_WhBQ/eUo1SDspM6M.jpg?size=600x600&quality=96&sign=71fe691f362419b6505c05c005f57536&type=album",Timetables = new List<Timetable>{ perecMd, perecTd, perecWd, perecThd, perecFd, perecSatd, perecSund, } },
                new Restaurant{Name="Капибара", Adress="ул. Первомайская 55; ул. Гайдаенко 102", Categories=new List<Category>{ sushi },Link="https://kapibaras.by/pinsk/",PhotoLink="https://avatars.mds.yandex.net/get-altay/2714499/2a00000171499568f5eba2158aebba777676/XXXL",Timetables = new List<Timetable>{ capibaraMd, capibaraTd, capibaraWd, capibaraThd, capibaraWd, capibaraSatd, capibaraSund, }},
                new Restaurant{Name="Три кита", Adress="ул. Первомайская 24", Categories=new List<Category>{ sushi } ,Link="https://3tri-kita.ru/", PhotoLink="https://lh3.googleusercontent.com/p/AF1QipNzgTIHLzaMBVbxHbzW1MMhkIcE9W1DysB_Yw7t=w768-h768-n-o-v1",Timetables = new List<Timetable>{ trikitaMd, trikitaTd, trikitaWd, trikitaThd, trikitaFd, trikitaSatd, trikitaSund, }},
                new Restaurant{Name="Крутим-Вертим", Adress="ул. Рокоссовского 23д", Categories=new List<Category>{ sushi, pizza } , Link = "https://vk.com/krytim.vertim/",PhotoLink="https://avatars.mds.yandex.net/get-altay/2813737/2a0000017444cc12825fe9c42f995a942000/XXXL",Timetables = new List<Timetable>{ krutimMd, krutimTd, krutimWd, krutimThd, krutimFd, krutimSatd, krutimSund, }},
                new Restaurant{Name="PizzaStation", Adress="ул. Иркутско-Пинской Дивизии 31", Categories=new List<Category>{ sushi, pizza, dessert } , Link = "https://pizzastation.by/", PhotoLink="https://sun9-67.userapi.com/impg/z7Eor-D5GnDk8VTD8LCJA6HNWGBr9eC_W500bg/XHkF5Et2Ca0.jpg?size=1181x1181&quality=96&sign=6497a9974bc63eec6fd6f321b9b49ca7&type=album",Timetables = new List<Timetable>{ pizzastationMd, pizzastationTd, pizzastationWd, pizzastationThd, pizzastationFd, pizzastationSatd, pizzastationSund }},
                new Restaurant{Name="Пицца Итальяна", Adress="ул. Коржа 12", Categories=new List<Category>{ pizza , shaurma } , Link = "https://pinsk.pizza-italiana.by/", PhotoLink="https://sun9-46.userapi.com/impg/c8--VvLak5cAZXDppYwH5TuMINVUN8ULSf1EXA/Bqg3IrPJiOg.jpg?size=1757x1882&quality=95&sign=2465d89d2dd34b0945749ecb3b54cdd9&type=album",Timetables = new List<Timetable>{  italianaMd, italianaTd, italianaWd, italianaThd, italianaFd, italianaSatd, italianaSund,}},
                new Restaurant{Name="Фуд Юнион", Adress="ул. Ленина 26", Categories=new List<Category>{ pizza, burger, coffee, shaurma, dessert } , Link = "https://www.instagram.com/cafefoodunion.pinsk/", PhotoLink="https://www.holiday.by/files/houses/thumbnails/houses_gallery_large_preview/2140ffb82d4e8ea19671aae33b5df7d8.jpg",Timetables = new List<Timetable>{ unionMd, unionTd, unionWd, unionThd, unionFd, unionSatd, unionSund, }},
                new Restaurant{Name="Паб Уинстон Черчилль", Adress="ул. Ленина 32", Categories=new List<Category>{ pizza , burger },Link="https://www.instagram.com/winstonchurchillpinsk/" ,PhotoLink="https://media-cdn.tripadvisor.com/media/photo-s/1a/17/4b/4b/caption.jpg",Timetables = new List<Timetable>{ uinstonMd, uinstonTd, uinstonWd, uinstonThd, uinstonFd, uinstonSatd, uinstonSund, }},
                new Restaurant{Name="KFC", Adress="ул. Брестская 37; ул. Железнодорожная 56; ул. Партизанская 42", Categories=new List<Category>{ burger }  ,Link="https://www.kfc.by/" , PhotoLink="http://d2j6dbq0eux0bg.cloudfront.net/startersite/images/75395028/1654999531673.jpg",Timetables = new List<Timetable>{ kfcMd, kfcTd, kfcWd, kfcThd, kfcFd, kfcSatd, kfcSund, }},
                new Restaurant{Name="МуМо", Adress="ул. Ленина 2-4", Categories=new List<Category>{ burger },Link="https://www.instagram.com/mymo_burger/" , PhotoLink="https://img.restaurantguru.com/refb-Mumo-burger.jpg",Timetables = new List<Timetable>{ mymoMd, mymoTd, mymoWd, mymoThd, mymoFd, mymoSatd, mymoSund, }},
                new Restaurant{Name="Обжора", Adress="ул. Иркутско-Пинской Дивизии 36", Categories=new List<Category>{ burger } , Link = "https://www.instagram.com/obzhora_pinsk/", PhotoLink="https://avatars.mds.yandex.net/get-altay/6195924/2a00000181d3a9b5a7cb30f6790f8bd84eb1/XXXL",Timetables = new List<Timetable>{ obzhoraFd, obzhoraTd, obzhoraWd, obzhoraThd, obzhoraMd, obzhoraSatd, obzhoraSund, }},
                new Restaurant{Name="Молоко", Adress="ул. Первомайская 26", Categories=new List<Category>{ coffee, dessert },Link="https://www.instagram.com/molokopinsk/" ,PhotoLink="https://avatars.mds.yandex.net/get-altay/1871297/2a0000016a5f4b45e84f1f3e8749d1d1fe46/L",Timetables = new List<Timetable>{ molokoMd, molokoTd, molokoWd, molokoThd, molokoFd, molokoSatd, molokoSund, }},
                new Restaurant{Name="Paragraph", Adress="ул. Ленина 2", Categories=new List<Category>{ coffee, dessert } ,Link="https://www.paragraph.by/", PhotoLink="https://img.restaurantguru.com/r9fb-Paragraph-Coffee-cake-2021-08.jpg",Timetables = new List<Timetable>{ paragraphMd, paragraphTd, paragraphWd, paragraphThd, paragraphFd, paragraphSatd, paragraphSund, }},
                new Restaurant{Name="Зефир", Adress="пл. Ленина 7/1", Categories=new List<Category>{ coffee, dessert },Link="https://www.instagram.com/zephyrpinsk/", PhotoLink="https://10619-2.s.cdn12.com/rests/original/107_506549067.jpg",Timetables = new List<Timetable>{ zefirMd, zefirTd, zefirWd, zefirThd, zefirFd, zefirSatd, zefirSund, }},
                new Restaurant{Name="Золотой Колос", Adress="ул. Ленина 22", Categories=new List<Category>{ coffee },Link="https://www.instagram.com/zolotoikolos/" , PhotoLink="https://media-cdn.tripadvisor.com/media/photo-s/19/a6/57/27/photo2jpg.jpg",Timetables = new List<Timetable>{ kolosFd, kolosTd, kolosWd, kolosThd, kolosMd, kolosSatd, kolosSund, }},
                new Restaurant{Name="Sushi Fighter", Adress="ул. Рокоссовского 4В", Categories=new List<Category>{ sushi },Link="http://www.sushifighter.by/rus/ " , PhotoLink="https://media-cdn.tripadvisor.com/media/photo-s/1a/18/62/42/caption.jpg",Timetables = new List<Timetable>{ fighterFd, fighterTd, fighterWd, fighterThd, fighterMd, fighterSund, fighterSatd } },

            };

            foreach(var restaurant in restaurants)
            {
                if(!context.Restaurants.Any(x=>x.Name==restaurant.Name))
                    context.Restaurants.Add(restaurant);
            }
            context.SaveChanges();

            if (context.Timetables.Count() == 0)
            {
                foreach (var timetable in timetables)
                {
                    context.Timetables.Add(timetable);
                }

                context.SaveChanges();
            }

        }
    }
}
