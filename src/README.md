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




