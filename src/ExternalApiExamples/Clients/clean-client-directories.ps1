Get-ChildItem .\ -Directory | foreach ($_) {Remove-Item -Recurse -Exclude "swagger.json","generate.ps1" -Include * -Path $_.FullName}
