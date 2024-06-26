# Planos de Testes de Software

Este documento tem como objetivo apresentar uma estratégia detalhada para a realização de testes que assegurem não apenas a funcionalidade, mas também a confiabilidade, desempenho e usabilidade do software desenvolvido.

### Tipo de Teste
- **Sucesso**: Tem o objetivo de verificar se as funcionalidades funcionam corretamente.
- **Erro**: Tem o objetivo de verificar se o sistema trata erros de maneira correta.

<table>
  <tr>
    <th colspan="2" width="1000">CT-001<br>Login com credenciais válidas</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se um usuário pode fazer login com sucesso utilizando credenciais válidas.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
 <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-001: O funcionário deve conseguir logar no aplicativo</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Inserir o CPF válido.<br>
      3. Inserir a senha válida.<br>
      4. Clicar no botão "Entrar".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "admin@123"
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve redirecionar o usuário para a página inicial do aplicativo após o login bem-sucedido.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-002<br>Login com credenciais inválidas</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se um usuário é impedido de fazer login utilizando credenciais inválidas.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-001: O funcionário deve conseguir logar no aplicativo</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Inserir o CPF válido.<br>
      3. Inserir a senha inválida.<br>
      4. Clicar no botão "Entrar".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "senha@123"
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve informar ao usuário que os dados de login estão inválidos.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-003<br>Login com credenciais de um usuário desabilitado</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se um usuário desabilitado é impedido de fazer login.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-001: O funcionário deve conseguir logar no aplicativo</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Inserir o CPF desabilitado.<br>
      3. Inserir a senha.<br>
      4. Clicar no botão "Entrar".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "50160209064"<br>
      - <strong>Senha:</strong> "Teste@123"
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve informar ao usuário que ele está impedido de entrar no aplicativo.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-004<br>Alterar a senha de acesso passando dados válidos</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se um usuário consegue alterar sua senha de acesso.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-002: O funcionário deve conseguir alterar sua senha de acesso</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Clicar no link "Esqueceu a senha? Alterar".<br>
      2. Inserir o CPF válido.<br>
      3. Inserir a nova senha.<br>
      4. Inserir a senha novamente.<br>
      4. Clicar no botão "Alterar senha".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "50160209064"<br>
      - <strong>Nova senha:</strong> "Senha@123"<br>
      - <strong>Confirmar senha:</strong> "Senha@123"
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve informar ao usuário que a senha foi alterada com sucesso.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-005<br>Alterar a senha de acesso passando um CPF não cadastrado</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o sistema informa ao usuário que o CPF não está cadastrado.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-002: O funcionário deve conseguir alterar sua senha de acesso</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Clicar no link "Esqueceu a senha? Alterar".<br>
      2. Inserir o CPF não cadastrado.<br>
      3. Inserir a nova senha.<br>
      4. Inserir a senha novamente.<br>
      4. Clicar no botão "Alterar senha".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "47542542010"<br>
      - <strong>Nova senha:</strong> "Senha@123"<br>
      - <strong>Confirmar senha:</strong> "Senha@123"
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve informar ao usuário que o CPF não está cadastrado.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-006<br>Listar funcionários habilitados</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o sistema lista corretamente apenas os funcionários habilitados na aba de "usuários ativos".</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Error</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-004: O admin deve conseguir listas todos os funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve mostrar apemas os funcionários habilitados.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-007<br>Listar funcionários desabilitados</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o sistema lista corretamente apenas os funcionários desabilitados na aba de "usuários inativos".</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-004: O admin deve conseguir listas todos os funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      4. Clicar em "Usuários inativos".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve mostrar apenas os funcionários desabilitados.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-008<br> Registrar Início de Jornada</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o usuário consegue registrar corretamente a marcação do horário de início sua jornada de trabalho</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Walber</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-009: O funcionário deve conseguir registrar o início da sua jornada de trabalho</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário já cadastrado<br>
      3. Iniciar a jornada clicando no botão "Iniciar Jornada de Trabalho".<br>
      5. Marcar o horário de jornada clicando em "Iniciar Jornada de Trabalho" e após "Finalizar Jornada de Trabalho". <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "059.333.006-40"<br>
      - <strong>Senha:</strong> "Teste123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve registrar o inicio jornada de trabalho</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-009<br> Registrar Fim de Jornada</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o usuário consegue registrar corretamente a marcação do horário de fim da sua jornada de trabalho</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Walber</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-009: O funcionário deve conseguir registrar o final da sua jornada de trabalho</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário já cadastrado<br>
      3. Iniciar a jornada clicando no botão "Finalizar Jornada de Trabalho".<br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "059.333.006-40"<br>
      - <strong>Senha:</strong> "Teste123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve registrar e fim da jornada de trabalho</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-010<br>Registrar Marcação da Inicio do "Horário de Almoço"</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o usuário consegue registrar corretamente a marcação de entrada do seu horario de almoço</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Rayane</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-010: O funcionário deve conseguir registrar o inicio do seu horário de almoço	</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário já cadastrado<br>
      3. Após ter clicado em "Iniciar Jornada de Trabalho, clicar em "Iniciar horário de almoço".<br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "566.765.836-40"<br>
      - <strong>Senha:</strong> "909090Lo"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve registrar o inicio do horário de almoço</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-011<br>Registrar Marcação da Fim do "Horário de Almoço"</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o usuário consegue registrar corretamente a marcação fim do seu horario de almoço</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Rayane</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-010: O funcionário deve conseguir o fim do horário de almoço	</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário já cadastrado<br>
      3. Após ter clicado em "Iniciar Jornada de Trabalho, clicar em "Iniciar horário de almoço".<br>
      4. Para finalizar, clicar em "Finalizar hórario de almoço".
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "566.765.836-40"<br>
      - <strong>Senha:</strong> "909090Lo"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve registrar o fim do horário de almoço</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-012<br>Cadastrar novo funcionário</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue cadastrar um novo funcionário passando dados válidos.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Bruno Selas</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-003: O admin deve conseguir cadastrar novos funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão "+".<br>
      4. Inserir o nome válido. <br>
      5. Inserir o CPF válido.<br>
      6. Inserir a senha válida. <br>
      7. Inserir a jornada de trabalho válida. <br>
      8. Inserir o tempo de almoço válido. <br>
      9. Clicar em cadastrar funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome:</strong> "Bruce Wayne"<br>
      - <strong>CPF:</strong> "435.566.600-08"<br>
      - <strong>Senha:</strong> "Batman123"<br>
      - <strong>Jornada de trabalho:</strong> "8:00"<br>
      - <strong>Tempo de almoço:</strong> "1:30"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve cadastrar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
