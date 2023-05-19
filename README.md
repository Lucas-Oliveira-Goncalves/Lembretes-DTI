# Lembretes-DTI
- Premissas Assumidas:
1 – O usuário utilizaria o sistema para cadastros de múltiplos bilhetes que poderiam ser cadastrados em dias diferentes, sendo que assim a separação por dia se torna muito importante.
2 – Sempre que um bilhete for cadastrado ou excluído deverá ocorrer a atualização do programa automaticamente para refletir o que foi feito.

- Decisões do Projeto:
1 - Executar o projeto como um Web APP CVM, esse tipo de projeto permitiu o armazenamento de bilhetes como variáveis locais e seu acesso para listagem de forma mais prática, assim como permite uma personalização melhor do projeto através do front-end para melhorar a experiencia para o usuário.
2 – Utilizar uma variável “Id” para identificação individual dos bilhetes, permitindo identificação e manipulação mais fácil de cada bilhete individualmente assim como lidar com possíveis duplicatas sem exclusão do bilhete utilizando apenas o nome e a data.
3 – Caso ainda não tenha sido cadastrado nenhum bilhete isso deve ser informado ao usuário, através da mensagem "Não existem lembretes no momento", o que deverá ser alterado a partir do primeiro bilhete cadastrado e consequentemente a cada novo bilhete cadastrado ou excluído.

- Instruções para executar o Sistema:
Para executar o sistema o usuário deve seguir alguns passos simples:
1° Passo – O usuário deverá se conectar ao aplicativo através do link enviado.
2° Passo - O usuário será direcionado à tela principal do aplicativo onde poderá cadastrar novos bilhetes assim como observar os bilhetes já cadastrados.
3° Passo - Para cadastrar um novo bilhete deverão ser informados dois dados, primeiro o nome daquele bilhete (seu conteúdo) e a data para qual aquele bilhete deve ser cadastrado, ambos os campos precisam ser preenchidos e a data deve ser uma data a partir da data atual (momento em que usuário está fazendo o cadastro do bilhete).
4° Passo - A partir da criação executada com sucesso a página será atualizada e o bilhete será cadastrado a partir da data selecionada e com nome descrito.
5° Passo - O usuário poderá também excluir qualquer um dos bilhetes selecionados através do botão “Remover Bilhete” localizado abaixo de cada um dos bilhetes.
