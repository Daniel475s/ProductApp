# ProductApp - Sistema CRUD de Produtos

Aplicação Full Stack para gerenciamento de produtos com operações completas de CRUD (Create, Read, Update, Delete).

## 🛠️ Tecnologias

**Backend:** .NET 8, ASP.NET Core Web API, Entity Framework Core (InMemory), Swagger  
**Frontend:** Angular 17+, TypeScript, RxJS, Reactive Forms

## 📋 Funcionalidades

- Listagem de produtos com tabela formatada
- Cadastro de novos produtos com validações
- Edição de produtos existentes
- Exclusão de produtos com confirmação
- Interface responsiva

## 🏗️ Arquitetura

Projeto segue princípios **SOLID** e **Clean Code** com:
- **Backend:** Repository Pattern, Dependency Injection, RESTful API
- **Frontend:** Componentes Standalone, Reactive Forms, Services Pattern

```
product-crud/
├── ProductApi/              # Backend .NET
│   ├── Controllers/         # Endpoints da API
│   ├── Data/               # DbContext
│   ├── Models/             # Entidades
│   └── Repositories/       # Camada de dados
└── product-frontend/        # Frontend Angular
    └── src/app/
        ├── components/      # Componentes
        ├── models/          # Interfaces
        └── services/        # Comunicação HTTP
```

## 📦 Pré-requisitos

- .NET SDK 8.0+
- Node.js 18+
- Angular CLI: `npm install -g @angular/cli`

## 🚀 Instalação

### Backend
```bash
cd ProductApi
dotnet restore
dotnet run
```
**Acesse:** `http://localhost:7224` | **Swagger:** `http://localhost:7224/swagger`

### Frontend
```bash
cd product-frontend
npm install
ng serve
```
**Acesse:** `http://localhost:4200`

## 📡 API Endpoints

| Método | Endpoint | Descrição |
|--------|----------|-----------|
| GET | `/api/products` | Lista todos |
| GET | `/api/products/{id}` | Busca por ID |
| POST | `/api/products` | Cria novo |
| PUT | `/api/products/{id}` | Atualiza |
| DELETE | `/api/products/{id}` | Remove |
