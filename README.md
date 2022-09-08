# Calculator

Calculator est un projet entraînant les compténces suivantes:

* Mettre à jour une architecture en patant d'un diagramme de classe.
* Utiliser des classes et méthodes statiques.
* Coder en suivant les principes du TDD.
* Expérimenter un *Fork*.

## Prérequis

Ce projet a été validé et testé avec l'environnement suivant:

* OS - Windows 11
* IDE - Microsoft Visual Studio Enterprise 2022 (64-bit) - Version 17.1.5

Le projet nécessite les dépendences suivantes (csproj):

* Target Framework : net6.0
* Test 


## Installation

Ce projet a été réalisé sur l'environnement suivant:

* TIDE - Microsoft Visual Studio Enterprise 2022 (64-bit) - Version 17.1.5
* .Net Framework 6.0
* Test Framework Nunit X.X

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>

    <IsPackable>false</IsPackable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.9.4" />
    <PackageReference Include="NUnit" Version="3.13.1" />
    <PackageReference Include="NUnit3TestAdapter" Version="3.17.0" />
    <PackageReference Include="coverlet.collector" Version="3.0.2" />
  </ItemGroup>

  <ItemGroup>
    <ProjectReference Include="..\MathsLib\MathsLib.csproj" />
  </ItemGroup>

## Usage

```python
import foobar

# returns 'words'
foobar.pluralize('word')

# returns 'geese'
foobar.pluralize('goose')

# returns 'phenomenon'
foobar.singularize('phenomena')
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)