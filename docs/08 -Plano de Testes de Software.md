# 8. Plano de Testes de Software

O plano de teste aqui apresentado nos traz a relação de casos de testes a serem realizados.

## Requisitos para realização dos testes

Os requisitos para realização dos testes de software são:

- Computador ou smartphone com acesso a um navegador de internet.    
- Conectividade de Internet para acesso ao sistema

## Casos de teste

### CT1 - Cadastro de Setores

 - Requisito associado: RF-1

 - Objetivo: Verificar se o sistema é capaz de cadastrar os setores da entidade de forma correta. 

 - Procedimentos:
    1)Acesse a tela de cadastro de setores no sistema.
    2) Preencha os campos obrigatórios:
	 . Nome do setor: 
	 . Descrição: 
3)Clique no botão "Cadastrar" ou equivalente.
4)Verifique se o sistema exibe uma mensagem de confirmação informando que o setor foi cadastrado com sucesso.

 - Resultados esperado:
.O sistema deve permitir o cadastro de setores com sucesso.
.Após o cadastro, o setor cadastrado deve estar disponível na lista de setores cadastrados.
.O sistema deve exibir uma mensagem de confirmação após o cadastro.

### CT2 - Cadastro de Usuários 

- Requisito associado: RF-2

- Objetivo: Verificar se o sistema é capaz de cadastrar usuários.

- Procedimentos:
1)Acesse a tela de cadastro de usuários no sistema.
2)Preencha os campos obrigatórios para criar um novo usuário.
3)Clique no botão "Cadastrar".
4)Verifique se o sistema exibe uma mensagem de confirmação informando que o usuario foi cadastrado.

- Resultado esperado:
.O sistema deve permitir o cadastro de usuários com sucesso.
.O sistema deve exibir uma mensagem de confirmação após a associação.

### CT3 - Vinculação de Usuário a Setores

- Requisito associado: RF-3
 
- Objetivo: Verificar se o sistema é capaz de vincular um usuário a um ou mais setores, conforme especificado no requisito funcional.

- Procedimentos:
1)Acesse a tela de vinculação de usuários a setores no sistema.
2)Selecione o usuário ao qual deseja vincular setores na lista de usuários disponíveis.
3)Selecione um ou mais setores aos quais deseja vincular o usuário na lista de setores disponíveis.
4)Informe se o usuario poderá iniciar um processo no setor.
5)Clique no botão "Vincular" ou equivalente.
6)Verifique se o sistema exibe uma mensagem de confirmação informando que a vinculação foi bem-sucedida.

- Resultado esperado:
.O sistema deve permitir a vinculação de um usuário a um ou mais setores com sucesso.
.Após a vinculação, o usuário deve estar associado aos setores selecionados.
.O sistema deve exibir uma mensagem de confirmação após a vinculação.

### CT4 - Cadastro de Tipos de Processos

- Requisito associado: RF-4

- Objetivo: Verificar se o sistema é capaz de cadastrar tipos de processos de forma correta e eficiente.

- Procedimentos:
1)Acesse a tela de cadastro de tipos de processos no sistema.
2)Preencha os campos obrigatórios:
	Nome do tipo de processo: 
	Descrição: 
3)Clique no botão "Cadastrar" ou equivalente.
4)Verifique se o sistema exibe uma mensagem de confirmação informando que o tipo de processo foi cadastrado com sucesso.

- Resultado esperado:
.O sistema deve permitir o cadastro de tipos de processos com sucesso.
.Após o cadastro, o tipo de processo de teste deve estar disponível na lista de tipos de processos cadastrados.
.O sistema deve exibir uma mensagem de confirmação após o cadastro.

### CT-5 Cadastro de Interessados

- Requisito associado: RF-5

- Objetivo: Verificar se o sistema é capaz de cadastrar interessados, tanto pessoas físicas quanto jurídicas, de forma correta e eficiente.

- Procedimentos Pessoa Física:
1)Acesse a tela de cadastro de interessados no sistema.
2)Selecione a opção "Pessoa Física".
3)Preencha os campos obrigatórios:
	Nome: 
	CPF: 
