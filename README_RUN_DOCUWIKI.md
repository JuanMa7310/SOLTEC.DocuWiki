# Script Instructions - SOLTEC.DocuWiki

This folder includes two scripts to **build and run** the HTML documentation generator `SOLTEC.DocuWiki`.

They are designed to run **from any location**.

## 🚀 Windows

Run this script:
```
run-docuwiki.bat
```

It will:
1. Navigate to the script folder
2. Build the project using `dotnet build`
3. Run the documentation generator with `dotnet run`

## 🐧 Linux/macOS

Make it executable:
```bash
chmod +x run-docuwiki.sh
```

Then run:
```bash
./run-docuwiki.sh
```

> The tool will generate HTML documentation based on your source `.cs` files and their XML comments.
