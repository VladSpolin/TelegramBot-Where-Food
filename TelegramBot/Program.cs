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
            .AddTransient<IRequestHistoryService, RequestHistoryService>()
            .AddDbContext<ApplicationContext>()
            .AddSingleton(mapper)
            .BuildServiceProvider();


serviceProvider.GetService<ApplicationContext>().Seed();


var client = new TelegramBotClient("5497319999:AAHHKTLCfGq5hmjO5y_k0W4Tz3-bS84xAxw");

using var cts = new CancellationTokenSource();

var receiverOptions = new ReceiverOptions
{
    AllowedUpdates = { }
};

var telegramBotController = new TelegramBotController(serviceProvider.GetService<ICategoryService>(), serviceProvider.GetService<IRequestHistoryService>());


client.StartReceiving(
    telegramBotController.HandleUpdatesAsync,
    telegramBotController.HandleError,
    receiverOptions,
    cancellationToken: cts.Token);
Console.WriteLine("Bot is working...");
Console.ReadLine();

cts.Cancel();