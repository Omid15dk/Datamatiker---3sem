using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace MyPhoneGoesPingRazor.Pages;

public class IndexModel : PageModel
{
    private readonly ITelegramBotClient _bot;
    private readonly TelegramOptions _opts;

    public IndexModel(ITelegramBotClient bot, IOptions<TelegramOptions> opts)
    {
        _bot = bot;
        _opts = opts.Value;
    }

    [BindProperty]
    public long? ChatId { get; set; }

    [BindProperty]
    public string? Text { get; set; }

    public string? ResultMessage { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostSendAsync()
    {
        var chatId = ChatId ?? _opts.DefaultChatId;
        if (chatId == 0)
        {
            ResultMessage = "No chat id provided or default not configured.";
            return Page();
        }

        var text = string.IsNullOrWhiteSpace(Text) ? "Ping" : Text;
        var msg = await _bot.SendMessage(new ChatId(chatId), text);
        ResultMessage = $"Sent message {msg.MessageId}: {msg.Text}";
        return Page();
    }
}
