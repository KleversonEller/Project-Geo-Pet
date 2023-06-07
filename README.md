## **Contexto** 
## Projeto Final - Aceleração em .NET C#
<br />

O objetivo é proporcionar um sistema para localização de Pets em tempo real a partir de uma longitude e latitude passada pela coleira do Pet.

<details>
  <summary><strong>As seguintes regras de negócio foram utilizadas para a construção dessa aplicação</strong></summary>
  <br />

    * Na GeoPet, as pessoas cuidadoras devem poder se cadastrar com nome, e-mail (único), CEP (que será validado pela ViaCEP API), senha e informações sobre seus pets: id(uuid), nome, idade, porte, raça, pessoa cuidadora.

    * Além disso, o serviço deve gerar um QR Code com as informações da pessoa cuidadora, caso o pet esteja perdido, passando uma latitude e uma longitude e retorna um endereço utilizando a Nominatin API.

</details>
<br />

## 📑 **Tecnologias utilizadas**
<br />

  * <a href="https://dotnet.microsoft.com/pt-br/apps/aspnet" target="_blank" rel="external"><span><strong>ASP.NET</strong></span></a> - Utilizada na construção da API.

  * <a href="https://jwt.io/" target="_blank" rel="external"><span><strong>JWT</strong></span></a> - Ferramenta de autenticação de dados.

  * <a href="https://www.microsoft.com/pt-br/sql-server/sql-server-downloads" target="_blank" rel="external"><span><strong>SQL Server(SQLite)</strong></span></a> - Banco de Dados.
 
  * <a href="https://viacep.com.br/" target="_blank" rel="external"><span><strong>Via CEP API</strong></span></a> - Api dos correios.

  * <a href="https://nominatim.org/release-docs/develop/" target="_blank" rel="external"><span><strong>Nominatim API</strong></span></a> - Api de Geo localização.

  * <a href="https://fluentassertions.com/" target="_blank" rel="external"><span><strong>FluentAssertions</strong></span></a> - Ferramenta de construção de testes.

  * <a href="https://xunit.net/" target="_blank" rel="external"><span><strong>XUnit</strong></span></a> - Ferramenta de construção de testes.

  * <a href="https://azure.microsoft.com/pt-br/" target="_blank" rel="external"><span><strong>Azure</strong></span></a> - Ferramenta de deploy.

<br />

## ⚙️ **Como iniciar o projeto localmente**
<br />

Caso queira iniciar o projeto localmente devera ter instalado o .NET 6.0 e seguir os seguintes passos:
<br/>
Primeiro clone o projeto:
<br/>

```sh
git clone git@github.com:KleversonEller/Project-Geo-Pet.git
```
<br/>

Em seguida entre na pasta do projeto e utilize o seguinte comando para instalar as dependências do projeto:
<br/>

```sh
cd project-geopet/src/Geo-Pet
dotnet restore
```
<br/>

Para iniciar a API utilize o seguinte comando:
<br/>

```sh
 cd project-geopet/src/Geo-Pet
dotnet run
```

<br/>
Esse comando ira abrir a aplicação em sua documentação.
<br/>

<!-- ## 📝 **Documentação da API**
<br />

Para saber mais, acesse a documentação:
<a href="http://localhost:5143/Swagger/index.html" target="_blank" rel="external"><span><strong>Documentação Swagger</strong></span></a>
<br />

<details>
<summary><strong>Students</strong></summary><br/>

```
  GET /Students 
```
 ```
  GET /Student/:id
```
```
  GET /Student/Name/
```
```
  POST /Student
```
```
  POST /Login 
```
```
  PATCH /Student/:id
```
```
  DELETE/Student/:id
```
</details>
<br /> 

<details>
<summary><strong>Posts</strong></summary>
<br/>

```
  GET /Post
```
```
  GET /Post/:id
```
```
  GET /Post/Student/:id
```
```
  GET /Post/Last/Student/:id
```
```
  GET /Post/StudentName
```
```
  /Post/Last/StudentName
```
```
  POST /Post
```
```
  PUT /Post/:id 
```
```
  DELETE /Post/:id 
```
</details>
<br/>

## 🏗️ **Deploy**
<br/>

O deploy da aplicação foi executado utilizando o Microsoft Azure:
<a href="https://project-tryitter.azurewebsites.net/ " target="_blank" rel="external"><span><strong>Link do deploy</strong></span></a>
<br />
<br />

## 🧑‍💻 Projeto Desenvolvido por:
<br/>

<img src='https://avatars.githubusercontent.com/u/94326866?s=400&u=652728bc4a5ec9965b9bd2e6cb591f6005647c49&v=4' width='100' />|<img src='https://avatars.githubusercontent.com/u/74563015?v=4' width='100' />
:-:|:-:
[Tamiris Shigaki](https://www.linkedin.com/in/tamirisshigaki/)|[João Claudio](https://github.com/joaocla) -->
