using ClearMeasureHomeWorkLibrary;

var ok = int.TryParse(Console.ReadLine(), out var upperBound);
if (!ok) upperBound = 100;

DivisibleHelperLibrary.Print(upperBound);
