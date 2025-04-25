using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Text;

namespace SOLTEC.DocuWiki.Geenerators;

/// <summary>
/// Generates HTML documentation from C# source files with XML comments.
/// </summary>
public static class HtmlDocGenerator
{
    /// <summary>
    /// Generates HTML documentation files from the specified source directory.
    /// </summary>
    /// <param name="sourceDir">Directory containing .cs files.</param>
    /// <param name="outputDir">Directory where HTML files will be saved.</param>
    public static async Task GenerateDocumentationAsync(string sourceDir, string outputDir)
    {
        Directory.CreateDirectory(outputDir);

        foreach (var file in Directory.GetFiles(sourceDir, "*.cs", SearchOption.AllDirectories))
        {
            var _code = await File.ReadAllTextAsync(file);
            var _tree = CSharpSyntaxTree.ParseText(_code);
            var _root = await _tree.GetRootAsync();

            var _classDeclarations = _root.DescendantNodes()
                .OfType<ClassDeclarationSyntax>()
                .Where(c => c.Modifiers.Any(SyntaxKind.PublicKeyword));

            foreach (var _classDecl in _classDeclarations)
            {
                var _className = _classDecl.Identifier.Text;
                var _docComment = ExtractXmlDoc(_classDecl) ?? "No documentation available.";
                var _html = new StringBuilder();

                _html.AppendLine("<!DOCTYPE html><html lang='en'><head>");
                _html.AppendLine("<meta charset='UTF-8'><title>" + _className + "</title>");
                _html.AppendLine("<link rel='stylesheet' href='style.css'>");
                _html.AppendLine("</head><body>");
                _html.AppendLine("<header><img src='images/logo.png' alt='SOLTEC Logo'><span class='company'>SOLTEC</span></header>");
                _html.AppendLine($"<h1>{_className}</h1><p>{_docComment}</p>");
                _html.AppendLine("<h2>Public Members</h2><ul>");

                foreach (var _member in _classDecl.Members.Where(m => m.Modifiers.Any(SyntaxKind.PublicKeyword)))
                {
                    string _signature = _member switch
                    {
                        MethodDeclarationSyntax mds => mds.Identifier.Text + mds.ParameterList.ToString(),
                        PropertyDeclarationSyntax pds => pds.Identifier.Text,
                        ConstructorDeclarationSyntax cds => cds.Identifier.Text + cds.ParameterList.ToString(),
                        _ => _member.ToString()
                    };

                    var _memberDoc = ExtractXmlDoc(_member) ?? "No description.";
                    _html.AppendLine($"<li><strong>{_signature}</strong>: {_memberDoc}</li>");
                }

                _html.AppendLine("</ul></body></html>");

                var _outputPath = Path.Combine(outputDir, $"{_className}.html");
                await File.WriteAllTextAsync(_outputPath, _html.ToString());
            }
        }
    }

    /// <summary>
    /// Extracts XML summary from a syntax node.
    /// </summary>
    private static string? ExtractXmlDoc(SyntaxNode node)
    {
        var _trivia = node.GetLeadingTrivia()
            .FirstOrDefault(t => t.IsKind(SyntaxKind.SingleLineDocumentationCommentTrivia));
        if (_trivia == default) return null;

        return string.Join(" ",
            _trivia.ToFullString()
                  .Replace("///", "")
                  .Split('\n')
                  .Select(line => line.Trim())
                  .Where(line => !string.IsNullOrWhiteSpace(line)));
    }
}