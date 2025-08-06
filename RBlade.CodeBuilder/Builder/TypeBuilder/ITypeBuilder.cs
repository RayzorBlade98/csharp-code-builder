using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Builder.TypeBuilder;

/// <summary>
/// Interface for code builders that create C# types
/// </summary>
internal interface ITypeBuilder {
    /// <summary>
    /// Builds the type by writing directly into the given <see cref="CodeStringBuilder"/> <see cref="builder"/>
    /// </summary>
    /// <param name="builder"><see cref="CodeStringBuilder"/> to which the type should be written</param>
    /// <returns><see cref="CodeStringBuilder"/> <see cref="builder"/> that was written to</returns>
    public CodeStringBuilder Build(CodeStringBuilder builder);
}