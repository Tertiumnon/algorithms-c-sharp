namespace SingleNumber.Tests;

public class UnitTest1
{
    private static readonly int[] Nums = new[] { 2, 2, 1 };

    [Fact]
    public void Test1()
    {
        var solution = new SingleNumberSolution();
        Assert.Equal(1, solution.SingleNumber(Nums));
    }
}