4)Clique no botão "Cadastrar" ou equivalente.
5)Verifique se o sistema exibe uma mensagem de confirmação informando que a pessoa física foi cadastrada com sucesso.

- Procedimentos Pessoa Jurídica:
1)Acesse a tela de cadastro de interessados no sistema.
2)Selecione a opção "Pessoa Jurídica".
3)Preencha os campos obrigatórios:
	Nome da Empresa: 
	CNPJ: 
4)Clique no botão "Cadastrar" ou equivalente.
5)Verifique se o sistema exibe uma mensagem de confirmação informando que a pessoa jurídica foi cadastrada com sucesso.

- Resultado esperado:
.O sistema deve permitir o cadastro de interessados (pessoas físicas e jurídicas) com sucesso.
.Após o cadastro, o interessado de teste deve estar disponível na lista de interessados cadastrados.
.O sistema deve exibir uma mensagem de confirmação após o cadastro.

### CT-6 Cadastro de Processos

- Requisito associado: RF-6

- Objetivo: Verificar se o sistema é capaz de cadastrar processos, permitindo a especificação do tipo de processo, interessado, setor de origem e descrição de forma correta e eficiente.

- Procedimentos:
1)Acesse a tela de cadastro de processos no sistema.
2)Preencha os campos obrigatórios:
	Tipo de Processo: [Selecionar um tipo de processo existente]
	Interessado: [Selecionar um interessado existente]
	Setor de Origem: [Selecionar um setor de origem existente]
	Descrição do Processo: [Descrição do Processo de Teste]
3)Clique no botão "Cadastrar" ou equivalente.
4)Verifique se o sistema exibe uma mensagem de confirmação informando que o processo foi cadastrado com sucesso.

- Resultado esperado:
.O sistema deve permitir o cadastro de processos com sucesso, especificando o tipo de processo, interessado, setor de origem e descrição.
.Após o cadastro, o processo de teste deve estar disponível na lista de processos cadastrados.
.O sistema deve exibir uma mensagem de confirmação após o cadastro.

### CT-7 Cadastro de Anexos aos Processos

- Requisito associado: RF-7

- Objetivo: Verificar se o sistema é capaz de permitir o cadastro de anexos aos processos de forma correta e eficiente.

- Procedimentos:
1)Acesse a tela de cadastro de processos no sistema e selecione o processo ao qual deseja adicionar um anexo.
2)Clique no botão "Adicionar Anexo" ou equivalente.
3)Selecione o arquivo que deseja anexar ao processo.
4)Preencha campos opcionais, como descrição do anexo, se aplicável.
5)Clique no botão "Salvar" ou equivalente para confirmar o anexo.
6)Verifique se o sistema exibe uma mensagem de confirmação informando que o anexo foi adicionado com sucesso ao processo.

- Resultado esperado:
.O sistema deve permitir o cadastro de anexos aos processos com sucesso.
.Após o cadastro, o anexo deve estar associado ao processo escolhido.
.O sistema deve exibir uma mensagem de confirmação após o cadastro do anexo.

CT-8 Trâmite de Processo para Outros Setores

### Requisito associado: RF-8

- Objetivo: Verificar se o sistema é capaz de permitir o trâmite de um processo para outros setores de forma correta e eficiente.

- Procedimentos:
1)Selecione o processo que deseja tramitar no sistema.
2)Selecione a opção "Tramitar Processo" ou equivalente.
3)Escolha o setor de destino para o qual deseja tramitar o processo na lista de setores disponíveis.
4)Preencha campos opcionais, como uma observação sobre o trâmite, se aplicável.
5)Confirme o trâmite clicando no botão "Tramitar" ou equivalente.
6)Verifique se o sistema exibe uma mensagem de confirmação informando que o processo foi tramitado com sucesso para o novo setor.

- Resultado esperado:
.O sistema deve permitir o trâmite de um processo para outros setores com sucesso.
.Após o trâmite, o processo deve estar localizado no setor de destino.
.O sistema deve exibir uma mensagem de confirmação após o trâmite do processo.

### CT-9 Exclusão da Última Tramitação de um Processo

- Requisito associado: RF-9

