# AtelierJaneCunha

O projeto AtelierJaneCunha é totalmente feito com .NET 5.0, utilizando ASP.NET Core MVC.
O meu é objetivo é criar um sistema escalável, bem-escrito e com uma pipeline de deploy com Docker integrado com o Azure.
Esse projeto será desenvolvido para o Atelier Jane Cunha servindo como um site de apresentação, e futuramente uma ferramenta gerencial.

__Esse sistema está em desenvolvimento__

## Tecnologias implementadas
* .NET 5.0
* ASP.NET Core MVC 5.0
* Docker
* Pipeline CI e CD com GitHub Actions
* Cloud com Azure AppService

## O que esse sistema fará?
* Site de apresentação da empresa e do catálogo
* Dashboard com autenticação para:
  * Controle de conteúdo e imagens para o site de apresentação (CMS)
  * Controle de catálogo e estoque
  * Controle de vendas e pedidos
  * Controle de clientes
 
 ## Quais tecnologias eu usarei?
 * Banco de Dados SQL Server
 * EF Core 5.0 para a comunicação com o BD
 * Angular 12 como Front-end para o Dashboard
 * ASP.NET Core WebAPI 5.0 com JWT para a comunicação com o FrontEnd e o BD
 * ASP.NET Core MVC 5.0 para o site de apresentaçao com o conteúdo dinâmico
 
 ## Que abordagens de desenvolvimento e arquitetura eu seguirei?
 * Onion Architecture
 * Seguirei conceitos de Clean Code e SOLID
 * Repository pattern
 * Unit of Work
 * Domínios Ricos
 * DI nativo do .NET 
 * Testes unitários e de integrações
 * Deploy automatizado com Docker, GitHub Actions e Azure AppService
 
 ## Sobre
 Esse projeto foi desenvolvido pelo Vinicius Cunha, com o objetivo de entregar um produto de qualidade e bem organizado
