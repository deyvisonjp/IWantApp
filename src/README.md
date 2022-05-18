# Curso NET 6 Web Api - Udemy 
### Stephany Henrique de Almeida — Instrutor
### Repositório do Projeto: GitGub

## Projeto Exemplo de Vendas - Api Web Rest Net Core 6

## Aula 61 - Criando Domínio de Produto
- Criar o editor config (Botão direito no projeto > Adicionar > Criar novo EditorConfig > Alterar para file namespace)

## Aula 62 - Refatorando o domínio
- Criação de classe abstrta para atributos comuns a mais de uma classe 
	- _Lembrando:_ Classe abstrata não pode ser instancia, somente herdada

## Aula 63 - Instalando pacotes Nuget 
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer

## Aula 64 - Contexto do EF
- Criação da pasta de Infra > Data > ApplicationDbContext

## Aula 67 - Gerando e aplicando Migrations
- Configurar Conncetion String e configurar no Program
- No terminal: 
	- `dotnet ef migrations add CategoryAndProduct`
	- `dotnet ef database update`

# Seção 13 - Validações

## Aula 70 - Flunt para validações
- Instalar Flunt (Baltieri) através do Gerenciador de pacotes Nuget
- Ativaremos as notificações através dos domínios, nas classes
- As notificações precisam ser tratadas de preferencia no construtor da classe e com 'contract'
- Ignore em Notification na classe ApplicationDbContext

# Seção 14 - Identity
- Pacote instalado: 
	- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Adicionar a 'dependência no ApplicationDbContext' e base.OnModelCreating(builder);
- Adicionar o identity como serviço em Program
- Após adicionar o serviço é necessário add também a migration de identificação
- Claims: Usuários/Funções distintas

## Aula 86 - Dapper
- O [Dapper](https://www.brunobrito.net.br/dapper-em-detalhes/) é um micro ORM para .NET. Um mecanismo, simples, que auxilia no mapeamento de objetos a partir de consultas SQL. É uma library de alto desempenho para acesso a dados. Criado pela equipe do StackOverflow. Open Source. A palavra chave do Dapper é performance
- Instalar lib Dapper através do Nuget
- Ex. em EndPoint/EmployeeGetAll

# Seção 15 - JWT e Autenticação
[https://balta.io/blog/aspnet-core-autenticacao-autorizacao](https://balta.io/blog/aspnet-core-autenticacao-autorizacao)
- JWT: É a sigla para Json Web Token e pronuncia-se JOT. O JWT nada mais é que o armazenamento das informações do token no formato JSON.
- Ferramentas: Auth0, okta, keyloak, Identity (Vamos usar Identity)

## Gerando o token
- Instalar a depêndencia: Microsoft.AspNetCore.Authentication.JwtBearer
- Criação de um endpoint para log
- Configurando autenticação e autorização
	1. Configurar appsettings
	2. Add builder.Services.AddAuthorization e builder.Services.AddAuthentication
- Proteções no endpoint
	1. [AllowAnonymous] - Sem bloqueio
	2. [Authorize] - Somente usuários logados podem executar este endpoint


