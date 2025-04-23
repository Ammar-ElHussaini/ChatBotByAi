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

Project Structure – Explanation of Core Components
1. AppSettings
Responsible for loading and mapping configuration values from appsettings.json, including:
API keys
AI model names and parameters
Text and image generation settings Used with IOptions<AppSettings> to inject strongly-typed configuration into services.

2. ChatHub (SignalR)
A real-time hub that:
Receives messages from users.
Sends AI-generated responses back instantly.
Facilitates smooth, interactive conversations without page reloads.

3. ChatMessage
Model class representing a single chat message. Includes:
Message content
Sender information (e.g., user or AI)
Timestamp
Flags for role or status Helps structure and display the conversation history.

4. AiService
The core service that:
Takes input from ChatHub
Prepares the message and settings
Calls ExternalInformation to interact with the external AI API
Returns a response to the SignalR hub
Implements business logic and ensures separation of concerns.

6. ExternalInformation
Handles HTTP communication with the AI API. Responsibilities:
Builds and sends requests (via HttpClient)
Parses and returns the API response
Supports both text and image generation endpoints
Keeps all HTTP logic isolated and reusable.

6. RequestApi
Data model for serializing request payloads to the external AI API. Defines:
Model name
Prompt/message
Additional parameters (e.g., temperature, max tokens, format)
Ensures all requests are structured and validated properly before sending.
