# SalesWebMVC Project

## 📖 Sobre o Projeto

O **SalesWebMVC** é um sistema de gestão de vendas desenvolvido em **C#** utilizando o framework **ASP.NET Core MVC**. Este projeto foi criado para fornecer uma plataforma onde empresas podem gerenciar departamentos, vendedores e registros de vendas de forma eficiente e organizada.

## 🌟 Funcionalidades Principais

- **Gestão de Departamentos:**
  - Listagem, criação, edição e exclusão de departamentos.

- **Gestão de Vendedores:**
  - Listagem de vendedores por departamento.
  - Registro, edição e exclusão de vendedores.

- **Gestão de Registros de Vendas:**
  - Consulta de vendas com filtros de data.
  - Integração para visualizar e organizar dados de vendas.

## 🛠️ Tecnologias Utilizadas

- **Backend:**
  - C#
  - ASP.NET Core MVC

- **Banco de Dados:**
  - SQL Server (Entity Framework Core como ORM)

- **Frontend:**
  - Razor Pages
  - HTML/CSS/Bootstrap

## 📂 Estrutura do Projeto

```plaintext
SalesWebMvc/
├── Controllers/
│   ├── DepartmentsController.cs
│   ├── SellersController.cs
│   └── SalesRecordsController.cs
├── Models/
│   ├── Department.cs
│   ├── Seller.cs
│   └── SalesRecord.cs
├── Data/
│   ├── SeedingService.cs
│   └── SalesWebMvcContext.cs
├── Views/
│   ├── Departments/
│   ├── Sellers/
│   └── SalesRecords/
└── wwwroot/
```

### Pastas Principais:
- **Controllers:** Contém a lógica de controle de rotas e ações da aplicação.
- **Models:** Contém as classes que representam as entidades do sistema.
- **Views:** Contém as páginas da aplicação renderizadas para o usuário.
- **Data:** Contém a configuração do banco de dados e o serviço de preenchimento inicial de dados.

## 🖥️ Configuração e Execução

### Pré-requisitos

- .NET SDK 7.0 ou superior.
- SQL Server configurado.
- Visual Studio ou VS Code.

### Passo a Passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/SalesWebMVC.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd SalesWebMVC
   ```

3. Configure a conexão com o banco de dados no arquivo `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=SEU_SERVIDOR;Database=SalesWebMVC;User Id=SEU_USUARIO;Password=SUA_SENHA;"
   }
   ```

4. Execute as migrações para criar o banco de dados:
   ```bash
   dotnet ef database update
   ```

5. Execute o projeto:
   ```bash
   dotnet run
   ```

6. Acesse o sistema no navegador em:
   ```plaintext
   https://localhost:5001
   ```

## 📊 Estrutura do Banco de Dados

O projeto utiliza as seguintes tabelas:

- **Departments:**
  - `Id`: Identificador do departamento (auto incremento).
  - `Name`: Nome do departamento.

- **Sellers:**
  - `Id`: Identificador do vendedor (auto incremento).
  - `Name`: Nome do vendedor.
  - `Email`: E-mail do vendedor.
  - `BirthDate`: Data de nascimento.
  - `BaseSalary`: Salário base.
  - `DepartmentId`: Chave estrangeira para o departamento.

- **SalesRecords:**
  - `Id`: Identificador do registro de venda (auto incremento).
  - `Date`: Data da venda.
  - `Amount`: Quantia da venda.
  - `Status`: Status da venda.
  - `SellerId`: Chave estrangeira para o vendedor.

## 🤝 Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma issue ou enviar um pull request com melhorias e novas funcionalidades.

## 📜 Licença

Este projeto é licenciado sob a [MIT License](LICENSE).

---

Feito por Guilherme Bomfim.