</table>

<br/>

 <table>
  <tr>
    <th colspan="2" width="1000">CT-013<br>Administrador conseguir listar pontos dos funcionários</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue listar os pontos dos funcionários.</td>
  </tr>
   <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Juliana</td>
  </tr>
   <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-0012 O admin deve conseguir listar todos os pontos dos funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "Folha de Ponto" na barra de navegação.<br>
      3. Marcar o mês desejado.<br>
      4. Selecionar o Funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve listar os pontos do funcionário no mês.</td>
  </tr>
</table>

<br/>

 <table>
  <tr>
    <th colspan="2" width="1000">CT-014<br>Administrador não terá informações dos meses sem marcações</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se os meses sem marcações não geram relatórios.</td>
  </tr>
   <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Juliana</td>
  </tr>
   <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-012 O admin deve receber informação que não é registro de ponto naquele determinado mês</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "Folha de Ponto" na barra de navegação.<br>
      3. Marcar o mês desejado.<br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema informar "nenhum registro encontrado para a data selecionada".</td>
  </tr>
</table>

<br/>

 <table>
  <tr>
    <th colspan="2" width="1000">CT-015<br>O funcionário conseguir listar todos os seus pontos </th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o funcionario consegue listar todos os seus registros de pontos</td>
  </tr>
   <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Juliana</td>
  </tr>
   <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-011 O funcionário deve conseguir listar todos seus registros de pontos</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Inserir o CPF válido.<br>
      3. Inserir a senha válida.<br>
      4. Clicar no botão "Entrar".<br>
      5. Ir em Folha de Ponto.<br>
      6. Selecionar o mês correto.<br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "566.765.836-40"<br>
      - <strong>Senha:</strong> "909090Lo"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O funcionario deve conseguir listar todos os seus registros de pontos.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-016<br>Cadastrar dois perfis com um mesmo CPF</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste tem como objetivo verifica se o administrador consegue cadastrar dois funcionários com um mesmo número de CPF
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Bruno Selas</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-003: O admin deve conseguir cadastrar novos funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão "+".<br>
      4. Inserir o nome válido. <br>
      5. Inserir um CPF já cadastrado em outro perfil de funcionario .<br>
      6. Inserir a senha válida. <br>
      7. Inserir a jornada de trabalho válida. <br>
      8. Inserir o tempo de almoço válido. <br>
      9. Clicar em cadastrar funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome:</strong> "Dick Grayson"<br>
      - <strong>CPF:</strong> "435.566.600-08"<br>
      - <strong>Senha:</strong> "Robin123"<br>
      - <strong>Jornada de trabalho:</strong> "8:00"<br>
      - <strong>Tempo de almoço:</strong> "1:30"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema não deve cadastrar o funcionário e precisa retornar uma mensagem de erro ao usuário.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-017<br>Validação de campos. </th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue preencher os campos de cadastro com dados inválidos nos mesmos.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Bruno Selas</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-003: O admin deve conseguir cadastrar novos funcionários</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão "+".<br>
      4. preencher os campos de cadastro com dados inválidos. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome:</strong> "1234"<br>
      - <strong>CPF:</strong> "000-00"<br>
      - <strong>Senha:</strong> " "<br>
      - <strong>Jornada de trabalho:</strong> "1:30"<br>
      - <strong>Tempo de almoço:</strong> "8:00"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve impedir o cadastro do usuario e retornas as mensagens de erro correta de validação dos campos.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-018<br> Não permitir que o funcionário registre a saída no dia posterior ao do início da jornada</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o usuário consegue registrar a saída no dia seguinte o início da jornada. </td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Walber</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-009: O funcionário deve conseguir o fim do horário de almoço	</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário já cadastrado<br>
      3. Após ter clicado em "Iniciar Jornada de Trabalho, clicar em "Iniciar horário de almoço".<br>
      4. Para finalizar, clicar em "Finalizar hórario de almoço".<br>
      5. No dia seguinte clicar em "Fim da Jornada de trabalho". <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "566.765.836-40"<br>
      - <strong>Senha:</strong> "909090Lo"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema não deve permitir o registro de ponto em dia diferente do início da jornada.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-019<br>Editar funcionário</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue Edita dados de um funcionário já cadstrado passando dados válidos.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei Marques</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-005: O admin deve conseguir editar dados de um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome do funcionário<br>
      4. Alterar valor de um campo válido com dados válido. <br>
      5. Clicar em Salvar. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome:</strong> "Bruce Wayne"<br>
      - <strong>CPF:</strong> "435.566.600-08"<br>
      - <strong>Senha:</strong> "Batman123"<br>
      - <strong>Jornada de trabalho:</strong> "8:00"<br>
      - <strong>Tempo de almoço:</strong> "1:30"<br>
      <strong> Alterar tempo Tempo de almoço para:</strong> "02:00"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve alterar o dado do funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-020<br>Validação de campos ao Editar. </th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue preencher os campos de cadastro com dados inválidos ao Editar Funcionário.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei Marques</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Erro</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-005: O admin deve conseguir editar os dados de um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome do funcionário<br>
      4. Alterar valor de um campo válido com dados inválidos. <br>
      5. Clicar em Salvar. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome:</strong> "Bruce Wayne"<br>
      - <strong>Nome:</strong> "Alterar nome para Br"<br>
      - <strong>CPF:</strong> "435.566.600-08"<br>
      - <strong>CPF:</strong> "Alterar cpf para 111.111.111-11"<br>
      - <strong>Senha:</strong> "Batman123"<br>
      - <strong>Senha:</strong> "Alter senha para batman"<br>
      - <strong>Jornada de trabalho:</strong> "8:00"<br>
      - <strong>Jornada de trabalho:</strong> "Alterar hora para 38:00"<br>
      - <strong>Tempo de almoço:</strong> "1:30"<br>
      - <strong>Tempo de almoço:</strong> "Alterar campo para 41:30"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve impedir o cadastro do usuario e retornar mensagens de erro correta de validação dos campos.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-021<br>Desabilitar funcionário</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o administrador consegue desabilitar um funcionário já cadstrado.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei Marques</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-006: O admin deve conseguir habilitar e desabilitar um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome do funcionário<br>
      4. Clicar na engrenagem no canto superior direito. <br>
      5. Clicar em desabilitar Funcionário. <br>
      6. Clicar novamente em desabilitar Funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome do Funcionário:</strong> "Rose"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve desabilitar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-022<br>Habilitar funcionário</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verifica se o administrador consegue Habilitar um funcionário já cadstrado.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei Marques</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-006: O admin deve conseguir habilitar e desabilitar um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no menu superior em "Usuários Inativos"<br>
      4. Clicar em Habilitar ao lado do nome do funcionário <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>Nome do Funcionário:</strong> "Rose"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve Habilitar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-023<br>Desabilitar o usuário atual</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o administrador é impedido de desabilitar a si mesmo.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei Marques</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Falha</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-006: O admin deve conseguir habilitar e desabilitar um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome do usuário atual.<br>
      4. Clicar na engrenagem no canto superior direito. <br>
      5. Clicar em desabilitar Funcionário. <br>
      6. Clicar novamente em desabilitar Funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "50160209064"<br>
      - <strong>Senha:</strong> "Teste@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve mostrar uma mensagem impedindo o usuário de desabilitar a si mesmo.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-024<br>Excluir um funcionário</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o administrador consegue excluir um funcionário do sistema.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Sucesso</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-008: O admin deve conseguir excluir um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome de um usuário.<br>
      4. Clicar na engrenagem no canto superior direito. <br>
      5. Clicar em excluir Funcionário. <br>
      6. Clicar novamente em excluir Funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00000000000"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve excluir o funcionário do sistema e mostrar uma mensagem de sucesso para o usuário.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-025<br>Excluir o usuário atual</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o sistema impede o administrador de excluir a si mesmo do sistema.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Falha</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-008: O admin deve conseguir excluir um funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "funcionários" na barra de navegação.<br>
      3. Clicar no botão em Editar no lado direito ao nome do usuário atual.<br>
      4. Clicar na engrenagem no canto superior direito. <br>
      5. Clicar em excluir Funcionário. <br>
      6. Clicar novamente em excluir Funcionário. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "50160209064"<br>
      - <strong>Senha:</strong> "Teste@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve mostrar uma mensagem para o usuário impedindo de excluir a si mesmo.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-026<br>Teste de Geolocalização</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o sistema é capaz de usar a localização do dispositivo para habilitar/desabilitar o registro de ponto.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Edglei/Rayane</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Falha</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-009/RF-010:O funcionário deve conseguir registrar o início e o final da sua jornada de trabalho/O funcionário deve conseguir registrar a saída e o retorno do horário de almoço</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Dar o aceite de uso de localização do dispositivo.<br>
      4. Clicar em "Registro de ponto" na barra de navegação.<br>
      5. Clicar no botão de registro de jornada.<br>
      6. Receber o aviso de localização. <br>
      7. Fazer o registro da jornada. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00.000.000-00"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve retornar uma mensagem de erro caso o dispositivo não esteja na localização correta ou caso contrario prosseguir com o registro.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-027<br>Gerar relatórios em PDF dos registros de ponto</th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o sistema gera relatorios PDFs dos registros de pontos.</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Exito</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-013: O admin deve coseguir gerar relatórios dos registros de pontos</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "folhas de ponto" na barra de navegação.<br>
      3. Selecionar o funcionario ou o grupo de funcionarios desejados.<br>
      4. Clicar no botão "Gerar relatório de horas". <br>
      5. Abrir a página de vizualização de PDF do dispositivo. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00.000.000-00"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve gerar com exito o PDF formatado e com as informações corretas do funcionario selecionado.</td>
  </tr>