- Objetivo: Verificar se o sistema é capaz de permitir a exclusão da última tramitação de um processo de forma correta e eficiente.

- Procedimentos:
1)Selecione o processo pre-cadastrado no sistema.
2)Selecione a opção "Histórico de Tramitações" ou equivalente para visualizar as tramitações registradas.
3)Identifique a última tramitação na lista de histórico de tramitações.
4)Selecione a opção "Excluir Tramitação" ou equivalente para excluir a última tramitação.
5)Confirme a exclusão quando solicitado pelo sistema.
6)Verifique se o sistema exibe uma mensagem de confirmação informando que a última tramitação foi excluída com sucesso.

- Resultado esperado:
.O sistema deve permitir a exclusão da última tramitação de um processo com sucesso.
.Após a exclusão, a última tramitação deve ser removida do histórico de tramitações do processo.
.O sistema deve exibir uma mensagem de confirmação após a exclusão da tramitação.

### CT-10 Acesso ao Sistema com Login

- Requisito associado: RF-10

- Objetivo: Verificar se o sistema exige que os usuários estejam logados para acessar suas funcionalidades.

- Procedimentos:
1)Acesse a página inicial ou a página de login do sistema.
2)Tente acessar qualquer funcionalidade ou página restrita do sistema, como por exemplo a url x. 
3)Verifique se o sistema redireciona o usuário para a página de login ou exige que o usuário faça login para continuar.

- Resultado esperado:
.O sistema deve exigir que o usuário faça login para acessar funcionalidades ou páginas restritas.
.O sistema deve redirecionar o usuário para a página de login quando ele tentar acessar uma funcionalidade restrita sem estar logado.

### CT-11  Busca de Processos por Filtros

- Requisito associado: RF-11

- Objetivo: Verificar se o sistema é capaz de permitir que o usuário busque processos com base em filtros de busca de forma correta e eficiente.

- Procedimentos:
1)Acesse a funcionalidade de busca de processos no sistema.
2)Preencha um ou mais filtros de busca, como tipo de processo, interessado, data de criação, setor de origem, etc.
3)Execute a busca clicando no botão "Buscar" ou equivalente.
4)Verifique se o sistema apresenta uma lista de processos que correspondem aos filtros de busca especificados.

- Resultado esperado:
.O sistema deve permitir que o usuário busque processos com base em filtros de busca com sucesso.
.Após a busca, o sistema deve exibir uma lista de processos que correspondem aos filtros de busca especificados.

### CT-12 Exportação da Listagem de Processos para o Excel

- Requisito associado: RF-12

- Objetivo: Verificar se o sistema é capaz de permitir a exportação da listagem de processos para um arquivo Excel de forma correta e eficiente.

- Procedimentos:
1)Acesse a funcionalidade de listagem de processos no sistema.
2)Selecione a opção "Exportar para Excel" ou equivalente.
3)Verifique se o sistema gera e disponibiliza um arquivo Excel para download.
4)Baixe o arquivo Excel gerado.
5)Abra o arquivo Excel e verifique se ele contém os dados corretos dos processos, incluindo informações como tipo de processo, interessado, data de criação, setor de origem, etc.

- Resultado esperado:
.O sistema deve permitir a exportação da listagem de processos para um arquivo Excel com sucesso.
.O arquivo Excel gerado deve conter os dados corretos dos processos, seguindo o formato esperado.
.O sistema gera e disponibiliza corretamente o arquivo Excel para download.

### CT-13 Consulta de Processo por CPF e Código Sem Autenticação

- Requisito associado: RF-13

- Objetivo: Verificar se o sistema permite que os usuários consultem processos por CPF e código do processo pela internet sem a necessidade de autenticação.

- Procedimentos:
1)Acesse a página de consulta pública de processos no site ou sistema pela internet.
2)Insira o CPF do interessado e o código do processo que deseja consultar.
3)Clique no botão "Consultar" ou equivalente.
4)Verifique se o sistema apresenta as informações do processo correspondente e suas movimentações.

- Resultado esperado:
.O sistema deve permitir que os usuários consultem processos por CPF e código do processo pela internet sem a necessidade de autenticação.
.O sistema deve apresentar as informações corretas do processo correspondente à consulta.

