# Receipt Generation and Management System

![C# Badge](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net Badge](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MySQL Badge](https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge)
![Docker Badge](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=fff&style=for-the-badge)

This project is a Recibo Generation and Management System developed considering a real case scenario on the Registro Civil of Itu. It aims to simplify and make the work more efficient by implementing updated necessities for managing and generating receipts in both provisional and definitive forms.

## Features
- **Recibo Provisorio Generation**
- **Recibo Definitivo Generation**
- **PDF Generation:** Generate PDF documents for both provisional and definitive receipts using QuestPDF.
- **Data Binding:** Bind data to forms for easy management and display.
- **Database Integration:** Use MySQL database for storing and retrieving receipt data.

## Technologies Used
- .NET 8
- C# 12.0
- Windows Forms
- Entity Framework Core 8.0
- MySQL (Docker Container)
- QuestPDF

# Project Structure
- **Recibo:** Main project folder.
- **Models:** Contains the data models for the application.
- **Util:** Contains utility classes, including PDF document generation.
- **View:** Contains the Windows Forms for the application.
- **ViewModel:** Contains the ViewModel classes for managing the data and business logic.
- **Program.cs:** Entry point of the application.
- **Recibo.csproj:** Project file containing dependencies and build configurations.

## Getting Started

### Prerequisites
- Visual Studio 2022
- .NET 8 SDK
- MySQL Server or Docker equivalent container

### Setup
1.	**Clone the repository:**
``` bash
   git clone https://github.com/kauefelippet/sistema-recibos.git
   cd recibo-management-system
``` 
2.	**Configure the database connection:** 
Update the connection string in `Program.cs` to match your MySQL server configuration:
``` csharp
   options.UseMySql("server=localhost;port=3307;database=recibos_db;uid=root;pwd=secret", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql"));
```
3.	**Run the application:**
Open the solution in Visual Studio 2022 and run the project.

## Contributing
Contributions are welcome! Fork the repository and submit pull requests for any improvements or bug fixes.

## License
This project is licensed under the MIT License.

## Sistema de Emissão e Gerenciamento de Recibos

![C# Badge](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net Badge](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MySQL Badge](https://img.shields.io/badge/MySQL-4479A1?logo=mysql&logoColor=fff&style=for-the-badge)
![Docker Badge](https://img.shields.io/badge/Docker-2496ED?logo=docker&logoColor=fff&style=for-the-badge)

Este projeto é um Sistema de Emissão e Gerenciamento de Recibos desenvolvido considerando um caso real no Registro Civil de Itu. Ele visa simplificar e tornar o trabalho mais eficiente, implementando necessidades atualizadas para gerenciar e gerar recibos em ambas as formas provisórias e definitivas.

## Funcionalidades
- **Emissão de Recibos Provisórios** 
- **Emissão de Recibos Definitivos**
- **Geração de PDF:** Gere documentos PDF para ambos os recibos provisórios e definitivos usando QuestPDF.
- **Binding de Dados:** Vincule dados a formulários para fácil gerenciamento e exibição.
- **Integração com Banco de Dados:** Utilize o banco de dados MySQL para armazenar e recuperar dados de recibos.

## Tecnologias Utilizadas
- .NET 8
- C# 12.0
- Windows Forms
- Entity Framework Core 8.0
- MySQL (Container Docker)
- QuestPDF

# Estrutura do Projeto
- **Recibo:** Pasta principal do projeto.
- **Models:** Contém os modelos de dados para a aplicação.
- **Util:** Contém classes utilitárias, incluindo a geração de documentos PDF.
- **View:** Contém os Windows Forms para a aplicação.
- **ViewModel:** Contém as classes ViewModel para gerenciar os dados e a lógica de negócios.
- **Program.cs:** Ponto de entrada da aplicação.
- **Recibo.csproj:** Arquivo contendo dependências e configurações de compilação.

## Utilização

### Pré-requisitos
- Visual Studio 2022
- SDK .NET 8
- Servidor MySQL ou container Docker equivalente

### Configuração
1. **Clone o repositório:**
```bash
git clone https://github.com/kauefelippet/sistema-recibos.git
cd recibo-management-system
```

2. **Configure a conexão com o banco de dados:**
Atualize a string de conexão no arquivo Program.cs para corresponder à sua configuração do MySQL:
```csharp
options.UseMySql("server=localhost;port=3307;database=recibos_db;uid=root;pwd=secret", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.39-mysql"));
```

3. **Execute a aplicação:**
Abra a solução no Visual Studio 2022 e execute o projeto.

## Contribuição
Contribuições são bem-vindas! Faça um fork do repositório e envie uma pull request para qualquer melhoria ou correção de bugs.

## Licença
Este projeto está licenciado sob a Licença MIT. 