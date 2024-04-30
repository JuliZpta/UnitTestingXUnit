using Xunit;
using Moq;
using Microsoft.Extensions.Logging;
using StringManipulation; 

public class StringManipulationTest
{
    [Fact]
    public void TestConcatenateStrings()
    {
        var stringOperations = new StringOperations();
        string str1 = "Hello";
        string str2 = "World";

        string result = stringOperations.ConcatenateStrings(str1, str2);
        
        Assert.Equal("Hello World", result);
    }

    [Fact]
    public void TestReverseString()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "hello";

        // Act
        string result = stringOperations.ReverseString(input);

        // Assert
        Assert.Equal("olleh", result);
    }

    [Fact]
    public void TestGetStringLength()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "Hello";

        // Act
        int length = stringOperations.GetStringLength(input);

        // Assert
        Assert.Equal(5, length);
    }

    [Fact]
    public void TestRemoveWhitespace()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "Hello World";

        // Act
        string result = stringOperations.RemoveWhitespace(input);

        // Assert
        Assert.Equal("HelloWorld", result);
    }

    [Fact]
    public void TestTruncateString()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "Hello World";

        // Act
        string result = stringOperations.TruncateString(input, 5);

        // Assert
        Assert.Equal("Hello", result);
    }

    [Fact]
    public void TestIsPalindrome()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string inputPalindrome = "level";
        string inputNotPalindrome = "hello";

        // Act & Assert
        Assert.True(stringOperations.IsPalindrome(inputPalindrome));
        Assert.False(stringOperations.IsPalindrome(inputNotPalindrome));
    }

    [Fact]
    public void TestCountOccurrences()
    {
        // Arrange
        var loggerMock = new Mock<ILogger<StringOperations>>();
        var stringOperations = new StringOperations(loggerMock.Object);
        string input = "hello";

        // Act
        int result = stringOperations.CountOccurrences(input, 'l');

        // Assert
        Assert.Equal(2, result);
        loggerMock.Verify(x => x.LogInformation(It.IsAny<string>()), Times.Once);
    }

    [Fact]
    public void TestPluralize()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string inputSingular = "apple";
        string inputPlural = "person";

        // Act
        string resultSingular = stringOperations.Pluralize(inputSingular);
        string resultPlural = stringOperations.Pluralize(inputPlural);

        // Assert
        Assert.Equal("apples", resultSingular);
        Assert.Equal("people", resultPlural);
    }

    [Fact]
    public void TestQuantintyInWords()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "apple";
        int quantity = 2;

        // Act
        string result = stringOperations.QuantintyInWords(input, quantity);

        // Assert
        Assert.Equal("two apples", result);
    }

    [Fact]
    public void TestFromRomanToNumber()
    {
        // Arrange
        var stringOperations = new StringOperations();
        string input = "XIV";

        // Act
        int result = stringOperations.FromRomanToNumber(input);

        // Assert
        Assert.Equal(14, result);
    }
}