### CT-14 Trâmite Fora do Fluxo Pré-Determinado

- Requisito associado: RF-14

- Objetivo: Verificar se o sistema permite que o trâmite de um processo seja realizado fora do fluxo pré-determinado, conforme configurado na opção dentro do cadastro de tipos de processos.

- Procedimentos
1)Selecione um processo cadastrado que corresponde ao tipo de processo configurado com "Trâmite Fora do Fluxo Pré-Determinado" habilitado.
2)Selecione a opção para realizar o trâmite do processo.
3)Escolha o setor de destino para onde deseja tramitar o processo fora do fluxo pré-determinado.
4)Preencha campos opcionais, como uma observação sobre o trâmite, se aplicável.
5)Confirme o trâmite clicando no botão "Tramitar" ou equivalente.
6)Verifique se o sistema exibe uma mensagem de confirmação informando que o processo foi tramitado com sucesso para o novo setor fora do fluxo pré-determinado.

- Resultado esperado:
.O sistema deve permitir que o trâmite de um processo seja realizado fora do fluxo pré-determinado, conforme configurado na opção dentro do cadastro de tipos de processos.
.Após o trâmite, o processo deve estar localizado no setor de destino fora do fluxo pré-determinado.
.O sistema deve exibir uma mensagem de confirmação após o trâmite do processo.

### CT-15 Acesso Responsivo via Celular ou Tablet

- Requisito associado: RNF-2

- Objetivo: Verificar se o sistema é responsivo e pode ser acessado de forma adequada em dispositivos móveis, como celulares e tablets.

- Procedimentos:
1)Acesse o sistema por meio de um navegador em um dispositivo móvel, como um celular ou tablet.
2)Verifique se a página inicial do sistema é carregada corretamente e se todos os elementos estão visíveis e alinhados adequadamente na tela do dispositivo móvel.
3)Tente navegar pelas diferentes páginas e funcionalidades do sistema usando os controles de toque do dispositivo móvel, como toque, arraste e zoom.
4)Verifique se os elementos de interface, como botões, campos de entrada e menus, são de tamanho adequado para interação em telas sensíveis ao toque.
5)Gire o dispositivo entre os modos retrato e paisagem (se aplicável) e verifique se o layout do sistema se ajusta automaticamente à orientação da tela.
6)Teste a funcionalidade de rolagem para garantir que o conteúdo da página seja acessível e que não haja problemas de sobreposição ou recorte.
7)Tente realizar tarefas comuns no sistema, como pesquisa, preenchimento de formulários e interações com elementos interativos, para garantir que todas as funcionalidades estejam acessíveis e funcionem corretamente.
8)Verifique se todas as imagens e gráficos são exibidos de forma responsiva e se ajustam à largura da tela do dispositivo.
9)Avalie o desempenho do sistema em dispositivos móveis, verificando se as páginas carregam rapidamente e se não há atrasos significativos.

 - Resultado esperado:
.O sistema deve ser responsivo e se adaptar de forma adequada ao tamanho e à orientação da tela do dispositivo móvel.
.Todos os elementos de interface devem ser visíveis, interagíveis e de tamanho adequado para dispositivos móveis.
.Todas as funcionalidades do sistema devem funcionar corretamente em dispositivos móveis.
.O sistema deve ter um desempenho aceitável em dispositivos móveis.
.O sistema deve ser acessível em dispositivos móveis, seguindo as diretrizes de acessibilidade.

### CT-16 Acesso Simultâneo por Múltiplos Usuários

- Requisito associado: RNF-3

- Objetivo: Verificar se o sistema suporta com sucesso o acesso simultâneo de vários usuários, mantendo a estabilidade e o desempenho adequados.

