using Xunit;
using MathLibrary;

namespace MathLibrary.Tests;

/// <summary>
/// تحتوي على اختبارات لدالة Multiply
/// </summary>
public class CalculatorTests
{
    // Tests for Multiply
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        // Arrange
        int a = 2, b = 3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        // Arrange
        int a = 0, b = 5;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {
        // Arrange
        int a = -2, b = 3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        // Arrange
        int a = -2, b = -3;

        // Act
        int result = Calculator.Multiply(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    // Tests for Divide
    [Fact]
    public void Divide_TwoPositiveNumbers_ReturnsQuotient()
    {
        int a = 10, b = 2;
        int result = Calculator.Divide(a, b);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_NegativeByPositive_ReturnsNegative()
    {
        int a = -10, b = 2;
        int result = Calculator.Divide(a, b);
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Divide_TwoNegativeNumbers_ReturnsPositive()
    {
        int a = -10, b = -2;
        int result = Calculator.Divide(a, b);
        Assert.Equal(5, result);
    }

    // Tests for IsEven
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        int a = 4;
        bool result = Calculator.IsEven(a);
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        int a = 7;
        bool result = Calculator.IsEven(a);
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        int a = 0;
        bool result = Calculator.IsEven(a);
        Assert.True(result);
    }
}
