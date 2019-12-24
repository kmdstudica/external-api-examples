#curl -O http://localhost:5004/swagger/external/swagger.json
autorest --input-file=swagger.json --output-folder=. --namespace=Kmd.Studica.Programmes.Client --csharp --add-credentials --payload-flattening-threshold=2