- Procedimentos:
1)Configure um ambiente de teste que permita a simulação de acesso simultâneo por múltiplos usuários. Isso pode ser feito com ferramentas de teste de carga ou por meio de scripts de automação que simulem interações de usuários reais.
2)Determine o número máximo de usuários simultâneos que o sistema deve suportar com base nos requisitos de desempenho.
3)Inicie a simulação de acesso simultâneo com o número máximo de usuários configurados.
4)Monitore o sistema durante o teste para identificar qualquer lentidão, erros ou problemas de desempenho. Use ferramentas de monitoramento de desempenho, como CPU, memória e uso de rede.
5)Realize diversas ações e transações no sistema, incluindo a abertura de páginas, preenchimento de formulários, consultas de banco de dados, atualizações e outros cenários de uso comuns.
6)Verifique se o sistema mantém um desempenho aceitável e responde de maneira rápida e eficiente às solicitações de todos os usuários simultâneos.
7)Avalie a capacidade do sistema de gerenciar simultaneamente as transações de vários usuários, garantindo que não haja conflitos de dados ou erros de consistência.
8)Aumente gradualmente a carga de trabalho para testar os limites do sistema e verificar como ele lida com picos de tráfego.
9)Registre qualquer problema de desempenho, erros ou comportamento inesperado durante o teste.
10)Avalie se o sistema é capaz de escalonar horizontalmente (adicionar mais recursos, como servidores, conforme necessário) para acomodar um maior número de usuários simultâneos.

- Resultado esperado:
.O sistema deve ser capaz de suportar o número máximo de usuários simultâneos.
.O sistema deve manter a estabilidade e o desempenho adequados, mesmo sob carga máxima.
.Não deve haver erros críticos, falhas ou problemas graves de desempenho durante o teste.

### CT-17 Restrição de Cadastro de Interessados com mesmo CPF ou CNPJ

- Requisito associado: RN-1

- Procedimentos:
1)Acesse a funcionalidade de cadastro de interessados no sistema.
2)Insira os dados de um interessado com um CPF ou CNPJ que ainda não foi cadastrado no sistema.
3)Tente concluir o cadastro do interessado.
4)Verifique se o sistema permite o cadastro com sucesso e exibe uma mensagem de confirmação.
5)Tente cadastrar um novo interessado com o mesmo CPF ou CNPJ que foi usado no Passo 2.
6)Verifique se o sistema impede o cadastro e exibe uma mensagem de erro informando que o CPF ou CNPJ já está em uso.

- Resultado esperado:
.O sistema deve permitir o cadastro de um interessado com um CPF ou CNPJ não utilizado anteriormente.
.O sistema deve impedir o cadastro de um interessado com o mesmo CPF ou CNPJ que já foi cadastrado anteriormente.
.O sistema deve exibir mensagens de confirmação e erro apropriadas conforme necessário.

### CT-18 Obrigatoriedade do Nome da Pessoa

- Requisito associado: RN-2

- Objetivo: Verificar se o sistema requer que o nome da pessoa seja fornecido durante o cadastro e se valida essa informação corretamente.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de interessados no sistema.
2)Deixe o campo de nome em branco.
3)Tente concluir o cadastro sem fornecer o nome da pessoa.
4)Verifique se o sistema impede o cadastro e exibe uma mensagem de erro indicando que o campo de nome é obrigatório.
5)Preencha o campo de nome da pessoa com um nome válido.
6)Tente concluir o cadastro novamente com o nome preenchido.
7)Verifique se o sistema permite o cadastro com sucesso e exibe uma mensagem de confirmação.

- Resultado esperado:
.O sistema deve impedir o cadastro de uma pessoa sem fornecer o nome e exibir uma mensagem de erro indicando que o campo de nome é obrigatório.
.O sistema deve permitir o cadastro de uma pessoa quando o nome é fornecido corretamente e exibir uma mensagem de confirmação.

### CT-19 Validação de CPFs e CNPJs das Pessoas Cadastradas

- Requisito associado: RN-3

- Objetivo: Verificar se o sistema valida corretamente os CPFs e CNPJs fornecidos durante o cadastro de pessoas.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de interessados no sistema.
2)No campo de CPF/CNPJ, insira um número válido.
3)Tente concluir o cadastro.
4)No campo de CPF/CNPJ, insira um número inválido.
5)Tente concluir o cadastro novamente.

- Resultado esperado:
.O sistema deve permitir o cadastro apenas quando CPFs e CNPJs válidos são fornecidos e exibir uma mensagem de confirmação.
.O sistema deve impedir o cadastro e exibir uma mensagem de erro quando CPFs e CNPJs inválidos são fornecidos.

