# Instrucciones para los Scripts - SOLTEC.DocuWiki

Esta carpeta incluye dos scripts para **compilar y ejecutar** el generador de documentación HTML `SOLTEC.DocuWiki`.

Están diseñados para funcionar **desde cualquier ubicación**.

## 🚀 Windows

Ejecuta este script:
```
run-docuwiki.bat
```

Este script:
1. Cambia al directorio donde está el script
2. Compila el proyecto usando `dotnet build`
3. Ejecuta el generador con `dotnet run`

## 🐧 Linux/macOS

Haz que sea ejecutable:
```bash
chmod +x run-docuwiki.sh
```

Luego ejecútalo:
```bash
./run-docuwiki.sh
```

> La herramienta generará documentación HTML basada en los archivos `.cs` y sus comentarios XML.
