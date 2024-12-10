# Project: Playing Cards Shuffle Demonstration

This project is an implementation using modern **C# 13.0** on the **.NET 9.0** framework. The purpose of this
demonstration is to showcase card deck manipulation by generating, shuffling, and comparing cards using LINQ-based query
and method syntax. It employs techniques like interleaving sequences and tracking shuffling iterations.

It is based on the 
tutorial [Work with Language-Integrated Query (LINQ)](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq)

## Prerequisites

Ensure you have the following software installed on your system:

- **.NET 9.0 SDK**: You can download it from the [official .NET website](https://dotnet.microsoft.com/en-us/download).
- A C# code editor such as **JetBrains Rider**, **Visual Studio**, or any editor of your choice that supports .NET 9.0.

## Cloning the Repository

To get a copy of the project up and running on your local machine, follow these steps:

Open a terminal or command prompt and clone the repository using the following command:

```shell
git clone <repository-url>
```

Replace `<repository-url>` with the actual repository URL.

Navigate to the project's folder:

```shell
cd <repository-folder>
```

## Running the Project

Open the cloned project in your preferred IDE or editor (JetBrains Rider, Visual Studio, etc.).

Restore required dependencies (if any) by running:

```shell
dotnet restore
```

Build the project using:

```shell
dotnet build
```

Run the project with:

```shell
dotnet run
```

## Project Explanation

This application demonstrates operations on a deck of playing cards, including:

1. The **generation** of a standard 52-card deck composed of four suits and thirteen ranks.
2. **Performing interleaved shuffles** (both "out" and "in" shuffle types).
3. **Tracking iterations** to return the deck to its original order.
4. Displaying the **process and results** in the console.

### Highlights of the Code

- LINQ queries and method chains are used for operations.
- Iterators (`yield return`) are leveraged to define card ranks and suits.
- Functional concepts like `Take`, `Skip`, and custom extensions (e.g., `LogQuery` and `InterleaveSequenceWith`)
  demonstrate sequence processing.

### Extensions in Use

The project potentially relies on custom extension methods such as:

- `InterleaveSequenceWith`: Likely interleaves two sequences, simulating shuffling.
- `LogQuery`: Logs the operations performed on sequences for debugging purposes.

## Contributing

This is a **personal project**. Contributions are **not** required. Anyone interested in developing this project are
welcome to fork or clone for your own use.

## Credits

- [Michael Pritchard \(AKA Pen-y-Fan\)](https://github.com/pen-y-fan) original project
- Microsoft learn [Work with Language-Integrated Query (LINQ)](https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/working-with-linq)

## License

This project is licensed under [MIT License](LICENSE.md). You are free to use, modify, and distribute the project with proper
attribution.