# ================================
# Deploy Debug build στο Linux server
# ================================

# Publish σε Debug για Linux
dotnet publish -c Debug -r linux-x64 -o ./publish-debug

# Ανέβασμα στον server (Debug instance, π.χ. /myvbapi-debug)
rsync -avz --delete -e "ssh -p 2332" ./publish-debug/ gmlogin@100.66.6.42:/var/www/clients/client5/web22/web/myvbapi-debug/

Write-Host "✅ Debug build ανέβηκε στον server στο /myvbapi-debug"
