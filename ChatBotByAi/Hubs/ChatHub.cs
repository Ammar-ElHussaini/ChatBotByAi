using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    private readonly IAiService _aiService;

    public ChatHub(IAiService aiService)
    {
        _aiService = aiService;
    }

    public async Task SendMessage(string user, string message , string Mode)
    {


            if (Mode == "text")
        {
            string response = _aiService.GenerateTextResponse(message);
            await Clients.Caller.SendAsync("ReceiveMessage", "AI Bot", response, false, DateTime.Now);
        }
        else if (Mode == "image")
        {
            // معالجة النص وإرسال رد بصورة
            string imageUrl = _aiService.GenerateImageResponse(message);
            await Clients.Caller.SendAsync("ReceiveMessage", "AI Bot", imageUrl, true, DateTime.Now);
        }
        
    }
}
