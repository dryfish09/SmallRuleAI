
NtAI - Not an AI

A lightweight, rule-based console chatbot built with C#. This project demonstrates basic programming concepts including input handling, conditional logic, and modular code organization.

## 🚀 Features

- Simple command-line interface
- Case-insensitive command recognition
- Greeting responses for "hi" and "hello"
- Exit command to terminate the program
- Null/empty input handling
- Basic error handling with try-catch

Response messages handler


## 📋 Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- Any C# compatible IDE (Visual Studio, VS Code, Rider, or command line)

## 🔧 Installation & Usage

### Clone and Build

```bash
git clone https://github.com/dryfish09/NtAI.git
cd NtAI/src
dotnet restore
dotnet build
```

### Run the Program

```bash
dotnet run
```

### Example Interaction

```
Welcome! Type 'exit' to exit program
You: hi
 AI: Hi there! What's up!
You: hello
 AI: Hi there! What's up!
You: how are you?
 AI: Sorry, I don't know about that
You: 
 AI: Oops! Please talk anything!
You: exit
(Program ends)
```

## 🎮 Available Commands

| Command | Response |
|---------|----------|
| `hi`, `hello` | Greeting message |
| `exit` | Exit the program |
| (empty input) | Null input handler |
| anything else | Default fallback response |

## 🧠 How It Works

1. **Program.Main()** - Initializes the program and handles unexpected exceptions
2. **Core.Logic()** - Runs the main chat loop:
   - Reads user input
   - Normalizes text (lowercase + trim)
   - Checks for keywords using conditional statements
   - Calls appropriate response methods
3. **Response class** - Contains static methods for different reply types

## 📝 Code Example

```csharp
// Core logic snippet
string input = Console.ReadLine()?.ToLower().Trim() ?? "";
if(string.IsNullOrWhiteSpace(input))
{
    Response.HandleNull();
}
else if(input.Contains("hi") || input.Contains("hello"))
{
    Response.Greet();
}
else if(input == "exit")
{
    run = false;
}
```

## 🔮 Possible Improvements

- [ ] Add more keywords and responses
- [ ] Implement random response variations
- [ ] Add conversation history tracking
- [ ] Integrate with real AI APIs (OpenAI, etc.)
- [ ] Add configuration file for custom responses
- [ ] Implement natural language processing
- [ ] Save chat logs to file

## 🤝 Contributing

Feel free to fork this project and add more features! This is a great starting point for learning C# and OOP concepts.

## 📄 License

MIT License - feel free to use, modify, and distribute.

## 👨‍💻 Author

Dry Fish

---

**Note:** This is a rule-based chatbot, not an AI/ML model. It responds based on keyword matching only.
