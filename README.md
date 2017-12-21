# Projeto - Cedrotech

Serviços Back-End de um sistema para restaurantes e pratos, no qual vários restaurantes podem ser cadastrados e conter vários pratos.

## Getting Started

**Windows**<br />
Faça o download do projeto e abra o arquivo "projetoWebApi.sln" com o Visual Studio, tenha instalado na sua maquina o programa Postman.

**Executando o projeto no Visual Studio ( F5 ou Alt + F5) :**<br />
Ao executar o projeto, o ISS Express da própria ferramenta ira abrir no seu browser padrão a pagina da aplicação, a seguir as URLs da WebAPI:

**Restaurantes registrados no sistema**<br />
http://localhost:porta/api/restaurantes

**Pratos registrados no sistema**<br />
http://localhost:porta/api/pratos

**Adicionar  um Restaurante no sistema ( json )**<br />
http://localhost:porta/api/postrestaurantes

**Adicionar um Prato no sistema ( json )**<br />
http://localhost:porta/api/postpratos/{id} 
Obs: Id do Restaurante do qual o prato pertence

**Alterar um Restaurante no sistema ( json )**<br />
http://localhost:porta/api/putrestaurantes/{id}
Obs: Id do Restaurante.

**Alterar um Prato no sistema ( json )**<br />
http://localhost:porta/api/putpratos/{id}
Obs: Id do Prato.

**Deletar um Restaurante no sistema**<br />
http://localhost:porta/api/deleterestaurantes/{id}
Obs: Id do Restaurante.

**Deletar um Prato no sistema**<br />
http://localhost:porta/api/deletepratos/{id}
Obs: Id do Prato.

## Testando:
Com o sistema executando, abra o programa Postman, e utilize as URLs dadas para criar, deletar e fazer update dos dados.<br />
**CRUD.

## Pre requisitos:
*  Postman <br /> 
*  Visual Studio Community/Enterprise/Profissional/Code<br />
*  .NET <br />
*  Asp.NET Core 2.0 <br />
*  Entity Framework <br />

## Desenvolvido com:
*  Visual Studio Community 2017 <br /> 
*  C# <br />
*  Asp.NET Core MVC 2.0 <br />
*  Entity Framework Code First - Migrations <br />

## Autor
* **Miguel Henrique de Brito Pereira** - [GitHub](https://github.com/miguelhbrito)

