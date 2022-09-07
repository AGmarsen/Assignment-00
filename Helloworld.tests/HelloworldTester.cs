namespace Helloworld.tests;

public class HelloworldTester
{
    [Fact]
    public void Helloworld_print()
    {
        using var writer = new StringWriter();
        Console.SetOut(writer);

        var program = Assembly.Load(nameof(Helloworld));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello world!");
    }
}