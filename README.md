# \# API REST de Localizações

# 

# API REST desenvolvida com ASP.NET Core 9 para gerenciamento de locais turísticos, permitindo cadastro, consulta, atualização, remoção e busca de localizações com filtros e paginação.

# 

# \## Tecnologias Utilizadas

# 

# \* ASP.NET Core 9

# \* Entity Framework Core

# \* PostgreSQL

# \* Docker

# \* Docker Compose

# \* Swagger / OpenAPI

# \* C#

# 

# \## Funcionalidades

# 

# \* Cadastro de localizações

# \* Consulta de todas as localizações

# \* Atualização de registros

# \* Remoção de registros

# \* Busca por nome

# \* Busca por categoria

# \* Combinação de filtros

# \* Paginação de resultados

# \* Seed automático de dados para testes

# \* Documentação interativa com Swagger

# \* Execução via Docker

# 

# \## Estrutura da Entidade

# 

# ```json

# {

# &#x20; "id": 1,

# &#x20; "nome": "Cristo Redentor",

# &#x20; "categoria": "Turismo",

# &#x20; "latitude": -22.9519,

# &#x20; "longitude": -43.2105

# }

# ```

# 

# \## Endpoints

# 

# \### Listar Localizações

# 

# ```http

# GET /locations

# ```

# 

# \### Buscar por Nome

# 

# ```http

# GET /locations?nome=cristo

# ```

# 

# \### Buscar por Categoria

# 

# ```http

# GET /locations?categoria=Turismo

# ```

# 

# \### Combinar Filtros

# 

# ```http

# GET /locations?categoria=Turismo\&nome=cristo

# ```

# 

# \### Paginação

# 

# ```http

# GET /locations?page=1\&pageSize=5

# ```

# 

# \### Criar Localização

# 

# ```http

# POST /locations

# Content-Type: application/json

# ```

# 

# Exemplo:

# 

# ```json

# {

# &#x20; "nome": "Parque Lage",

# &#x20; "categoria": "Turismo",

# &#x20; "latitude": -22.9606,

# &#x20; "longitude": -43.2118

# }

# ```

# 

# \### Atualizar Localização

# 

# ```http

# PUT /locations/{id}

# ```

# 

# \### Remover Localização

# 

# ```http

# DELETE /locations/{id}

# ```

# 

# \## Dados de Exemplo

# 

# O projeto popula automaticamente o banco de dados quando não existem registros.

# 

# Alguns exemplos incluídos:

# 

# \* Cristo Redentor

# \* Pão de Açúcar

# \* Praia de Copacabana

# \* Praia de Ipanema

# \* Maracanã

# \* Jardim Botânico

# \* Parque Lage

# \* Arpoador

# \* Pedra da Gávea

# \* Quinta da Boa Vista

# 

# \## Executando Localmente

# 

# \### Clonar Repositório

# 

# ```bash

# git clone https://github.com/SEU-USUARIO/SEU-REPOSITORIO.git

# cd SEU-REPOSITORIO

# ```

# 

# \### Restaurar Dependências

# 

# ```bash

# dotnet restore

# ```

# 

# \### Executar Aplicação

# 

# ```bash

# dotnet run

# ```

# 

# \## Executando com Docker

# 

# \### Construir e Iniciar Containers

# 

# ```bash

# docker compose up --build

# ```

# 

# \### Encerrar Containers

# 

# ```bash

# docker compose down

# ```

# 

# \## Swagger

# 

# Após iniciar a aplicação:

# 

# ```text

# http://localhost:5000/swagger

# ```

# 

# ou

# 

# ```text

# http://127.0.0.1:5000/swagger

# ```

# 

# A documentação interativa permite testar todos os endpoints diretamente pelo navegador.

# 

# \## Aprendizados Aplicados

# 

# Durante o desenvolvimento deste projeto foram estudados e aplicados:

# 

# \* Criação de APIs REST

# \* ASP.NET Core

# \* Entity Framework Core

# \* Migrations

# \* PostgreSQL

# \* Injeção de Dependência

# \* DTOs

# \* CRUD

# \* Filtros Dinâmicos

# \* Paginação

# \* Docker

# \* Swagger

# 

# \## Melhorias Futuras

# 

# \* Busca geográfica por raio

# \* Ordenação dinâmica

# \* Async/Await em todos os endpoints

# \* Service Layer

# \* Repository Pattern

# \* Autenticação com JWT

# \* Testes automatizados

# \* Deploy em nuvem

# 

# \## Autor

# 

# Matheus Teixeira

