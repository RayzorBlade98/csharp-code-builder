using RBlade.CodeBuilder.Model;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Builder.MemberBuilder;

/// <summary>
/// Builder used to create a C# method
/// </summary>
public class MethodBuilder {
    /// <summary>
    /// Access modifier of the method
    /// </summary>
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;

    /// <summary>
    /// Name of the method
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Return type of the method
    /// </summary>
    public string ReturnType { get; set; } = BuiltInTypes.Void;

    /// <summary>
    /// Builds the method by writing directly into the given <see cref="CodeStringBuilder"/> <see cref="builder"/>
    /// </summary>
    /// <param name="builder"><see cref="CodeStringBuilder"/> to which the method should be written</param>
    /// <returns><see cref="CodeStringBuilder"/> <see cref="builder"/> that was written to</returns>
    public CodeStringBuilder Build(CodeStringBuilder builder) {
        return builder
               .AppendLine($"{AccessModifier.ToCodeString()} {ReturnType} {Name}() {{")
               .AppendLine("}");
    }
}