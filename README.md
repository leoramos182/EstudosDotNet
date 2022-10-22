# Estudos Dot Net Core 6

## Relembrando POO
* Abstração
* Polimorfismo
* Encapsulamento
* Herança

## Estudos sobre Token JWT e Autenticação
* Criação do serviço para geração do token
* Para Autenticar o usuário, chama o serviço do token na Task Authorize
* Para Autorizar usuários, usar [Authorize(Policy,Roles)] nas Tasks da controller

## Estudos sobre injeção de dependencia
* Adicionado o serviço de DataContext no Program.cs com Services.AddDbContext() e AddScoped<DataContext, Datacontext>()
