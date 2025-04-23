namespace ChatBotByAi.Co
{
    public class AppSettings
    {
        public InformationRequestText InformationRequestText { get; set; }
        public InformationRequestImage InformationRequestImage { get; set; }
        public InformationMain InformationMain { get; set; }
    }

    public class InformationMain
    {
        public string ApiKey { get; set; }
        public string UrlApi { get; set; }
    }

    public class InformationRequestText
    {
        public string MessageConcint { get; set; }
        public string ModelAi { get; set; }
    }

    public class InformationRequestImage
    {
        public string Model { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Steps { get; set; }
        public int N { get; set; }
        public string ResponseFormat { get; set; }
    }
}
