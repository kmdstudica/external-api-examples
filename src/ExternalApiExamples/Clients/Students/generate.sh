# curl -O http://localhost:5018/swagger/external/swagger.json
autorest --input-file=swagger.json --output-folder=. --namespace=Kmd.Studica.Students.Client --csharp --add-credentials --payload-flattening-threshold=2
