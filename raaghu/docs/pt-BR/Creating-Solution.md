# criando uma nova ⁇  comercial de amplificador
Há duas formas de ⁇  uma nova ⁇  comercial BP. Você pode usar o[BP LI](https://docs.abp.io/en/abp/latest/CLI "")ou[ABP Suite.](https://docs.abp.io/en/commercial/7.2/abp-suite/add-solution "")
## criação de ⁇  através de cli amplificador
Se você ainda não instalou o BP LI, você precisa instalá-lo com o seguinte comando. Para ⁇  se você já o tem, ⁇ va amplificador para a linha de comando.

       dotnet tool install -g Volo.Abp.Cli

Para ⁇  sua ⁇ , vá para o ⁇  onde você deseja ⁇  e digite o seguinte comando:

        abp new Acme.BookStore -t app-pro


- 
    
    Came.Bookstore é o nome do projeto. Seu Visual Studio Solution, arquivo .son será ⁇  como Came.Bookstore.son. Os projetos dentro da pasta raiz e todos os namespaces ⁇  o prefixo Came.Bookstore.*. Você pode dar nomes de projetos diferentes como apenasBookStore ou Came.Retail.Bookstore. Você pode usar um nome de nível único, dois níveis ou três níveis.

- 
    
    -t ou --template é o nome do modelo. Para aplicações comerciais, use app-pro.

- 
    
    Para ⁇  outras ⁇  de projeto LI novo tipo:
    
    <pre>`  dotnet tool update -g Volo.Abp.Cli
`    </pre>


### ⁇  do quadro ui
O modelo ⁇  múltiplos UI frameworks:

- mvc: SP.ET Core VC I com Páginas Razor (default)
- blazon: Blazor UI
- blazon-servidor: Blazor Server UI
- angular: I angular
- reagem:React I
- Mai-blazon: MAUI Blazor I

Use -u ou --ui ⁇  para especificar o quadro UI:

        abp new Acme.BookStore -t app-pro -u react

Especifique o provedor de banco de dados

O modelo ⁇  os seguintes provedores de banco de dados:

- ef: Entity Framework Core (predefinição)
- mongodb: MongoDB

Use -d ou --database-provider ⁇  para especificar o provedor de banco de dados:

     abp new Acme.BookStore -t app-pro -d mongodb

### criação de ⁇  através de amp Suite
O BP Suite permite que você crie uma nova ⁇  BP.

Se você não tiver ⁇  o BP Suite, ⁇  como instalar o BP Suite.

Para ⁇  uma nova ⁇ , veja[como ⁇  uma nova ⁇ .](https://docs.abp.io/en/commercial/7.2/abp-suite/create-solution "")
### o que se segue?

- [Estrutura de ⁇](Solution-Structure.md "")