### CT-20 Código Incremental Único para Cada Interessado

- Requisito associado: RN-4

- Objetivo: Verificar se o sistema atribui um código incremental único para cada interessado cadastrado.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de pessoas no sistema.
2)Preencha os dados necessários para cadastrar uma nova pessoa, incluindo nome, CPF ou CNPJ e outros campos relevantes.
3)Conclua o cadastro da interessado.
4)Repita o processo de cadastro para um segunda interessado, fornecendo informações diferentes do primeiro interessado.
5)Verifique se o sistema atribui um código incremental único para o segundo interessado, que seja diferente do código do primeiro interessado.
6)Repita o processo de cadastro para um terceiro interessado, fornecendo informações diferentes dos dois primeiros interessados.
7)Verifique se o sistema atribui um código incremental único para o terceiro interessado, que seja diferente dos códigos dos dois interessados cadastradas anteriormente.

- Resultado esperado:
.O sistema deve atribuir um código incremental único para cada interessado cadastrado, garantindo que nenhum código seja repetido.
.Cada código incremental deve ser exclusivo para a respectiva interessado cadastrado.

### CT-21 Nome Único para Cada Setor

- Requisito associado: RN-5

- Objetivo: Verificar se o sistema impede a criação de setores com nomes duplicados e garante que cada setor tenha um nome único.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de setores no sistema.
2)Crie um novo setor informando um nome único para ele.
3)Verifique se o sistema permite a criação do setor com sucesso e exibe uma mensagem de confirmação.
4)Tente criar um segundo setor com o mesmo nome usado no Passo 2.
5)Verifique se o sistema impede a criação do segundo setor e exibe uma mensagem de erro informando que o nome do setor deve ser único.
6)Repita o processo de cadastro para um terceiro setor, fornecendo um nome diferente dos dois setores anteriores.
7)Verifique se o sistema permite a criação do terceiro setor com sucesso e exibe uma mensagem de confirmação.

- Resultado esperado:
.O sistema garante que cada setor tenha um nome único.
.O sistema exibe mensagens de confirmação e erro apropriadas conforme necessário.

### CT-22 Nome Único para Cada Tipo de Processo

- Requisito associado: RN-6

- Objetivo: Verificar se o sistema impede a criação de tipos de processo com nomes duplicados e garante que cada tipo de processo tenha um nome único.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de tipos de processo no sistema.
2)Crie um novo tipo de processo informando um nome único para ele.
3)Verifique se o sistema permite a criação do tipo de processo com sucesso e exibe uma mensagem de confirmação.
4)Tente criar um segundo tipo de processo com o mesmo nome usado no Passo 2.
5)Verifique se o sistema impede a criação do segundo tipo de processo e exibe uma mensagem de erro informando que o nome do tipo de processo deve ser único.
6)Repita o processo de cadastro para um terceiro tipo de processo, fornecendo um nome diferente dos dois tipos de processo anteriores.
7)Verifique se o sistema permite a criação do terceiro tipo de processo com sucesso e exibe uma mensagem de confirmação.

- Resultados Esperados:
.O sistema deve permitir a criação de tipos de processo com nomes únicos.
.O sistema deve impedir a criação de tipos de processo com nomes duplicados e exibir mensagens de erro apropriadas.

### CT-23  Requisitante e Tipo Obrigatórios para Cada Processo

- Requisito associado: RN-7

- Objetivo: Verificar se o sistema impede a criação de processos que não tenham um requisitante e um tipo de processo definidos.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de processos no sistema.
2)Tente criar um novo processo sem definir um requisitante ou um tipo de processo.
3)Verifique se o sistema impede a criação do processo e exibe mensagens de erro indicando que o requisitante e o tipo de processo são campos obrigatórios.
4)Preencha os campos de requisitante e tipo de processo com valores válidos.
5)Tente concluir o cadastro do processo.
6)Verifique se o sistema permite a criação do processo com sucesso e exibe uma mensagem de confirmação.

