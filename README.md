# Clear Measure Homework

Console app that prints numbers 1 to N with custom rules.

## Rules
- Divisible by 5 → "Hernandez" 
- Divisible by 3 → "Joel"
- Everything else → the number
- 5 beats 3 (so 15 = "Hernandez")

use the library:
```csharp
DivisibleHelperLibrary.Print(100);
```

## Testing
```
dotnet test
```

## Bug Fix
15 now prints "Hernandez" instead of "Joel".
