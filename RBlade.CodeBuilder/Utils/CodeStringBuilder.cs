using System.Text;

namespace RBlade.CodeBuilder.Utils;

/// <summary>
/// Wrapper around the <see cref="StringBuilder"/> class that provides additional functionality for building C# code strings
/// </summary>
public class CodeStringBuilder {
    /// <summary>
    /// String representation of the current indentation depth
    /// </summary>
    private string Indentations => string.Concat(Enumerable.Repeat("\t", _indentationDepth));
    
    /// <summary>
    /// String builder that is used to build the code string
    /// </summary>
    private readonly StringBuilder _builder = new();

    /// <summary>
    /// Current indentation depth
    /// </summary>
    private int _indentationDepth = 0;

    #region Append

    /// <summary>
    /// Appends a copy of the specified string to this instance.
    /// </summary>
    /// <param name="value">The string to append</param>
    /// <returns>A reference to this instance after the append operation has completed</returns>
    public CodeStringBuilder Append(string value) {
        _builder.Append(Indentations)
                .Append(value);
        return this;
    }

    /// <summary>
    /// Appends a copy of the specified string followed by the default line terminator to the end of the current <see cref="CodeStringBuilder"/> object
    /// </summary>
    /// <param name="value">Optional string to append. If <c>null</c>, only the line terminator will be added</param>
    /// <returns>A reference to this instance after the append operation has completed</returns>
    public CodeStringBuilder AppendLine(string? value = null) {
        _builder.Append(Indentations)
                .AppendLine(value);
        return this;
    }

    #endregion

    #region Indentation

    /// <summary>
    /// Adds an indentation depth. All following appendages will be indented one depth more. 
    /// </summary>
    /// <returns>A reference to this instance after the indentation operation has completed</returns>
    public CodeStringBuilder AddIndentation() {
        _indentationDepth++;
        return this;
    }

    /// <summary>
    /// Removes an indentation depth. All following appendages will be indented one depth less. 
    /// </summary>
    /// <returns>A reference to this instance after the indentation operation has completed</returns>
    /// <exception cref="InvalidOperationException">Thrown when the indentation depth is already zero</exception>
    public CodeStringBuilder RemoveIndentation() {
        if (_indentationDepth <= 0) {
            throw new InvalidOperationException("Cannot remove indentation when the depth is already zero");
        }

        _indentationDepth--;
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