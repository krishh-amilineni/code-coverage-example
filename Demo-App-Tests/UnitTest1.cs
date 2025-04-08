using Demo_App;

namespace Demo_App_Tests;

public class UnitTest1
{
   [Fact]
    public void NoArguments_Test()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main([]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Hello there!{Environment.NewLine}{Environment.NewLine}Complete", output);
    }

    [Fact]
    public void OneArguments_Test()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main(["UNIT TEST"]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Howdy, UNIT TEST!{Environment.NewLine}{Environment.NewLine}Complete", output);
    }

    [Fact]
    public void OneArguments_Test_Expect_additional()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main(["TEST"]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Howdy, TEST!{Environment.NewLine}{Environment.NewLine}Calling from another method{Environment.NewLine}Complete", output);
    }

    [Fact]
    public void OneArgument_NewBranch_Test()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        Program.Main(["New Branch"]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal($"Howdy, New Branch!{Environment.NewLine}{Environment.NewLine}This is a new uncovered area.{Environment.NewLine}Complete", output);
    }

    [Theory]
    [InlineData("test")]
    [InlineData("TEST")]
    [InlineData("Test")]
    public void Helper_AnotherMethod_TestCase(string input)
    {
        // Arrange
        var helper = new Helper();
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        helper.AnotherMethod(input);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal("Calling from another method", output);
    }

    [Fact]
    public void Helper_AnotherMethod_NewBranchCase()
    {
        // Arrange
        var helper = new Helper();
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        helper.AnotherMethod("New Branch");

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal("This is a new uncovered area.", output);
    }
}