# 📚 SOLTEC.DocuWiki

**SOLTEC.DocuWiki** es un proyecto en .NET 8 que genera automáticamente documentación en Markdown y HTML con un estilo similar a Wikipedia. Genera contenidos en inglés y español, integra un buscador, permite cambiar entre modo oscuro/claro, y presenta una cabecera profesional con el logotipo de la empresa SOLTEC.

## ✨ Funcionalidades

- ✅ Documentación autogenerada en Markdown y HTML
- 🌐 Contenido bilingüe: Inglés + Español
- 🔍 Buscador integrado
- 🌙 Modo claro y oscuro
- 📌 Cabecera con logotipo de SOLTEC
- 🛠️ Generador CLI a partir de `.cs` y comentarios XML

## 🖼 Ejemplo de Salida

Los archivos generados se guardan en `Docs/en` y `Docs/es`, e incluyen:
- Resumen de la clase o enumerado
- Miembros con comentarios XML
- Enlaces cruzados entre idiomas
- Estilo tipo Wikipedia con identidad de marca

## 🔧 Requisitos

- .NET 8 SDK
- Visual Studio 2022 o Rider

## 📂 Cómo usar

```bash
dotnet run --project SOLTEC.DocuWiki
```

> La documentación generada estará disponible en la carpeta `Docs/`.

---
© SOLTEC — 2025
