using ChatBotByAi.Models;
using System.Linq;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using ChatBotByAi.Co;
using Microsoft.Extensions.Options;
using ChatBotByAi.Services;

public interface IAiService
{
    string GenerateTextResponse(string userMessage);
    string GenerateImageResponse(string prompt);
}

public class AiService : IAiService
{
    private readonly AppSettings _appSetting;
    private readonly ExternalInformation _ExternalInformation;
    private readonly RequestApi _RequestApi;

    public AiService(IOptions<AppSettings> appSetting , ExternalInformation ExternalInformation, RequestApi RequestApi)
    {
        _appSetting = appSetting.Value;
        _ExternalInformation = ExternalInformation;
        _RequestApi = RequestApi;
    }

   
    public string GenerateTextResponse(string userMessage)
    {
        var responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "مرحبا", "أهلاً وسهلاً بك! كيف يمكنني مساعدتك اليوم؟" },
            { "كيف حالك", "أنا بخير، شكراً لسؤالك! كيف يمكنني مساعدتك؟" },
            { "شكرا", "العفو! دائماً في خدمتك." },
            { "السلام عليكم", "وعليكم السلام ورحمة الله وبركاته!" }
        };

        if (responses.TryGetValue(userMessage, out var response))
        {
            return response;
        }

        return _RequestApi.RequestTextFromApi(userMessage, _appSetting);
    }
    public string GenerateImageResponse(string prompt)
    {
        return _RequestApi.RequestImageFromApi(prompt, _appSetting);
    }
}
