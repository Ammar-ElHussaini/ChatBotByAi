AI ChatBot System – ASP.NET Core MVC | C# | SignalR | Clean Architecture

Developed an intelligent AI-powered chatbot system designed to provide concise and helpful Arabic responses that explain how to perform tasks instead of simply showing results. The chatbot is tailored to assist users of websites or e-commerce platforms by offering real-time, contextual support directly within the interface.

Key Features & Technologies:

✅ Backend: Built using ASP.NET Core 8 MVC following a clean, layered architecture to ensure scalability and maintainability.

✅ Real-Time Communication: Integrated SignalR for instant AI-driven responses without page reloads, delivering a smooth and engaging user experience.

✅ User-Centric Design: Specifically designed to assist users on websites or online stores, acting as an intelligent assistant that enhances user interaction and satisfaction.

✅ Configuration Management: Utilized IOptions<AppSettings> to strongly bind configuration settings from appsettings.json.

✅ Dependency Injection: Registered and managed services such as IAiService and ExternalInformation via .NET Core's built-in DI container.

✅ API Integration: Connected with external AI APIs to generate both text and image-based replies based on user input.

✅ AI Models: Implemented advanced models like Meta-Llama 3.1 for text generation and FLUX.1-dev for image creation, with custom parameters including resolution, steps, and output format.

✅ Code Quality: Followed clean code principles with single responsibility, proper abstraction, and modular service design to ensure high maintainability and clarity.
