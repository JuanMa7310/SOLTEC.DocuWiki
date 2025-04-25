namespace SOLTEC.DocuWiki.Models;

/// <summary>
/// Represents a documented class extracted from the XML documentation.
/// </summary>
/// <example>
/// Example usage:
/// <![CDATA[
/// var doc = new DocClass
/// {
///     Name = "MyNamespace.MyClass",
///     Summary = "Provides operations for XYZ",
///     Properties = new List<DocMember>(),
///     Methods = new List<DocMember>()
/// };
/// ]]>
/// </example>
public class DocClass
{
    /// <summary>
    /// Gets or sets the full name of the class including its namespace.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the summary documentation for the class.
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the list of documented properties.
    /// </summary>
    public List<DocMember> Properties { get; set; } = new();

    /// <summary>
    /// Gets or sets the list of documented methods.
    /// </summary>
    public List<DocMember> Methods { get; set; } = new();
}