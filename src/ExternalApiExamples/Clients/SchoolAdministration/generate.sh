# curl -O http://localhost:5002/swagger/external/swagger.json
autorest --input-file=swagger.json --output-folder=. --namespace=Kmd.Studica.SchoolAdministration.Client --csharp --add-credentials --payload-flattening-threshold=2
