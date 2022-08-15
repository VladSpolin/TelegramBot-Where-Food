using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.BusinessLogic.Services.Interfaces;

namespace TelegramBot.Controllers
{
    public class TelegramBotController
    {
        private readonly ICategoryService _categoryService;
        public TelegramBotController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        public async Task HandleUpdatesAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {

            if (update.Type == UpdateType.Message && update?.Message?.Text != null)
            {
                await HandleMessage(botClient, update.Message);
                return;
            }
        }

        public Task HandleError(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
            return Task.CompletedTask;
        }

        public async Task HandleMessage(ITelegramBotClient botClient, Message message)
        {
            if (message.Text == "/start")
            {
                SendStart(botClient, message);
                return;
            }

            if (message.Text == "Начать")
            {
                SendCategoties(botClient, message);
                return;
            }

            if (_categoryService.IsExists(message.Text))
            {
                SendRestaurants(botClient, message);
                return;
            }

            if (message.Text == "Выбрать другое!")
            {
                SendAnother(botClient, message);
                return;
            }

            await botClient.SendTextMessageAsync(message.Chat.Id, $"You said:\n{message.Text}");
        }

        private async void SendAnother(ITelegramBotClient botClient, Message message)
        {
            var categories = _categoryService.GetCategories().ToList();
            var keyboardbuttons = new KeyboardButton[categories.Count][];
            for (int i = 0; i < categories.Count; i++)
            {
                keyboardbuttons[i] = new KeyboardButton[] { categories[i].Name };
            }

            var keyboard = new ReplyKeyboardMarkup(keyboardbuttons);
            keyboard.ResizeKeyboard = true;

            botClient.SendTextMessageAsync(message.Chat.Id, "Что бы вы хотели покушать?", replyMarkup: keyboard);
        }

        private async void SendRestaurants(ITelegramBotClient botClient, Message message)
        {
            var category = _categoryService.GetByNameCategory(message.Text);
            var restaurants = category.Restaurants.ToList();
            var dayofweekname = new List<string> {"Вс","Пн", "Вт", "Ср","Чт","Пт","Сб" };
            ReplyKeyboardMarkup keyboard = new(new KeyboardButton[] { "Выбрать другое!" })
            {
                ResizeKeyboard = true
            };
            botClient.SendTextMessageAsync(message.Chat.Id, "Места, куда вы можете сходить:", replyMarkup: keyboard).Wait();

            foreach (var restaurant in restaurants)
            {
                var keyboardLink = new InlineKeyboardMarkup(new InlineKeyboardButton[]
                {
                        InlineKeyboardButton.WithUrl("Подробнее", $"{restaurant.Link}")
                });
                var timetables = restaurant.Timetables.ToList();
                timetables.Sort((x, y) => x.Day.CompareTo(y.Day));
                string rr = string.Empty;
                foreach (var timetable in timetables)
                {
                    rr += $"{dayofweekname[(int)timetable.Day]} {timetable.Opened.ToString(@"hh\:mm")}-{timetable.Closed.ToString(@"hh\:mm")}\r\n";
                }
                botClient.SendPhotoAsync(message.Chat.Id, photo: restaurant.PhotoLink, $"{restaurant.Name}\r\n\r\n" + rr + $"\r\n{restaurant.Adress}", replyMarkup: keyboardLink);
            }
        }

        private async void SendCategoties(ITelegramBotClient botClient, Message message)
        {
            var categories = _categoryService.GetCategories().ToList();
            var keyboardbuttons = new KeyboardButton[categories.Count][];
            for (int i = 0; i < categories.Count; i++)
            {
                keyboardbuttons[i] = new KeyboardButton[] { categories[i].Name };
            }

            var keyboard = new ReplyKeyboardMarkup(keyboardbuttons);
            keyboard.ResizeKeyboard = true;

            botClient.SendTextMessageAsync(message.Chat.Id, "Пришло время выбрать, что бы вы хотели покушать!", replyMarkup: keyboard);
        }

        private async void SendStart(ITelegramBotClient botClient, Message message)
        {
            ReplyKeyboardMarkup keyboard = new(new KeyboardButton[] { "Начать" })
            {
                ResizeKeyboard = true
            };
            await botClient.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать!\r\nДля поиска места, где перекусить, нажмите Начать.", replyMarkup: keyboard);
        }
    }
}
