namespace RBlade.CodeBuilder.Model;

/// <summary>
/// C# access modifiers for types and members
/// </summary>
public enum AccessModifier {
    /// <summary>
    /// File-scoped access modifier
    /// </summary>
    File,

    /// <summary>
    /// Internal access modifier
    /// </summary>
    Internal,

    /// <summary>
    /// Public access modifier
    /// </summary>
    Public,

    /// <summary>
    /// Private access modifier
    /// </summary>
    Private,

    /// <summary>
    /// Private protected access modifier
    /// </summary>
    PrivateProtected,

    /// <summary>
    /// Protected access modifier
    /// </summary>
    Protected,

    /// <summary>
    /// Protected internal access modifier
    /// </summary>
    ProtectedInternal,
}

/// <summary>
/// Extensions for <see cref="AccessModifier"/>
/// </summary>
internal static class AccessModifierExtensions {
    /// <summary>
    /// Converts the <see cref="accessModifier"/> to its C# representation
    /// </summary>
    /// <param name="accessModifier"><see cref="AccessModifier"/> that should be converted</param>
    /// <returns>C# representation of the given <see cref="accessModifier"/></returns>
    public static string ToCodeString(this AccessModifier accessModifier) {
        return accessModifier switch {
            AccessModifier.File => "file",
            AccessModifier.Internal => "internal",
            AccessModifier.Public => "public",
            AccessModifier.Private => "private",
            AccessModifier.PrivateProtected => "private protected",
            AccessModifier.Protected => "protected",
            AccessModifier.ProtectedInternal => "protected internal",
            _ => throw new ArgumentOutOfRangeException(nameof(accessModifier), accessModifier, null)
        };
    }
}