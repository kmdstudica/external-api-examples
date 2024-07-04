$ErrorActionPreference = "Stop"

Push-Location

$folders = (Get-ChildItem $path -Directory -Recurse | Where-Object { Test-Path  "$_\generate.ps1" -PathType Leaf })
Write-Host "Found the following client folders: $($folders | Join-String -Property BaseName -Separator ', ')"

foreach ($folder in $folders) {
    Write-Host "Generating client for $($folder.BaseName)..."
    Set-Location -Path $folder.FullName
    & ".\generate.ps1"
	Write-Host " -----------------------------"
	Write-Host " Done!"
	Write-Host " "
}

Pop-Location