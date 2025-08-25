namespace ClearMeasureHomeWorkLibrary;

public static class DivisibleHelperLibrary
{
    public static void Print(int upperBound)
    {
        for (int i = 1; i < upperBound; i++)
            Console.WriteLine(i % 5 == 0 ? "Hernandez" : i % 3 == 0 ? "Joel" : i.ToString());
    }
}
