using FluentAssertions;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Tests.Builder.TypeBuilder.ClassBuilder;

public class ClassBuilderTest {
    [Test]
    public void BasicClass_ShouldBeCreatedCorrectly() {
        // Arrange
        var codeBuilder = new CodeStringBuilder();

        // Act
        var classBuilder = new CodeBuilder.Builder.TypeBuilder.ClassBuilder() {
            Name = "BasicClass"
        };
        classBuilder.Build(codeBuilder);

        // Assert
        var expectedOutput = File.ReadAllText(Path.Combine(TestContext.CurrentContext.TestDirectory, "Builder",
        "TypeBuilder", "ClassBuilder", "BasicClass.expected.txt"));
        codeBuilder.ToString().Should().Be(expectedOutput);
    }
}