using ClearMeasureHomeWorkLibrary;
using Xunit;

namespace ClearMeasureHomeWorkUnitTest;

public class DivisibleHelperLibraryTests
{
    [Theory]
    [InlineData(4, "1\n2\nJoel\n")]
    [InlineData(6, "1\n2\nJoel\n4\nHernandez\n")]
    [InlineData(16, "1\n2\nJoel\n4\nHernandez\nJoel\n7\n8\nJoel\nHernandez\n11\nJoel\n13\n14\nHernandez\n")]
    public void Print_GeneratesCorrectOutput(int upperBound, string expected)
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        
        DivisibleHelperLibrary.Print(upperBound);
        
        var result = sw.ToString();
        Assert.Equal(expected, result);
    }
}