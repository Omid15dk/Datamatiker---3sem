using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;

[ApiController]
[Route("api/[controller]")]
public class PingController : ControllerBase
{
    private readonly ITelegramBotClient _bot;
    private readonly TelegramOptions _opts;

    public PingController(ITelegramBotClient bot, IOptions<TelegramOptions> opts)
    {
        _bot = bot;
        _opts = opts.Value;
    }

    [HttpPost]
    public async Task<IActionResult> Post(string? textToSend)
    {
        var chatId = _opts.DefaultChatId;
        if (chatId == 0) return BadRequest(new { ok = false, error = "No chat id provided" });
        var text = string.IsNullOrWhiteSpace(textToSend) ? "Ping" : textToSend;
        var msg = await _bot.SendMessage(new ChatId(chatId), text);
        return Ok(new { ok = true, message_id = msg.MessageId, sent = msg.Text });
    }


    [HttpGet("messages")]
    public async Task<IActionResult> GetMessages()
    {
        var updates = await _bot.GetUpdates();

        // Extract message texts
        var messages = updates
            .Where(u => u.Message != null && !string.IsNullOrEmpty(u.Message.Text))
            .Select(u => new
            {
                from = u.Message.From?.Username ?? u.Message.From?.FirstName,
                text = u.Message.Text,
                date = u.Message.Date.ToLocalTime().ToString("g")
            })
            .ToList();

        return Ok(new { ok = true, count = messages.Count, messages });
    }
}
