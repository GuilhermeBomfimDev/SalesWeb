# SalesWebMVC Project

## 📖 Sobre o Projeto

O **SalesWebMVC** é um sistema de gestão de vendas desenvolvido em **C#** utilizando o framework **ASP.NET Core MVC**. Este projeto foi criado para facilitar a organização e controle de vendas, fornecendo uma plataforma para gerenciar departamentos, vendedores e registros de vendas de forma eficiente.

## 🌟 Funcionalidades Principais

- **Gestão de Departamentos:**
  - Listagem, criação, edição e exclusão de departamentos.

- **Gestão de Vendedores:**
  - Listagem de vendedores por departamento.
  - Registro, edição e exclusão de vendedores.

- **Gestão de Registros de Vendas:**
  - Consulta de vendas com filtros de data.
  - Integração para visualizar, organizar e gerenciar dados de vendas.

## 🛠️ Tecnologias Utilizadas

### Backend:
- **C#**
- **ASP.NET Core MVC**
- **Entity Framework Core** (ORM)

### Banco de Dados:
- **SQL Server**

### Frontend:
- **Razor Pages**
- **HTML/CSS**
- **Bootstrap**

---

## 📂 Estrutura do Projeto

```plaintext
SalesWebMvc/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── Services/
└── wwwroot/
```

### Descrição dos Principais Diretórios

- **Controllers:** Controlam as rotas e as ações da aplicação.
- **Models:** Contêm as entidades e lógicas de negócio.
- **Views:** Renderizam as páginas da aplicação.
- **Data:** Configuram o banco de dados e gerenciam a inicialização de dados.
- **Services:** Contêm a lógica de serviços, como regras de negócios, cálculos e manipulação de dados.

#### Estrutura Detalhada: Serviços
- **DepartmentService:** Gerencia a lógica de negócios para operações relacionadas a departamentos.
- **SellerService:** Responsável por registrar, editar e excluir vendedores, garantindo validações e consistência.
- **SalesRecordService:** Executa consultas e manipulação de dados de registros de vendas, incluindo filtros e cálculos personalizados.
- **Exceptions:** Contém classes de exceções específicas para tratar erros como:
  - **NotFoundException**
  - **IntegrityException**
  - **DbConcurrencyException**

---

## 📊 Estrutura do Banco de Dados

O banco de dados utiliza as seguintes tabelas:

### Departments
| Campo        | Tipo       | Descrição                  |
|--------------|------------|----------------------------|
| `Id`         | INT        | Identificador único.       |
| `Name`       | VARCHAR    | Nome do departamento.      |

### Sellers
| Campo        | Tipo       | Descrição                      |
|--------------|------------|--------------------------------|
| `Id`         | INT        | Identificador único.           |
| `Name`       | VARCHAR    | Nome do vendedor.              |
| `Email`      | VARCHAR    | E-mail do vendedor.            |
| `BirthDate`  | DATE       | Data de nascimento.            |
| `BaseSalary` | DECIMAL    | Salário base.                  |
| `DepartmentId`| INT       | FK para a tabela `Departments`.|

### SalesRecords
| Campo        | Tipo       | Descrição                      |
|--------------|------------|--------------------------------|
| `Id`         | INT        | Identificador único.           |
| `Date`       | DATE       | Data do registro.              |
| `Amount`     | DECIMAL    | Valor da venda.                |
| `Status`     | ENUM       | Status da venda.               |
| `SellerId`   | INT        | FK para a tabela `Sellers`.    |

---

## 🖥️ Configuração e Execução

### Pré-requisitos
- .NET SDK 7.0 ou superior
- SQL Server configurado
- Visual Studio ou VS Code

### Passo a Passo
1. Clone o repositório:
   ```bash
   git clone https://github.com/GuilhermeBomfimDev/SalesWeb.git
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
4. Execute as migrações:
   ```bash
   dotnet ef database update
   ```
5. Inicie o projeto:
   ```bash
   dotnet run
   ```
6. Acesse em:
   ```plaintext
   https://localhost:5001
   ```

---

## 🚀 Diferenciais Técnicos

- **Tratamento de Exceções Customizadas:** As classes de exceções proporcionam uma experiência mais controlada e informativa.
- **Filtros de Data:** Consultas eficientes com LINQ.
- **Design Responsivo:** Interface construída com Bootstrap.

---

## 🔍 Desafios Técnicos Resolvidos

- Configuração de migrações com dados iniciais (`SeedingService`).
- Tratamento de concorrência no banco de dados usando o `DbConcurrencyException`.

---

## 📌 Próximos Passos

- Adicionar autenticação de usuários.
- Implementar relatórios detalhados.
- Expandir suporte a outros bancos de dados.

---

## 🤝 Contribuições

Contribuições são bem-vindas! Abra uma issue ou envie um pull request para melhorar o projeto.

---

## 📜 Licença

Licenciado sob a [MIT License](LICENSE).

---

Feito por [Guilherme Bomfim](https://github.com/GuilhermeBomfimDev). 🚀