</table>

<br/>

<table>
  <tr>
    <th colspan="2" width="1000">CT-028<br>Edição/Abono por meio de declarações dos pontos. </th>
  </tr>
  <tr>
    <td width="150"><strong>Descrição</strong></td>
    <td>Este caso de teste verificar se o sistema possibilita a edição ou abono de registros de ponto .</td>
  </tr>
  <tr>
    <td><strong>Responsável pela funcionalidade</strong></td>
    <td width="430">Raul Oliveira/Bruno Selas</td>
  </tr>
  <tr>
    <td><strong>Tipo do Teste</strong></td>
    <td width="430">Exito</td>
  </tr> 
  <tr>
    <td><strong>Requisitos associados</strong></td>
    <td>RF-014: O admin deve conseguir acrescentar um registro de ponto ao funcionário</td>
  </tr>
  <tr>
    <td><strong>Passos</strong></td>
    <td>
      1. Abrir o aplicativo.<br>
      2. Fazer login com um usuário administrador.<br>
      3. Clicar em "folhas de ponto" na barra de navegação.<br>
      3. Selecionar o funcionario e clicar no lápis de edição ao lado de seu nome.<br>
      4. Selecionar o dia em que se deseja realizar alteração ou abono". <br>
      5. Prencher os campos de alteração corretamente. <br>
      </td>
  </tr>
    <tr>
    <td><strong>Dados de teste</strong></td>
    <td>
      - <strong>CPF:</strong> "00.000.000-00"<br>
      - <strong>Senha:</strong> "Admin@123"<br>
  </tr>
    <tr>
    <td><strong>Critérios de êxito</strong></td>
    <td>O sistema deve realizar a alteração e/ou o abono do potno selecionado pelo admin.</td>
  </tr>
