using System.Text;

namespace RBlade.CodeBuilder.Utils;

/// <summary>
/// Wrapper around the <see cref="StringBuilder"/> class that provides additional functionality for building C# code strings
/// </summary>
public class CodeStringBuilder {
    /// <summary>
    /// String builder that is used to build the code string
    /// </summary>
    private readonly StringBuilder _builder = new();

    #region Append

    /// <summary>
    /// Appends a copy of the specified string to this instance.
    /// </summary>
    /// <param name="value">The string to append</param>
    /// <returns>A reference to this instance after the append operation has completed</returns>
    public CodeStringBuilder Append(string value) {
        _builder.Append(value);
        return this;
    }

    /// <summary>
    /// Appends a copy of the specified string followed by the default line terminator to the end of the current <see cref="CodeStringBuilder"/> object
    /// </summary>
    /// <param name="value">The string to append</param>
    /// <returns>A reference to this instance after the append operation has completed</returns>
    public CodeStringBuilder AppendLine(string value) {
        _builder.AppendLine(value);
        return this;
    }

    #endregion

    /// <summary>
    /// Converts the value of this instance to a <see cref="string"/>
    /// </summary>
    /// <returns>A string whose value is the same as this instance</returns>
    public override string ToString() {
        return _builder.ToString();
    }
}