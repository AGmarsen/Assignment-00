namespace Helloworld.tests;

public class HelloworldTester
{
    /*[Fact]
    public void Helloworld_print()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        var program = Assembly.Load(nameof(Helloworld));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello world!");
    }*/

    [Fact]
    public void LeapYearFuncTester()
    {
        var runner = new Program();
        runner.LeapYear(2000).Should().Be(true);
        runner.LeapYear(1).Should().Be(false);
        runner.LeapYear(200).Should().Be(false);
        runner.LeapYear(1753).Should().Be(false);
        runner.LeapYear(2100).Should().Be(false);
        runner.LeapYear(1996).Should().Be(true);
    }

    [Fact]
    public void LeapYearInterfaceTester()
    {
        runMainWithInput("1666").Should().Be("nay");
        runMainWithInput("2000").Should().Be("yay");
        runMainWithInput("1999").Should().Be("nay");
        runMainWithInput("1900").Should().Be("nay");
        runMainWithInput("1904").Should().Be("nay");
    }

    private String runMainWithInput(String input) {
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var program = Assembly.Load(nameof(Helloworld));
        Console.SetIn(new StringReader(input));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });
        return writer.GetStringBuilder().ToString().TrimEnd();
    }
}