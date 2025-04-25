@echo off
setlocal
cd /d %~dp0

echo 📦 Building SOLTEC.DocuWiki...

dotnet build SOLTEC.DocuWiki.csproj -c Release
if %errorlevel% neq 0 (
    echo ❌ Build failed. Aborting.
    exit /b 1
)

echo 🚀 Running DocuWiki Generator...
dotnet run --project SOLTEC.DocuWiki.csproj --configuration Release

endlocal
pause
