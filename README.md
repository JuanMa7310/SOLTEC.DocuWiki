# 📚 SOLTEC.DocuWiki

**SOLTEC.DocuWiki** is a .NET 8 project that automatically generates Markdown and HTML documentation styled like Wikipedia. It features bilingual output (English and Spanish), a search bar, dark/light mode support, and a professional header with the SOLTEC company logo.

## ✨ Features

- ✅ Auto-generated documentation in Markdown and HTML
- 🌐 Bilingual content: English + Spanish
- 🔍 Integrated search engine
- 🌙 Theme switcher: Light and Dark mode
- 📌 Headers with SOLTEC logo and name
- 🛠️ CLI generator based on `.cs` files and XML documentation

## 🖼 Output Sample

Pages are generated in `Docs/en` and `Docs/es`. Each file includes:
- Class or enum summary
- Members and XML comments
- Links between languages
- Wikipedia-like layout with branding

## 🔧 Requirements

- .NET 8 SDK
- Visual Studio 2022 or Rider

## 📂 How to Use

```bash
dotnet run --project SOLTEC.DocuWiki
```

> The generated documentation will be available in the `Docs/` folder.

---
© SOLTEC — 2025