- Resultados Esperados:
.O sistema deve impedir a criação de processos que não tenham um requisitante e um tipo de processo definidos.
.O sistema deve exibir mensagens de erro indicando que o requisitante e o tipo de processo são campos obrigatórios quando não são fornecidos.
.O sistema deve permitir a criação de processos quando requisitante e tipo de processo são fornecidos corretamente.

### CT-24 Geração de Código Incremental para Cada Processo

- Requisito associado: RN-8

- Objetivo:

- Procedimentos:
1)Acesse a funcionalidade de cadastro de processos no sistema.
2)Preencha os campos necessários para cadastrar um novo processo, incluindo requisitante, tipo de processo e outros campos relevantes.
3)Conclua o cadastro do processo.
4)Repita o processo de cadastro para um segundo processo, fornecendo informações diferentes do primeiro processo.
5)Verifique se o sistema atribui um código incremental único para o segundo processo, que seja diferente do código do primeiro processo cadastrado.
6)Repita o processo de cadastro para um terceiro processo, fornecendo informações diferentes dos dois processos anteriores.
7)Verifique se o sistema atribui um código incremental único para o terceiro processo, que seja diferente dos códigos dos processos cadastrados anteriormente.

- Resultado esperado:
.O sistema deve atribuir um código incremental único para cada processo cadastrado, garantindo que nenhum código seja repetido.
.Cada código incremental deve ser exclusivo para o respectivo processo cadastrado.

### CT-25 O sistema deverá cadastrar automaticamente a data e hora do processo.

- Requisito associado: RN-9

- Objetivo: Verificar se o sistema registra automaticamente a data e hora de criação de cada processo.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de processos no sistema.
2)Preencha os campos necessários para cadastrar um novo processo, incluindo requisitante, tipo de processo e outros campos relevantes.
3)Conclua o cadastro do processo.
4)Verifique se o sistema registra automaticamente a data e hora de criação do processo.
5)Repita o processo de cadastro para um segundo processo, fornecendo informações diferentes do primeiro processo.
6)Verifique se o sistema registra automaticamente a data e hora de criação do segundo processo.
7)Repita o processo de cadastro para um terceiro processo, fornecendo informações diferentes dos dois processos anteriores.
8)Verifique se o sistema registra automaticamente a data e hora de criação do terceiro processo.

- Resultado esperado:
.O sistema deve registrar automaticamente a data e hora de criação de cada processo no momento em que o processo é cadastrado.
.A data e hora de criação registradas devem refletir o momento exato em que o processo foi criado.

### CT-26 Respeito ao Fluxo de Tramitação com Exceções no Cadastro de Tipo de Processo

- Requisito associado: RN-10

- Objetivo: Verificar se o sistema respeita o fluxo de tramitação padrão, a menos que seja definido de outra forma no cadastro de tipo de processo.

- Procedimentos:
1)Acesse a funcionalidade de cadastro de tipos de processo no sistema.
2)Crie um novo tipo de processo que siga o fluxo de tramitação padrão (sem exceções).
3)Verifique se o sistema permite a criação do tipo de processo com sucesso e exibe uma mensagem de confirmação.
4)Crie um segundo tipo de processo que defina exceções ao fluxo de tramitação padrão, especificando regras de tramitação diferentes.
5)Verifique se o sistema permite a criação do segundo tipo de processo com sucesso e exibe uma mensagem de confirmação.
6)Acesse a funcionalidade de cadastro de processos no sistema.
7)Crie um novo processo usando o primeiro tipo de processo criado no Passo 2 (sem exceções).
8)Verifique se o sistema segue o fluxo de tramitação padrão para esse tipo de processo.
9)Crie um segundo processo usando o segundo tipo de processo criado no Passo 4 (com exceções).
10)Verifique se o sistema segue as regras de tramitação especificadas para esse tipo de processo, que são diferentes do fluxo padrão.

- Resultado esperado:
.O sistema deve permitir a criação de tipos de processo com ou sem exceções ao fluxo de tramitação padrão.
.O sistema deve seguir o fluxo de tramitação padrão para tipos de processo sem exceções.
.O sistema deve seguir as regras de tramitação especificadas para tipos de processo com exceções.
