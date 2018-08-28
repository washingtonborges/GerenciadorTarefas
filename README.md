# Gerenciador  de Tarefas

## Objetivo
Criar um gerenciador de tarefas simples com um CRUD (Inclusão, Alteração e Deleção) da qual o usuário “logado” no sistema poderá incluir, alterar, deletar e “ticar” suas tarefas.

## Descrição do projeto
Criar um projeto utilizando como base um “template Bootstrap” a sua escolha.
Inicialmente teremos uma tela de login (onde já existira previamente um usuário “admin” e senha “admin”), quando o usuário se logar no sistema, aparecerá um menu de cadastro de novos usuários e o menu de tarefas, respeitando o controle de acesso existente.

### Novos Usuários
Conterá os seguintes campos (nome, email, permissão e senha), as permissões serão (administrador e usuário básico) onde administrador terá acesso a todas as telas e usuário básico poderá acessar apenas a tela de tarefas.

### Tela de Tarefas
Existira uma tela de consulta de tarefas com um Grid, botão de inserção de nova tarefa (pode ser modal) que pedirá apenas um título para a tarefa e botão de inserir. Ao inserir o item aparecerá no Grid, e para cada item existira a possibilidade de alterar e excluir, ambos podem ser tratados com “modal”, e com alertas de Sim ou Não para concluir a ação.
Deverá conter também ao lado de cada item um “CheckBox” de marcação de tarefa concluída, onde poderá existir alguma interação, ao marcar como concluído a linha do grid muda de cor e o texto fica “riscado” por exemplo.

## Requisitos
Utilização do Bootstrap como template principal do projeto, sendo estruturado com MVC (Model-View-Controller), utilizando como D.B o SqlServer Express com um localDb (enviar um script com a criação das devidas tabelas para nossa avaliação), podendo utilizar como ORM o Entity-Framework ou NHibernate, deverá possuir validações de formulário caso algum item esteja vazio ou incorreto.

# Solução
## Tecnologia Utilizada
- C# Asp .Net MVC  5.2.6.0
- Entity Framework  6.0
- Banco Dados LocalDB
- Bootstrap 4
## Desenvolvimento
A aplicação foi projetada através da premissa primeiro o código (Code-First), com o Entity Framework  fazendo a relação entre a classe de domínio (POCO) com o banco de dados, criando a camada de dados da aplicação para mapear o banco de dados. Com a vantagem de quando alterar o banco de dados basta trocar a string de conexão o Entity Framework faz o restante.

Com o objeto de mapeamento foi  adicionado classe responsável por iniciar a massa de dados mínima para utilização do sistema. 

Para o acesso ao sistema foi utilizado o  tíquete  e cookie  de autenticação, gerando uma aplicação mais segura, para implementação foi feita a captura do submit do formulário contendo as credencias, o  envio das informações foi feita  através de ajax para o back-end  da aplicação e recebendo a resposta para fazer seu devido tratamento.

O controle de acesso foi feito de forma customizada estendendo da classe nativa responsável (AuthorizeAttribute), foi adicionado um atributo personalizado para tal controle, também adicionado o redirecionamento para o controle de acesso caso tenha alguma violação e as páginas comuns de acesso como login e logout  tiveram suas visualização permitidas por visitantes anônimos. 

Utilização Scaffolding para gerar  automaticamente páginas Web para cada modelo de Dados da aplicação, assim entregando de forma mais ágil o CRUD básico para cada tabela do banco de dados e efetuais consulta a base dados através de expressões lambda.

As exibições dos formulários e demais páginas referente ao CRUD  foi feita através de Modal do Bootstrap , adicionado funções jQuery para exibir o conteúdo na Modal.

As mensagens de confirmação para cada ação do CRUD foi feita com javascript.

Também utilizado jQuery para interagir com ação do usuário, em "ticar" uma tarefa e efeitos CSS para formatar a tarefa conforme a interação .
O leiaute da página feito para deixar simples, objetivo e focando na lista de tarefas. O tema foi feito com ajustes na formatação de estilo mas, mantendo o máximo possível a estrutura do Bootstrap.
