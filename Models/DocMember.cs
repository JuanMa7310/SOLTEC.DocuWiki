namespace SOLTEC.DocuWiki.Models;

/// <summary>
/// Represents a documented member (method or property) of a class.
/// </summary>
/// <example>
/// Example usage:
/// <![CDATA[
/// var method = new DocMember
/// {
///     Name = "GetData()",
///     Summary = "Returns the data associated with the object.",
///     Parameters = "- id: The ID to search for.",
///     Example = "var result = obj.GetData();"
/// };
/// ]]>
/// </example>
public class DocMember
{
    /// <summary>
    /// Gets or sets the name of the method or property.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the summary documentation for the member.
    /// </summary>
    public string Summary { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the formatted list of parameters with their descriptions.
    /// </summary>
    public string? Parameters { get; set; }

    /// <summary>
    /// Gets or sets the example usage of the member, if any.
    /// </summary>
    public string? Example { get; set; }
}