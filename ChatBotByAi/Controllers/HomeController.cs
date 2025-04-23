using ChatBotAi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

public class HomeController : Controller
{
    private readonly IAiService _aiService;
    private readonly IHubContext<ChatHub> _hubContext;

    public HomeController(IAiService aiService, IHubContext<ChatHub> hubContext)
    {
        _aiService = aiService;
        _hubContext = hubContext;
    }

    public IActionResult Index()
    {
        return View();
    }

}