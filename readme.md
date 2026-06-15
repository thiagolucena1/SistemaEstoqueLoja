# 📝 Sistema de Gerenciamento de Tarefas / Estoque (V 0.2)

<p align="center">
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/MVC-💻-blue?style=for-the-badge" alt="MVC" />
</p>

Apresento a vocês um projeto que fiz carinhosamente. Como pode ver, esse código é uma evolução do projeto anterior, onde o objetivo era criar um sistema de gerenciamento de tarefas.

Porém ao revisar o meu github, notei que a estrutura estava incorreta e decidi refazer o projeto do zero, utilizando as melhores práticas de desenvolvimento e organização de código. O resultado é um sistema de gerenciamento de tarefas mais robusto, escalável e fácil de manter. (Claro, ainda está em evolução) Mas gostaria de compartilhar com vocês o progresso que fiz até agora e as minhas melhorias.

---

## 🎯 O Diferencial do Projeto

Este projeto não é apenas um CRUD comum. Ele tem como foco, além de registrar, deletar e consultar, manter um histórico documentado das ações realizadas para manter um controle seguro:

* **Logs e Rastreabilidade:** Cada update, insert ou delete é registrado em logs, seja no banco de dados ou em um arquivo JSON. Isso garante que todas as ações sejam rastreáveis e auditáveis, proporcionando uma camada extra de segurança e transparência para o sistema.
* **Estrutura Modular:** Implementei uma estrutura de código mais modular e organizada, seguindo as melhores práticas de desenvolvimento. Isso facilita a manutenção e a escalabilidade do projeto, permitindo que novas funcionalidades sejam adicionadas de forma mais eficiente no futuro.

---

## 🏗️ Estrutura do Projeto

Estarei explicando abaixo a estrutura do projeto até o presente momento:

```text
EstoqueLojaV.0.2
├── 📁 Business
│   └── EstoqueBusiness.cs      # Controla as regras de negócio relacionadas ao estoque e garante que o repositorio receba a entidade tratada
├── 📁 Controllers
│   └── [Controllers]           # Responsáveis pelas requisições HTTP
├── 📁 Interfaces
│   ├── 📁 IBusinessInterfaces
│   │   └── IEstoqueBusiness.cs # Contratos da camada de negócio
│   └── 📁 IRepositoryData
│       └── [Interfaces]        # Interfaces de persistência dos dados
├── 📁 Models
│   └── [Models]                # Entidades da aplicação
└── 📁 Views
    └── [Views]                 # Telas da aplicação MVC