</table>




# Evidências de Testes de Software

Abaixo estão as evidências dos testes propostos no Plano de Testes, os registros foram retirados da aplicação em funcionamento nos dispositivos dos desenvolvedores do projeto.

### Status
- ✅ O teste foi feito e está passando pelos critérios de êxito.
- ❌ O teste foi feito e não está passando pelos critérios de êxito.
- 🔜 O teste não foi feito ainda.


<table>
  <tr>
    <th colspan="6" width="1000">CT-001<br>Login com credenciais válidas</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve redirecionar o usuário para a página inicial do aplicativo após o login bem-sucedido.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">08/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está permitindo o login corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/2e3c1722-7adc-4bd4-8b4c-3abe9ddc1b48"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-002<br>Login com credenciais inválidas</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que os dados de login estão inválidos.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">08/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está impedindo que o usuário entre na aplicação com dados inválidos.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/3c2f5b0b-c54e-4038-beda-143ea4469e06"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-003<br>Login com credenciais de um usuário desabilitado</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que ele está impedido de entrar no aplicativo.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">08/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está impedindo que usuários desabilitados entre na aplicação</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/bac93544-7fa5-436a-823f-f6bcb99cf145"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-004<br>Alterar a senha de acesso passando dados válidos</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que a senha foi alterada com sucesso.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">08/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está alterando a senha do usuário corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/145afbcb-931d-4693-9e87-f9445efaceff"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-005<br>Alterar a senha de acesso passando um CPF não cadastrado</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que o CPF não está cadastrado.</td>
  </tr>
   <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O teste foi realizado na plaaforma IOS e o sistema apresentou o comportamento esperado.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/9b322cd2-6112-470e-bf64-ba291f830652"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-006<br>Listar funcionários habilitados</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve mostrar apemas os funcionários habilitados.</td>
  </tr>
  <tr>
     <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O teste foi realizado na plaaforma IOS e o sistema apresentou o comportamento esperado.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/86a2db51-cc4e-4363-a275-a75210dee844"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-007<br>Listar funcionários desabilitados</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve mostrar apenas os funcionários desabilitados.</td>
  </tr>
   <tr>
     <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O teste foi realizado na plaaforma IOS e o sistema apresentou o comportamento esperado.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/c19ec867-425b-41cf-b1f6-a53b419bc0bb"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-008<br>Registrar Início da Jornada</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que o horário de início da jornada foram registrados com sucesso.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Rayane </td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">09/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está registrando o horário de início da jornada corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/100081087/a2e57d57-8a2f-4153-932c-122dec1d1018"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-009<br>Registrar o Fim da Jornada</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que o horário de fim da jornada foram registrados com sucesso.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Rayane</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">09/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está registrando o horário de fim de jornada corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/100081087/b0b2fcb7-00c4-4bf4-87e9-9c4bb94ea488"/></td>
  </tr>
