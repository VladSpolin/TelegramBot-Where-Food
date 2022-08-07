using AutoMapper;
using TelegramBot.BusinessLogic.Services.Implementations;
using TelegramBot.BusinessLogic.Services.Interfaces;
using TelegramBot.Controllers;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Microsoft.Extensions.DependencyInjection;
using TelegramBot.Common.Mapper;
using TelegramBot.Model;
using TelegramBot.Model.Seeds;


var mappingConfig = new MapperConfiguration(x =>
{
    x.AddProfile(new MappingProfile());
});
IMapper mapper = mappingConfig.CreateMapper();

var serviceProvider = new ServiceCollection()
            .AddLogging()
            .AddTransient<ICategoryService, CategoryService>()
            .AddTransient<IRestaurantService, RestaurantService>()
            .AddDbContext<ApplicationContext>()
            .AddSingleton(mapper)
            .BuildServiceProvider();


serviceProvider.GetService<ApplicationContext>().Seed();


var client = new TelegramBotClient("5565583712:AAH1Im3Y-c_Y48rlM14aXJlmuKriY8ZbmqU");

using var cts = new CancellationTokenSource();

var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = { }
};

var telegramBotController = new TelegramBotController(serviceProvider.GetService<IRestaurantService>(), serviceProvider.GetService<ICategoryService>());


client.StartReceiving(
    telegramBotController.HandleUpdatesAsync,
    telegramBotController.HandleError,
    receiverOptions,
    cancellationToken: cts.Token);
Console.WriteLine("Bot is working...");
Console.ReadLine();

cts.Cancel();