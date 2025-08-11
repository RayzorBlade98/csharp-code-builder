using FluentAssertions;
using RBlade.CodeBuilder.Builder.MemberBuilder;
using RBlade.CodeBuilder.Tests.TestUtils;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Tests.Builder.MemberBuilder;

public class MethodBuilderTest {
    [Test]
    public void BasicMethod_ShouldBeCreatedCorrectly() {
        // Arrange
        var codeBuilder = new CodeStringBuilder();

        // Act
        var methodBuilder = new MethodBuilder() {
            Name = "BasicMethod"
        };
        methodBuilder.Build(codeBuilder);

        // Assert
        var expectedOutput = TestDataLoader.Load("Builder", "MemberBuilder", "BasicMethod.expected.txt");
        codeBuilder.ToString().Should().Be(expectedOutput);
    }
}