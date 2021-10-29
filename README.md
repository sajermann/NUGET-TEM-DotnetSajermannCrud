# Template para CLI Dotnet

## Instalar template: 
dotnet new -i .\

## Iniciar projeto com template criado: 
dotnet new [shortnametemplate] -n "[nomeProjeto]" --conn "[variavelASersubstituida]" --allow-scripts yes

## Criar nupkg

D:\Aplicativos\Portable\Nuget\nuget.exe pack E:\Programação\Github\TemplateDotnetSajermannCrud -OutputDirectory E:\Programação\Github\NPS-NuGetPackageSajermann\Template\VisualStudioSajermannCrud

## TODO

### Arrumar o comando dentro do template.json pra excluir a pasta .git