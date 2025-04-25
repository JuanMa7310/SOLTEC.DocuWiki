#!/bin/bash
cd "$(dirname "$0")"

echo "📦 Building SOLTEC.DocuWiki..."

dotnet build SOLTEC.DocuWiki.csproj -c Release
if [ $? -ne 0 ]; then
  echo "❌ Build failed. Aborting."
  exit 1
fi

echo "🚀 Running DocuWiki Generator..."
dotnet run --project SOLTEC.DocuWiki.csproj --configuration Release
