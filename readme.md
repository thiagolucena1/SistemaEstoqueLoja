# Sistema de Estoque De loja.

⚙️ Gerenciador de Produtos - Loja de Eletrônicos
Um sistema simples, direto e funcional, feito com C# e muito café ☕.

Este projeto simula o dia a dia de um sistema de gerenciamento para lojas de varejo, com funções de cadastro, edição e remoção de produtos via console — tudo pensando em escalabilidade futura, como persistência em JSON e interface gráfica.

## Funcionalidades

- Cadastro de novos produtos 
- Listagem dos produtos cadastrados.
- Remoção via ID
- Edição do nome e produto
- Serialização das informações do produto em um codigo JSON. 
- Console interativo para a execução das tarefas (Cadastrar, remover, listar e atualizar)


## Importante 

A maioria das interações são realizadas via **ID**. Cada produto contém o seu próprio ID para uma melhor organização.

## Futuras atualizações do codigo. 

- ~~Serialização dos produtos em um arquivo JSON , permitindo a permanência dos arquivos mesmo após o encerramento do programa.~~ **Implementado**
- Após a chamada da função RemoverProduto( ) , o codigo deverá excluir da base de dados da pasta IDprodutos.json. 
- Geração de uma tabela formatada de acordo com as suas descrições. 