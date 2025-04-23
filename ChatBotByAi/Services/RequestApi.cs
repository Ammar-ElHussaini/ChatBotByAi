using ChatBotByAi.Co;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using Microsoft.Extensions.Options;

namespace ChatBotByAi.Services
{
    public class RequestApi
    {
        private readonly ExternalInformation _ExternalInformation;

        public RequestApi(ExternalInformation ExternalInformation)
        {
            _ExternalInformation = ExternalInformation;
        }

        public string RequestTextFromApi(string userMessage, AppSettings appSetting)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", appSetting.InformationMain.ApiKey);

            var requestData = new
            {
                model = appSetting.InformationRequestText.ModelAi,
                messages = new[]
                {
                new { role = "user", content = $"{appSetting.InformationRequestText.MessageConcint}{userMessage}" }
            },
                max_tokens = 100
            };

            var content = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync(appSetting.InformationMain.UrlApi, content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;

            return _ExternalInformation.ExtractTextFromResponse(responseString);
        }
        public string RequestImageFromApi(string prompt, AppSettings appSetting)
        {
            using var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", appSetting.InformationMain.ApiKey);

            var requestData = new
            {
                model = appSetting.InformationRequestImage.Model,
                prompt = prompt,
                width = appSetting.InformationRequestImage.Width,
                height = appSetting.InformationRequestImage.Height,
                steps = appSetting.InformationRequestImage.Steps,
                n = appSetting.InformationRequestImage.N,
                response_format = appSetting.InformationRequestImage.ResponseFormat,
                stop = Array.Empty<string>()
            };

            var content = new StringContent(JsonSerializer.Serialize(requestData), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync(appSetting.InformationMain.UrlApi, content).Result;
            var responseString = response.Content.ReadAsStringAsync().Result;

            var base64Image = _ExternalInformation.ExtractImageFromResponse(responseString);
            return $"data:image/png;base64,{base64Image}";
        }
    }
}
