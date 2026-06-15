Apresento a vocês um projeto que fiz carinhosamente. 

Como pode ver, esse codigo é uma evolução do projeto anterior, onde o objetivo era criar um sistema de gerenciamento de tarefas.
Porém ao revisar o meu github, notei que a estrutura estava incorreta e decidi refazer o projeto do zero, utilizando as melhores práticas de desenvolvimento e organização de código.
O resultado é um sistema de gerenciamento de tarefas mais robusto, escalável e fácil de manter. (Claro, ainda esta em evolução) Mas gostaria de compartilhar com vocês o progresso que fiz até agora e as minhas melhorias.

Este projeto não é apenas um CRUD comum, ele tem como foco, além de registrar, deletar, consultar. Manter um histórico documentado das ações realizadas para manter um controle seguro. 

Cada update, insert ou delete é registrado em logs, seja no banco de dados ou em um arquivo JSON. Isso garante que todas as ações sejam rastreáveis e auditáveis, proporcionando uma camada extra de segurança e transparência para o sistema.

Além disso, implementei uma estrutura de código mais modular e organizada, seguindo as melhores práticas de desenvolvimento. Isso facilita a manutenção e a escalabilidade do projeto, permitindo que novas funcionalidades sejam adicionadas de forma mais eficiente no futuro.

Estarei explicando abaixo a estrutura do projeto até o presente momento.

EstoqueLojaV.0.2 │

├── Business │ 
└── EstoqueBusiness.cs │ (Controla as regras de negócio relacionadas ao estoque e garante que o repositorio receba a entidade tratada)  │
├── Controllers │
└── Responsáveis pelas requisições HTTP │
├── Interfaces │ 
├── IBusinessInterfaces │
│ └── IEstoqueBusiness.cs │ 
└── IRepositoryData │ 
	└── Interfaces de persistência dos dados │
├── Models │
└── Entidades da aplicação │ 
├── Views │ 
└── Telas da aplicação MVC


👨‍💻 Autor

Thiago Lucena

Desenvolvedor de Software | .NET | Banco de Dados | REST APIs| 

Análise e desenvolvimento de sistemas
IA E Machine learning |