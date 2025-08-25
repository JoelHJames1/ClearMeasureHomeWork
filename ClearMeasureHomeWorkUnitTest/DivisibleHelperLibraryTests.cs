using ClearMeasureHomeWorkLibrary;
using Xunit;

namespace ClearMeasureHomeWorkUnitTest;

public class DivisibleHelperLibraryTests
{
    [Theory]
    [InlineData(3, "Joel")]
    [InlineData(5, "Hernandez")]
    [InlineData(6, "Joel")]
    [InlineData(10, "Hernandez")]
    [InlineData(15, "Hernandez")] 
    [InlineData(30, "Hernandez")]
    [InlineData(7, "7")]
    [InlineData(1, "1")]
    public void Evaluate_Individual_Values_Work(int n, string expected)
    {
        var result = n % 5 == 0 ? "Hernandez" : n % 3 == 0 ? "Joel" : n.ToString();
        Assert.Equal(expected, result);
    }
}