</table>

<br>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-010<br>Registrar Marcação da Inicio do "Horário de Almoço"</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que o horário de inicio do almoço foi registrado com sucesso.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Juliana</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">09/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está registrando o início do horário de almoço corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/104041600/e6390774-34f4-47fb-8e8a-45c85615b143"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-011<br>Registrar Marcação da Fim do "Horário de Almoço"</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve informar ao usuário que o horário do fim do almoço foi registrado com sucesso.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Juliana</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">09/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está registrando o fim do horário de almoço corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/104041600/43148eea-602a-4b4f-9972-1b6f4d52c453"/></td>
  </tr>
</table>

   
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-012<br>Cadastrar novo funcionário</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve cadastrar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Edglei</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Funcionário cadastrado com sucesso</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/97347735/a1c81425-5bdc-43c3-851e-6349c8704b5b"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-013<br>Administrador conseguir listar pontos dos funcionários</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve listar os pontos do funcionário no mês.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Walber</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">11/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema lista os pontos do funcionário no mês corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/103972585/cbec9a65-316d-4c82-be6a-ec23e2a54c12"/></td>
  </tr>
</table>




<table>
  <tr>
    <th colspan="6" width="1000">CT-014<br>Administrador não terá informações dos meses sem marcações</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema informar "nenhum registro encontrado para a data selecionada".</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Walber</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">11/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema emite a mensagem de ausencia de marcações corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
     <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/103972585/62027ac6-b7f8-4fca-9c46-665b9be06e62"/></td>
  </tr>
