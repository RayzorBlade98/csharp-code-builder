using RBlade.CodeBuilder.Builder.MemberBuilder;
using RBlade.CodeBuilder.Model;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Builder.TypeBuilder;

/// <summary>
/// Builder used to create a C# class
/// </summary>
public class ClassBuilder : ITypeBuilder {
    #region Properties

    /// <summary>
    /// Access modifier of the class
    /// </summary>
    public AccessModifier AccessModifier { get; set; } = AccessModifier.Public;

    /// <summary>
    /// Name of the class
    /// </summary>
    public required string Name { get; set; }

    #endregion

    #region Fields

    /// <summary>
    /// List of all methods
    /// </summary>
    private readonly List<MethodBuilder> _methods = [];

    #endregion

    /// <summary>
    /// Adds a method the class
    /// </summary>
    /// <param name="methodBuilder">Builder of the method that should be added</param>
    /// <returns><see cref="ClassBuilder"/> with the method added</returns>
    public ClassBuilder AddMethod(MethodBuilder methodBuilder) {
        _methods.Add(methodBuilder);
        return this;
    }

    /// <inheritdoc />
    public CodeStringBuilder Build(CodeStringBuilder builder) {
        builder.AppendLine($"{AccessModifier.ToCodeString()} class {Name} {{")
               .AddIndentation();

        _methods.ForEach(method => { method.Build(builder); });

        return builder
               .RemoveIndentation()
               .AppendLine("}");
    }
}