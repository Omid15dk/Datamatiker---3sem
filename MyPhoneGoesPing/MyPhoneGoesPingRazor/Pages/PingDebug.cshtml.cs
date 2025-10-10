using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Microsoft.Extensions.Logging;
using Telegram.Bot.Requests;

namespace MyPhoneGoesPingRazor.Pages;

public class PingDebugModel : PageModel
{
    private readonly ITelegramBotClient _bot;
    private readonly TelegramOptions _opts;
    private readonly ILogger<PingDebugModel> _logger;

    public PingDebugModel(ITelegramBotClient bot, IOptions<TelegramOptions> opts, ILogger<PingDebugModel> logger)
    {
        _bot = bot;
        _opts = opts.Value;
        _logger = logger;
    }

    public string? BotUsername { get; private set; }
    public long BotId { get; private set; }

    [BindProperty]
    public long? ChatId { get; set; }

    [BindProperty]
    public string? Text { get; set; }

    public string? ResultMessage { get; private set; }

    public async Task OnGetAsync()
    {
        try
        {
            var me = await _bot.SendRequest(new GetMeRequest());
            BotUsername = me.Username;
            BotId = me.Id;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "GetMeAsync failed");
            ResultMessage = $"GetMe failed: {ex.Message}";
        }
    }

    public async Task<IActionResult> OnPostSendAsync()
    {
        var target = ChatId ?? _opts.DefaultChatId;
        if (target == 0)
        {
            ResultMessage = "No chat id provided and DefaultChatId is not configured.";
            return Page();
        }

        var text = string.IsNullOrWhiteSpace(Text) ? "Ping (debug)" : Text;

        try
        {
            var msg = await _bot.SendMessage(new ChatId(target), text);
            ResultMessage = $"Sent message id {msg.MessageId} to chat {target}";
        }
        catch (ApiRequestException ex)
        {
            // Telegram API returned an error (e.g. chat not found, forbidden, etc.)
            _logger.LogError(ex, "Telegram API error when sending to {ChatId}", target);
            ResultMessage = $"Telegram API error: {ex.Message} (ErrorCode: {ex.ErrorCode})";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error when sending to {ChatId}", target);
            ResultMessage = $"Unexpected error: {ex.Message}";
        }

        return Page();
    }
}