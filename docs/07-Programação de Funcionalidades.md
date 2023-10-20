# 7. Programação de Funcionalidades


| Código | Descrição | Artefatos |
| --- | --- | --- |
| RF-1 | O sistema deverá cadastrar os setores da entidade, setores estes para onde os processos serão iniciados e tramitados. | Controllers/SetorController.cs, Models/Setor.cs, Views/Setor/* |
| RF-2 | O sistema deverá cadastrar os usuários do sistema. | Controllers/UsuarioController.cs, Models/Usuario.cs, Views/Usuario/* |
| RF-3 | O sistema deverá vincular um usuário a um ou mais setores, definindo quem pode iniciar um processo do setor. | Controllers/UsuarioController.cs, Models/Usuario.cs, Views/Usuario/*, Controllers/SetoresUsuariosController.cs, Controllers/SetorUsuarioManutencao.cs, js/Site.js |
| RF-4 | O sistema deverá cadastrar tipos de processos. | Controllers/Tipo_ProcessoController.cs, Models/Tipo_Processo.cs, Views/Usuario/* |
| RF-5 | O sistema deverá cadastrar interessados, que podem ser pessoas físicas ou jurídicas. | Controllers/Interessado.cs, Models/Interessado.cs, Views/Interessado/* |
| RF-6 | O sistema deverá permitir cadastrar processos especificando tipo, interessado, setor de origem e descrição. | Controllers/ProcessoController.cs, Models/Processo.cs, Views/Processo/* |
| RF-7 | O sistema deverá permitir cadastrar anexos aos processos. | Controllers/AnexoProcessoController.cs, Models/AnexoProcesso.cs, Views/AnexoProcesso/* |
| RF-8 | O sistema deverá permitir tramitar um processo para outros setores. | Controllers/Movimentacao.cs, Models/Movimentacao.cs, Views/Movimentacao/* |
| RF-9 | O sistema deverá permitir excluir a última tramitação. | Controllers/Movimentacao.cs, Models/Movimentacao.cs, Views/Movimentacao/* |
| RF-10 | O usuário deverá estar logado para acessar o sistema. | Não está pronto|
| RF-11 | O sistema deverá permitir ao usuário buscar processos por filtros. | Controllers/ProcessoController.cs, Models/Processo.cs, Views/Processo/* |
| RF-12 | O sistema deverá permitir a exportação da listagem de processos para o Excel. | Controllers/ProcessoController.cs, Models/Processo.cs, Views/Processo/* | 
| RF-13 | O sistema deverá permitir a consulta do processo mediante CPF e código do processo, pela internet, sem autenticação. | Controllers/ConsultaPublicaController.cs, Models/ConsultaPublica.cs, Views/ConsultaPublica/* |
| RF-14 | O sistema deverá ter uma opção, dentro do cadastro de tipo de processos, que permita que o trâmite seja realizado fora do fluxo pré-determinado. | Controllers/Fluxo.cs, Models/Fluxo.cs, Views/Fluxo/* |


# Instruções de acesso
1. Clonar o repositório do github
2. Abrir o projeto pelo dotnet 6
3. Iniciar o projeto. O sistema será aberto em um navegador.
