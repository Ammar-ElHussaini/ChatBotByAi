AI ChatBot System – ASP.NET Core MVC | C# | SignalR | Clean Architecture

Developed a smart AI-based chatbot system capable of providing concise, helpful Arabic responses that explain how to perform tasks rather than just showing results. The system features real-time interaction and strong API integration.

Key Features & Technologies:

✅ Backend: Built with ASP.NET Core 8 MVC using a clean, layered architecture for scalability and maintainability.

✅ Real-Time Communication: Integrated SignalR to deliver instant AI responses without page reloads, ensuring smooth and interactive user experience.

✅ Configuration Management: Used IOptions<AppSettings> to bind strongly-typed configuration models from appsettings.json.

✅ Dependency Injection: Registered and managed services like IAiService and ExternalInformation using .NET Core’s built-in DI container.

✅ API Integration: Consumed external AI APIs to generate text and image responses based on user input.

✅ AI Models: Supported advanced models like Meta-Llama 3.1 for text and FLUX.1-dev for image generation with custom parameters (resolution, steps, format).

✅ Code Quality: Applied clean code principles, single responsibility, and proper service abstraction for high maintainability.