</table>


<table>
  <tr>
    <th colspan="6" width="1000">CT-015<br>O funcionário conseguir listar todos os seus pontos</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O funcionario deve conseguir listar todos os seus registros de pontos.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste </strong></td>
    <td width="430">Walber</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">11/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O funcionário consegue emitir corretamente seus registro de ponto.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/103972585/8a439534-bef0-4a9d-bde5-c041af8c1cdb"/></td>
  </tr>
</table>


<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-016<br>Cadastrar dois perfis com um mesmo CPF</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema não deve cadastrar o funcionário e precisa retornar uma mensagem de erro ao usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Edglei</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Sistema não permite cadastro com mesmo CPF</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/97347735/1ac11ed9-93dd-4b13-92a7-5d1f90a1358f"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-017<br>Validação de campos</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve impedir o cadastro do usuario e retornas as mensagens de erro correta de validação dos campos.</td>
  </tr>
   <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Edglei</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Aplicativo valida os campos, antes de salvar com sucesso</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/97347735/d037ec1e-54ef-4c6b-8031-0015e0928b88"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-018<br>Não permitir que o funcionário registre a saída no dia posterior ao do início da jornada</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O funcionario não conseguir registrar a saída no dia posterior ao do início da jornada.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste </strong></td>
    <td width="430">Rayane</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">❌</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">09/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema não está impedindo o funcionário de fechar as horas um dia depois.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/32c2041d-b8bc-436c-9dbd-2838fec913f5"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-019<br>Editar funcionário</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve alterar o dado do funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está alterando as informações na edição corretamente.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/b33b18f7-9ca0-4f85-8ff8-9db0b76e741d"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-020<br>Validação de campos ao Editar</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve impedir o cadastro do usuario e retornar mensagens de erro correta de validação dos campos.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está validando corretamente os campos na página de edição.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/cf6f9fac-ec56-4182-a4b2-6dd46617a6e2"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-021<br>Desabilitar funcionário</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve desabilitar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está desabilitando corretamente o funcionário.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/8f7d516b-c308-428f-84b4-3d3cab87d6a9"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-022<br>Habilitar funcionário</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve Habilitar o funcionário e mostrar uma mensagem de sucesso ao usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema está habilitando corretamente um usuário desabilitado.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/95344961-cd3f-45ba-b422-b5158d08ec11"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-023<br>Desabilitar o usuário atual</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve mostrar uma mensagem impedindo o usuário de desabilitar a si mesmo.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Raul Oliveira</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">❌</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">O sistema não está impedindo um usuário de se auto-desabilitar.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video preload="none" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/82043220/c25e82c8-6f3a-4419-9c91-3d526c6a7479"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-024<br>Excluir um funcionário</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve excluir o funcionário do sistema e mostrar uma mensagem de sucesso para o usuário.</td>
  </tr>
    <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Teste realizado na plataforma IOS onde o mesmo obtém como resultado o comportamento esperado.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/54289b1e-e9b6-491c-b21e-42244986c763"/></td>
  </tr>
