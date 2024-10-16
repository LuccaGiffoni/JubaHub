# JubaHub - Gestão Inteligente para Cantinas

![JubaHub](https://img.shields.io/badge/Status-In%20Development-brightgreen)
&nbsp
## Sobre o Projeto

**JubaHub** é uma aplicação backoffice inovadora, desenvolvida para simplificar a gestão de cantinas e lanchonetes. Criado por um grupo de estudantes, o **JubaHub** oferece uma plataforma prática para gerenciar clientes, eventos e o fluxo de caixa. A aplicação utiliza tecnologia moderna com uma arquitetura escalável baseada no padrão Onion, oferecendo flexibilidade e segurança para crescer com o seu negócio.

<br>

## Funcionalidades Principais

- **Gestão de Clientes**: Cadastre e organize seus clientes, mantendo um histórico completo de compras e preferências.
- **Gestão de Eventos**: Crie e acompanhe eventos e promoções dentro da sua cantina ou lanchonete.
- **Controle de Caixa**: Visualize o fluxo de caixa em tempo real, com relatórios detalhados de receitas e despesas.
  
<br>

## Tecnologias Utilizadas

- **C#**: Linguagem principal para o desenvolvimento da aplicação.
- **ASP.NET Core**: Usado para a criação da API com minimal APIs.
- **Entity Framework Core**: ORM para gestão de dados, integrado com **MySQL**.
- **Blazor WebAssembly**: Framework para o desenvolvimento da interface web (front-end).
- **Onion Architecture**: Arquitetura modular e escalável, facilitando a manutenção e evolução do projeto.
  
<br>

## Estrutura do Projeto

A solução **JubaHub** segue uma arquitetura em camadas (Onion), separando a lógica da aplicação em módulos independentes:

- **JubaHub.Domain**: Contém as entidades e regras de negócio.
- **JubaHub.Core**: Lógica central e serviços da aplicação.
- **JubaHub.Infra**: Interação com banco de dados, via Entity Framework Core.
- **JubaHub.Api**: Implementação da API com ASP.NET Core.
- **JubaHub.Web**: Interface de usuário desenvolvida com Blazor WebAssembly.
  
<br>

## Requisitos de Instalação

Para rodar o **JubaHub**, você precisará dos seguintes itens instalados no seu ambiente:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/)
- Visual Studio 2022 ou Visual Studio Code
  
<br>

### Como Clonar o Repositório

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/jubahub.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd jubahub
   ```
3. Restaure as dependências:
   ```bash
   dotnet restore
   ```
  
<br>

### Como Executar
Configure o banco de dados MySQL, adicionando as informações de conexão em appsettings.json do projeto JubaHub.Api:

   ```bash
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=jubahub;User=root;Password=sua_senha;"
     }
   }
   ```
Execute as migrações para configurar o banco de dados:

   ```bash
   dotnet ef database update --project JubaHub.Infra
   ```
Execute a aplicação:

   ```bash
   dotnet run --project JubaHub.Api
   ```

Abra o navegador e acesse a interface do Blazor em [http://localhost:5000](http://localhost:5000)
  
<br>

## Roadmap
Aqui estão as principais funcionalidades que estamos planejando adicionar no futuro:

- Implementação de autenticação e autorização para usuários e funcionários.
- Integração com APIs de pagamento para gerenciamento completo do caixa.
- Suporte para múltiplos idiomas.
