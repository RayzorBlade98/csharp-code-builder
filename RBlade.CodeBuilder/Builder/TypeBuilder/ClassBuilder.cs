using RBlade.CodeBuilder.Model;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Builder.TypeBuilder;

/// <summary>
/// Builder used to create a C# class
/// </summary>
public class ClassBuilder : ITypeBuilder {
    /// <summary>
    /// Access modifier of the class
    /// </summary>
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;

    /// <summary>
    /// Name of the class
    /// </summary>
    public required string Name { get; set; }

    /// <inheritdoc />
    public CodeStringBuilder Build(CodeStringBuilder builder) {
        builder.AppendLine($"{AccessModifier.ToCodeString()} class {Name} {{");
        builder.Append("}");

        return builder;
    }
}