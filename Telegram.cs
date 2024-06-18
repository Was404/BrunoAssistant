using Telegram.Bot;
using Telegram.Bot.Extensions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

class Telegram
{
    private static readonly string BotToken = "7239479589:AAHaClQ2kRyZ3aYnpgMpqnE1duC3FWmzRCU";

    private static readonly TelegramBotClient BotClient = new TelegramBotClient(BotToken);

    static async Task Main(string[] args)
    {
        Console.WriteLine("Запуск бота...");

        var cts = new CancellationTokenSource();
        var cancellationToken = cts.Token;
        var receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = { }
        };

        BotClient.StartReceiving(
            updateHandler: HandleUpdateAsync,
            pollingErrorHandler: HandlePollingErrorAsync,
            receiverOptions: receiverOptions,
            cancellationToken: cancellationToken
        );

        Console.WriteLine("Бот запущен. Ожидание команд...");
        Console.ReadLine();

        cts.Cancel();
    }

    private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
    {
        if (update.Type != UpdateType.Message)
            return;

        if (update.Message!.Type != MessageType.Text)
            return;

        var messageText = update.Message.Text.ToLower();
        var chatId = update.Message.Chat.Id;

        Console.WriteLine($"Получено сообщение '{messageText}' в чате {chatId}.");

        switch (messageText)
        {
            case "/start":
                await botClient.SendTextMessageAsync(chatId, "Привет! Я бот. Напиши /help, чтобы узнать больше.");
                break;
            case "/help":
                await botClient.SendTextMessageAsync(chatId, "Список доступных команд:\n/start - начало работы\n/help - этот список");
                break;
            default:
                await botClient.SendTextMessageAsync(chatId, "Я не понимаю команду. Используйте /help.");
                break;
        }
    }
    private static Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
    {
        Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        return Task.CompletedTask;
    }
}