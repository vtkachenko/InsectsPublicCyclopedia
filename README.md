# Insects Public Cyclopedia
Sample .NET 8 Blazor Application to test DALL-E Image Generation, integrated into .NET through OpenAI API.

## Sample Insects to try generating :)

- Monarch Butterfly
- Ladybug
- Dragonfly
- Moskito
- Ant
- Bee
- Grasshopper
- ... you name it

## Prerequisites

- [.NET 8 Runtime](https://dotnet.microsoft.com/download/dotnet/8.0)
- [.NET CLI](https://docs.microsoft.com/en-us/dotnet/core/tools/)
- Paid OpenAI API Subscription with valid [OpenAI API Key](https://platform.openai.com/api-keys)

## How to launch the app locally
- Clone the repository to your local folder.

- Navigate to the project folder using the following command: `cd InsectsPublicCyclopedia` and invoke Entity Framework Core CLI to create SQLite database using the following command: `dotnet ef database update`.

- Add your valid [OpenAI Project API Key](https://platform.openai.com/api-keys) to User Secrets using the following .NET CLI command: `dotnet user-secrets set "OpenAI:ApiKey" "your-openai-api-key"`

- Run the application using the following command: `dotnet run`