</table>
<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-025<br>Excluir o usuário atual</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve mostrar uma mensagem para o usuário impedindo de excluir a si mesmo.</td>
  </tr>
     <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">❌</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">12/05/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Teste realizado na plataforma IOS onde o mesmo não apresentou o comportamento esperado, critério de falha: A aplicação permite que o ADM exclua sua própria conta do sistema.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/0220e88c-c988-49d9-b352-0f7d5790c773"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-026<br>Teste de Geolocalização</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve impedir ou permitir o funcionário de bater o ponto mediante sua localização.</td>
  </tr>
     <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">17/06/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Teste realizado na plataforma IOS onde o mesmo apresentou o comportamento esperado, critério de exito: A aplicação não permitiu o registro do ponto pela localização fora da empresa.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/d6d0fd01-2b7a-4dcc-bb90-71494294b5c7"/></td>
  </tr>
</table>
      
<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-027<br>Gerar relatórios em PDF dos registros de pontol</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve gerar um arquivo PDF formatado e com os registros corretos.</td>
  </tr>
     <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">✅</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">17/06/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Teste realizado na plataforma IOS onde o mesmo apresentou o comportamento esperado, critério de exito: A aplicação gerou o PDF formatado e com os dados corretos.</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/efd6807a-da68-4643-837e-573480704f18"/></td>
  </tr>
</table>

<br>

<table>
  <tr>
    <th colspan="6" width="1000">CT-028<br>Edição/Abono por meio de declarações dos pontos.</th>
  </tr>
  <tr>
    <td width="170"><strong>Critérios de êxito</strong></td>
    <td colspan="5">O sistema deve que o Adm Edite/Abone pontos por meio de declarações.</td>
  </tr>
     <tr>
    <td><strong>Responsável pelo Teste</strong></td>
    <td width="430">Bruno Selas</td>
    <td width="100"><strong>Status</strong></td>
    <td width="50" align="center">❌</td>
    <td width="100"><strong>Data</strong></td>
    <td width="150">17/06/2024</td>
  </tr>
    <tr>
    <td width="170"><strong>Comentário</strong></td>
    <td colspan="5">Teste realizado na plataforma IOS onde o mesmo não apresentou o comportamento esperado, critério de falha: A aplicação é capaz de editar registros de ponto porém não é capaz de realizar abono de faltas justificadas: (feature segue em review).</td>
  </tr>
  <tr>
    <td colspan="6" align="center"><strong>Evidência</strong></td>
  </tr>
  <tr>
    <td colspan="6" align="center"><video src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e5-proj-time-sheet/assets/102563767/ba5c49bf-6ab6-4322-8283-c94d7d8765c1"/></td>
  </tr>
</table>
