using FluentAssertions;
using RBlade.CodeBuilder.Builder;
using RBlade.CodeBuilder.Builder.TypeBuilder;
using RBlade.CodeBuilder.Tests.TestUtils;

namespace RBlade.CodeBuilder.Tests.Builder;

public class CodeFileBuilderTest {
    [Test]
    public void BasicCodeFile_ShouldBeCreatedCorrectly() {
        // Act
        var builder = new CodeFileBuilder().AddUsingDirective("Test")
                                           .AddClass(new ClassBuilder { Name = "Class1" })
                                           .AddUsingDirective("Test.Namespace")
                                           .AddClass(new ClassBuilder { Name = "Class2" });

        // Assert
        var expectedOutput = TestDataLoader.Load("Builder", "BasicCodeFile.expected.txt");
        builder.ToString().Should().Be(expectedOutput);
    }
}