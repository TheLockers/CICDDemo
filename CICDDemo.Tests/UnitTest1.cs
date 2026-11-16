namespace CICDDemo.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_TwoNumbers_ReturnsCorrectSum()
    {
        int result = _calculator.Add(5, 3);

        Assert.Equal(8, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        int result = _calculator.Multiply(5, 3);

        Assert.Equal(15, result);
    }
}
