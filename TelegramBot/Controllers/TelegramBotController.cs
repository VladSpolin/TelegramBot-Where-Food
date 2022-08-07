using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Common.ViewModels;

namespace TelegramBot.Controllers
{
    public class TelegramBotController
    {
        private readonly IRestaurantService _restaurantService;
        private readonly ICategoryService _categoryService;
        public TelegramBotController(IRestaurantService restaurantService, ICategoryService categoryService)
        {
            _restaurantService = restaurantService;
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
                ReplyKeyboardMarkup keyboard = new(new KeyboardButton[] { "Начать" })
                {
                    ResizeKeyboard = true
                }; 
                await botClient.SendTextMessageAsync(message.Chat.Id, "Добро пожаловать!\r\nДля поиска места, где перекусить, нажмите Начать.", replyMarkup: keyboard);
                return;
            }

            if (message.Text == "Начать")
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
                return;
            }

            if (_categoryService.IsExists(message.Text))
            {
                var category = _categoryService.GetByNameCategory(message.Text);
                var restaurants = category.Restaurants.ToList();
                ReplyKeyboardMarkup keyboard = new(new KeyboardButton[] { "Выбрать другое!" })
                {
                    ResizeKeyboard = true
                };
                botClient.SendTextMessageAsync(message.Chat.Id, "Места, куда вы можете сходить:", replyMarkup: keyboard);
                foreach(var restaurant in restaurants)
                {
                    botClient.SendTextMessageAsync(message.Chat.Id, $"{restaurant.Name}\r\n{restaurant.Adress}");
                }
                return;
            }

            if (message.Text == "Выбрать другое!")
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
                return;
            }

            await botClient.SendTextMessageAsync(message.Chat.Id, $"You said:\n{message.Text}");
        }

    }
}
