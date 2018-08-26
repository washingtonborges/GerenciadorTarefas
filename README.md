# Gerenciador  de Tarefas

## Objetivo
Criar um gerenciador de tarefas simples com um CRUD (Inclusão, Alteração e Deleção) da qual o usuário “logado” no sistema poderá incluir, alterar, deletar e “ticar” suas tarefas.

## Descrição do projeto:
Criar um projeto utilizando como base um “template Bootstrap” a sua escolha.
Inicialmente teremos uma tela de login (onde já existira previamente um usuário “admin” e senha “admin”), quando o usuário se logar no sistema, aparecerá um menu de cadastro de novos usuários e o menu de tarefas, respeitando o controle de acesso existente.

### Novos Usuários
Conterá os seguintes campos (nome, email, permissão e senha), as permissões serão (administrador e usuário básico) onde administrador terá acesso a todas as telas e usuário básico poderá acessar apenas a tela de tarefas.

### Tela de Tarefas
Existira uma tela de consulta de tarefas com um Grid, botão de inserção de nova tarefa (pode ser modal) que pedirá apenas um título para a tarefa e botão de inserir. Ao inserir o item aparecerá no Grid, e para cada item existira a possibilidade de alterar e excluir, ambos podem ser tratados com “modal”, e com alertas de Sim ou Não para concluir a ação.
Deverá conter também ao lado de cada item um “CheckBox” de marcação de tarefa concluída, onde poderá existir alguma interação, ao marcar como concluído a linha do grid muda de cor e o texto fica “riscado” por exemplo.

## Requisitos
Utilização do Bootstrap como template principal do projeto, sendo estruturado com MVC (Model-View-Controller), utilizando como D.B o SqlServer Express com um localDb (enviar um script com a criação das devidas tabelas para nossa avaliação), podendo utilizar como ORM o Entity-Framework ou NHibernate, deverá possuir validações de formulário caso algum item esteja vazio ou incorreto.
