using FluentAssertions;
using RBlade.CodeBuilder.Builder.MemberBuilder;
using RBlade.CodeBuilder.Builder.TypeBuilder;
using RBlade.CodeBuilder.Tests.TestUtils;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Tests.Builder.TypeBuilder;

public class ClassBuilderTest {
    [Test]
    public void BasicClass_ShouldBeCreatedCorrectly() {
        // Arrange
        var codeBuilder = new CodeStringBuilder();

        // Act
        var classBuilder = new ClassBuilder {
            Name = "BasicClass"
        };
        classBuilder.AddMethod(new MethodBuilder { Name = "Method1" })
                    .AddMethod(new MethodBuilder { Name = "Method2" })
                    .Build(codeBuilder);

        // Assert
        var expectedOutput = TestDataLoader.Load("Builder", "TypeBuilder", "BasicClass.expected.txt");
        codeBuilder.ToString().Should().Be(expectedOutput);
    }
}