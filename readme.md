# 🧁 Too many sugar
## What is this
**TooManySugar** is a C# library that adds a host of extension methods for rapid development, functional patterns, and clean syntax.
## Quick install
* Install the library
    ```bash
    dotnet add package TooManySugar
* Import library
    ```csharp
    using TooManySugar.Core;
## Some functions
    ```csharp
    // Math & Numbers
    5.Per();                   // 0.05 (5%)
    2.Pow(3);                  // 8.0
    5.Sec();                   // TimeSpan.FromSeconds(5)

    // Strings & Utility
    "C#".Dubl(3);              // "C#C#C#"
    "hello".Invert();          // "olleh"
    double.NaN.Reserve(42.0);  // Returns 42.0 if NaN

    // Collections & Actions
    var list = new[] { 1, 2, 3 };
    list.ToStr();              // "[1, 2, 3]"
    list.Choice();             // Random item from list