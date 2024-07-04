[CmdletBinding()]
param(
    [Parameter(Mandatory=$true, HelpMessage="Enter the subscription key required for API authentication against the Studica APIM. If you do not know your subscription key, please contact Studica support.")]
	[string] $SubscriptionKey
)

Write-Host "Fetching Studica External API OpenAPI specs..."

Write-Host "Downloading Internship.DK API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/internship-dk/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\InternShipDk\swagger.json

Write-Host "Downloading Programmes API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/programmes/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\Programmes\swagger.json

Write-Host "Downloading School Administration API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/school-administration/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\SchoolAdministration\swagger.json

Write-Host "Downloading School Internships API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/school-internships/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\SchoolInternships\swagger.json

Write-Host "Downloading Statistics API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/statistics/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\Statistics\swagger.json

Write-Host "Downloading Students API "
(Invoke-WebRequest -Uri https://api.studica.dk/demo/students/v1/openapi?subscription-key=$SubscriptionKey | ConvertFrom-Json | ConvertTo-Json -Depth 50) *> .\Students\swagger.json
