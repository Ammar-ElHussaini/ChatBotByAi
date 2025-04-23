using System.Text.Json;

namespace ChatBotByAi.Services
{
    public class ExternalInformation
    {
        public string ExtractTextFromResponse(string responseString)
        {
            using var doc = JsonDocument.Parse(responseString);
            return doc.RootElement
                      .GetProperty("choices")[0]
                      .GetProperty("message")
                      .GetProperty("content")
                      .GetString();
        }
        public string ExtractImageFromResponse(string responseString)
        {
            using var doc = JsonDocument.Parse(responseString);
            return doc.RootElement
                      .GetProperty("data")[0]
                      .GetProperty("b64_json")
                      .GetString();
        }
    }
}
