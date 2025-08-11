using RBlade.CodeBuilder.Builder.TypeBuilder;
using RBlade.CodeBuilder.Utils;

namespace RBlade.CodeBuilder.Builder;

/// <summary>
/// Builder used to create a C# file
/// </summary>
public class CodeFileBuilder {
    /// <summary>
    /// List of all using directives
    /// </summary>
    private readonly List<string> _usingDirectives = [];

    /// <summary>
    /// List of all types
    /// </summary>
    private readonly List<ITypeBuilder> _typeBuilders = [];

    #region Input

    /// <summary>
    /// Adds a using directive to the code file.
    /// </summary>
    /// <param name="directive">Namespace of the using directive</param>
    /// <returns><see cref="CodeFileBuilder"/> with the using directive added</returns>
    public CodeFileBuilder AddUsingDirective(string directive) {
        _usingDirectives.Add(directive);
        return this;
    }

    /// <summary>
    /// Adds a class to the code file.
    /// </summary>
    /// <param name="classBuilder">Builder of the class that should be added</param>
    /// <returns><see cref="CodeFileBuilder"/> with the class added</returns>
    public CodeFileBuilder AddClass(ClassBuilder classBuilder) {
        _typeBuilders.Add(classBuilder);
        return this;
    }

    #endregion

    #region Output

    /// <summary>
    /// Builds the complete code file
    /// </summary>
    /// <returns>String containing the built code file</returns>
    public override string ToString() {
        var builder = new CodeStringBuilder();

        _usingDirectives.ForEach(directive => builder.AppendLine($"using {directive};"));
        if (_usingDirectives.Count > 0) {
            builder.AppendLine();
        }
        
        _typeBuilders.ForEach(type => type.Build(builder));

        return builder.ToString();
    }

    #endregion
}