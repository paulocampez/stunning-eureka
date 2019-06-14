# ASP.NET Core 2.2 WebApi Exemplo com Swagger

Neste respoitório demonstro uma maneira simples de construir um WebAPI com o ASP.NET Core e consumir através de um projeto MVC.

Este repositório contém uma controller ```Funcionario``` onde contém a chamada de ações na API como GET/POST/PUT/PATCH e DELETE

Veja aqui alguns exemplos: 

# Ambiente
API
```https://ledacards20190524012526.azurewebsites.net/```

MVC
```https://stunningmvc20190613055432.azurewebsites.net/```

## Swagger

``` http://localhost:59279/index.html ```

![ASPNETCOREWebAPIVersions](./github/swagger.png)

```http://localhost:59279/api/Home/```

![ASPNETCOREWebAPIVersions](./github/getfuncionarios.png)

## Projeto Strategy

Padrão de Projeto Strategy, criado uma Strategy para cada variante e fazer com que o método delegue o algoritmo para uma instância de Strategy

![ASPNETCOREWebAPIVersions](./github/Strategy.png)

## Pacotes
Para buildar o projeto serão necessários os seguintes pacotes:
- Microsoft.AspNetCore.App
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.Extensions.PlatformAbstractions
- Newtonsoft.Json
- Swashbuckle.AspNetCore

Podem ser instalados pelo seguinte comando nuget:

``` 
Install-Package Microsoft.AspNetCore.App -Version 2.2.0
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 2.2.4
Install-Package Microsoft.Extensions.PlatformAbstractions -Version 1.1.0
Install-Package Newtonsoft.Json -Version 12.0.2
Install-Package Swashbuckle.AspNetCore -Version 4.0.1
```

## Projeto MVC

![ASPNETCOREWebAPIVersions](./github/padraomvc.png)

- Tela de consulta com filtros
```https://localhost:44376/Funcionario```
![ASPNETCOREWebAPIVersions](./github/projeto-mvc1.png)

- Tela de consulta com filtro direto no API
```https://localhost:44376/Funcionario/BuscaNome```
![ASPNETCOREWebAPIVersions](./github/projeto-mvc2.png)

## Como Testar
- Para testar a aplicação MVC é necessário rodar o WebAPI para realizar as consultas.
- Configurar connection strings com o string de conexão do banco. 
ex ``` "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=Stunning;Trusted_Connection=True;MultipleActiveResultSets=true" ```
no caminho ```\Stunnig.API\Stunnig.API\appsettings.json```
- Update Database (Entity Framework)
``` 
update-database
```
- Adicionar caminho do XML nas configurações do projeto Stunnig.API
![ASPNETCOREWebAPIVersions](./github/xml.png)
