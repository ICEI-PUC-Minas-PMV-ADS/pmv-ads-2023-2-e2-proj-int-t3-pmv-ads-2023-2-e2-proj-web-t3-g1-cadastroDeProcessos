# 2. ESPECIFICAÇÃO DO PROJETO

A equipe identificou os desafios e requisitos para o projeto por meio de uma abordagem centrada no usuário. Pesquisas qualitativas foram realizadas para compreender as necessidades e comportamentos dos potenciais usuários. Com base nessas informações, personas e histórias de usuários foram criadas para guiar o desenvolvimento do produto. Essa abordagem ajudou a equipe a garantir uma experiência satisfatória para os usuários e fidelização dos clientes.

## 2.1 Personas

Agora serão apresentadas no quadro a seguir as personas levantadas durante o processo de entendimento do problema.

Quadro 1 – Personas

| Nome | Ocupação | Motivações | Frustações |
|---|---|---|---|
| Rafaella | Protocolista | Recebe um volume muito grande de processos a serem lançados de forma manual | Perde-se o controle ao ter que fazer o trabalho em word e excel. |
| Gustavo | Protocolista | A tramitação é feita via livro protocolo em forma de caderno | Não consegue indexar processo de mais de 6 meses. |
| Paulo | Gerente de cadastro em entidade de saneamento | Recebe um volume de requisições de CND de forma manual | Tem que anexar a CND impressa em malotes que ficam fora de ordem |
| Sávio | Gerente de Departamento Pessoal | Toda solicitação de férias é via protocolo | As requisições chegam duplicadas e fora de ordem | 
| Beatriz | Contribuinte | Sempre realiza várias solicitações na prefeitura | O processo manual exige que ela vá presencialmente verificar o andamento dos processos |			

Fonte: Elaborado pelos autores com dados extraídos das entrevistas


## 2.2 História de Usuários

As seguintes histórias dos usuários foram registradas pelo entendimento do dia a dia das personas identificadas para o projeto.

| Pessoa | gostaria de | para |
| --- | --- | --- |
| Rafaella | Poder consultar o histórico do processo | Informar os requisitantes sobre o andamento e prazos |
| Gustavo | Poder fazer juntada de processos | Poder tramitar assuntos similares ao mesmo tempo, como corte de árvore da mesma rua |
| Sávio | Poder consultar o processo pela internet | Evitar que os interessados telefonem ou vão de forma presencial na prefeitura |
| Paulo | Poder anexar o PDF da CND direto no sistema | evitar ter que lidar com malotes físicos |
| Beatriz | Poder obter dados do processo direto pela internet | Evitar o deslocamento à entidade, principalmente na época que o COVID-19 estava em alta |


## 2.3 Requisitos do Projeto

A definição do escopo funcional do projeto ocorre mediante a descrição dos requisitos funcionais, os quais especificam as formas de interação dos usuários, e dos requisitos não funcionais, que determinam os aspectos gerais a serem apresentados pelo sistema. A seguir, são apresentados tais requisitos.

* Fornecer recursos que permitam o cadastro de processos e seus dados;
* Permitir a categorização, agrupamento e tramitação dos processos;
* Possibilitar a filtragem e ordenação dos processos, assim como definição de tempo de vida de arquivamento.

### 2.3.1 Requisitos Funcionais

A tabela a seguir apresenta os requisitos funcionais do projeto e sua prioridade.

| Código | Descrição | Prioridade |
| --- | --- | --- |
| RF-1 | O sistema deverá cadastrar os setores da entidade, setores estes para onde os processos serão iniciados e tramitados. | Alta |
| RF-2 | O sistema deverá cadastrar os usuários do sistema. | Alta |
| RF-3 | O sistema deverá vincular um usuário a um ou mais setores, definindo quem pode iniciar um processo do setor. | Alta |
| RF-4 | O sistema deverá cadastrar tipos de processos. | Alta |
| RF-5 | O sistema deverá cadastrar interessados, que podem ser pessoas físicas ou jurídicas. | Alta |
| RF-6 | O sistema deverá permitir cadastrar processos especificando tipo, interessado, setor de origem e descrição. | Alta |
| RF-7 | O sistema deverá permitir cadastrar anexos aos processos. | Baixa |
| RF-8 | O sistema deverá permitir tramitar um processo para outros setores. | Alta |
| RF-9 | O sistema deverá permitir excluir a última tramitação. | Alta |
| RF-10 | O usuário deverá estar logado para acessa o sistema. | Alta|
| RF-11 | O sistema deverá permitir ao usuário buscar processos por filtros. | Alta |
| RF-12 | O sistema deverá permitir a exportação da listagem de processos para o Excel. | Baixa | 
| RF-13 | O sistema deverá permitir a consulta do processo mediante CPF e código do processo, pela internet, sem autenticação. | Médio |
| RF-14 | O sistema deverá ter uma opção, dentro do cadastro de tipo de processos, que permita que o trâmite seja realizado fora do fluxo pré-determinado. | Médio |


### 2.3.2 Requisitos Não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

| Código | Descrição |
| --- | --- | 
| RNF-1 | Garantir boas práticas de desenvolvimento evitando um SQL Injection. |
| RNF-2 | O sistema poderá ser acessível via celular ou tablet (ser responsivo). |
| RNF-3 | O sistema poderá ser acessível por vários usuários ao mesmo tempo. |


### 2.3.3 Requisitos de negócios

A tabela a seguir apresenta os requisitos de negócios que o projeto deverá atender.

| Código | Descrição | Prioridade |
| --- | --- | --- | 
| RN-1 | Não se pode cadastrar mais de um interessado com o mesmo CPF ou CNPJ repetidamente. | Média |
| RN-2 | O nome da pessoa deve ser obrigatório. | Alta |
| RN-3 | Todos os CPFs e CNPJs das pessoas cadastradas devem ser validados.| Alta |
| RN-4 | Cada pessoa deverá ter um código incremental único. | Alta | 
| RN-5 | Cada setor deverá ter um nome único. | Alta | 	
| RN-6 | Cada tipo e processo deverá ter um nome único. | Alta | 	
| RN-7 | Cada processo deverá ter como obrigatório Requisitante, Tipo. | Alta | 	
| RN-8 | O sistema deverá gerar um código incremental para cada processo. | Alta | 	
| RN-9 | O sistema deverá cadastrar automaticamente a data e hora do processo. | Alta | 	
| RN-10 | O sistema deverá respeitar o fluxo de tramitação exceto seja definido o contrário no cadastro de tipo de processo. | Alta | 	

### 2.3.4 Restrições 

As questões que limitam a execução do projeto são apresentadas na tabela a seguir.
			
| Código | Descrição | Prioridade |
| --- | --- | --- |
| RE-1 | A entrega de cada etapa deverá cumprir o prazo definido. | Alta | 
| RE-2 | O sistema deverá ser desenvolvido utilizando-se linguagens de programação que não requeiram licença de software paga. | Baixa |
| RE-3 | O sistema não poderá utilizar trechos de programas já existentes. | Alta |

## 2.4 Diagrama de Caso de Uso


<P align='center'>
<img src='/docs/arquivos/Caso_De_Uso.png'><BR>
Figura 1: Diagrama de caso de uso
</P>



