# Relatório 
 
<p>
  A criação deste jogo servirá como projeto de final de ano, com o objectio de apresentar os conhecimentos adquiridos ao longo do ano lectivo 2022/2023.
</p>
<p>
  Para uma primeira instância, foram declarados pequenos objectivos para a criação do mesmo, tais como:
</p>
<ul>
  <li> 
    <b>Pesquisa:</b> Primeiramente, começamos por estar informados acerca do jogo, informações como regras, mecânica, etc. Procurou-se por pessoas com prática e experiência no mesmo jogo para que nos fornecesse informações do jogo; Algumas das informações foram tiradas da internet.
  </li>
  <li> 
    <b>Preparação do plano para a criação:</b> Aqui foram abordados os passos a seguir para a conclusão e superação de dificuldades encontradas, divisão das tarefas para cada membro, datas de reuniões presenciais, entre outros. Sendo um grupo de cinco, as tarefas foram distribuídas da seguinte forma:
    <ul>
      <li> 
        Joel, Ladislau: Encarregados de cuidar do design geral do projecto, sendo os responsáveis no tratamento de gráficos e tarefas relacionadas.
      </li>
      <li> 
        José, Tailson: Encarregados da parte lógica do jogo. São os responsáveis pela mecânica do jogo, interação de usuários com os objetos do jogo e a movimentação dos mesmos.
      </li>
      <li> 
        Edson: Encarregado da integração da parte gráfica com a parte lógica e a correcção de eventuais bugs. Ele trabalhará em ambos os lados. 
      </li>
    </ul>
  </li>
  <li>
    <b> Escolha de linguagens e tecnologias: </b> É necessário saber que linguagens, tecnologias, frameworks e plataformas a serem usados na criação de projetos do tipo. Aqui, decidimos usar somente C# para a parte da mecânica do jogo e o Unity para o design, já que o último ofecere suporte para a linguagem escolhida.
  </li>
</ul>

## Visão Geral

<p>
  O jogo Ludo é um clássico jogo de tabuleiro que envolve estratégia e sorte. Ele é projetado para ser jogado por 2 a 4 jogadores e possui regras simples, tornando-o adequado para pessoas de diferentes idades. Vamos explorar os conceitos do jogo Ludo em detalhes:
</p>

### Gênero:
O Ludo é classificado como um jogo de tabuleiro de corrida e sorte. É um jogo que combina elementos de estratégia e competição, onde os jogadores tentam levar suas peças do início ao fim do tabuleiro antes dos oponentes.

### Tema:
O tema do jogo Ludo geralmente é baseado em uma corrida de volta para casa ou uma jornada. Cada jogador controla um conjunto de peças coloridas (geralmente quatro peças), que representam seus personagens ou "corredores" em busca de voltar para casa. O tema pode variar dependendo da edição ou versão específica do jogo, mas o conceito central de movimentar as peças pelo tabuleiro permanece o mesmo.

### Mecânicas principais:

 - Movimento das peças: Os jogadores lançam um dado ou dados para determinar o número de casas que podem avançar suas peças. Eles têm a opção de escolher qual peça mover com base no resultado do dado. O objetivo é mover as peças do ponto de partida até o ponto final, passando por um caminho pré-determinado no tabuleiro.

- Bloqueio e captura: Se uma peça de um jogador ocupar a mesma casa de outra peça do oponente, a peça do oponente é capturada e volta para o ponto de partida. Isso pode levar a situações estratégicas em que os jogadores bloqueiam ou capturam as peças uns dos outros para ganhar vantagem.

- Segurança nas casas: Existem áreas designadas no tabuleiro chamadas "casa segura" ou "casa-base", onde as peças dos jogadores estão protegidas e não podem ser capturadas pelos oponentes. Para entrar nessas casas ou sair delas, é necessário obter um resultado de dado específico.

- Competição: O Ludo é um jogo competitivo, onde os jogadores buscam ser os primeiros a trazer todas as suas peças de volta para casa. A estratégia envolve decidir quais peças mover, quando bloquear as peças dos oponentes e quando avançar rapidamente.

- Elemento de sorte: O Ludo também tem uma forte componente de sorte, pois o movimento das peças é determinado pelos resultados do dado. Isso significa que mesmo jogadores com estratégias sólidas podem enfrentar reviravoltas inesperadas com base na sorte do lançamento do dado.

## Progresso Alcançado

<ul>
  <li>
    Assuntos relacionados á pesquisa foram os primeiros a serem concluídos. Após isso, concluiu-se de que criar o jogo dado de início não seria possível pelas regras, estilos de jogo e especificações que variam de região para região, por isso optou-se por fazer o jogo Ludo, já que é um jogo com regras sólidas independentemente da região. Resultados mais significativos têm servido de bases para a criação do jogo e referências a prováveis funcionalidades. 
  </li>
  <li>
    Cada membro tem desempenhado a sua função tal como decidido, apesar de algumas falhas nas tentativas da integração da lógica com os gráficos, tudo continua sendo trabalhado até então.
  </li>
  <li>
    Livros, sites e até mesmo especialistas foram recorridos quando se chegou na parte da movimentação, sendo o efeito dos objetos deslizando sobre o mapa a maior dificuldade encontrada até então, mas já se está a trabalhar nisso.
  </li>
</ul>

## Desenvolvimento do Jogo

<p> 
  No dia 13/05/2023 foi realizado um encontro entre os membros do grupo para um melhor acerto e interação entre os mesmos.
</p>
<p>
  Para o design, se foi criado um único mapa que funcionará para todos os modos de jogo, independentemente do número de jogadores. O início de jogo padrão será com 4 jogadores, seguindo o sentido horário para as jogadas. 
</p>
<p>
  Caso não sejam necessários tantos jogadores, serão desabilitadas as outras áreas para jogadores de acordo com o desejado.
</p>
<p>
  Quanto a programação, houveram dúvidas sobre que linguagens utilizar, já que a base em C# é obrigatória. Não levou muito tempo na escolha, até que se foi acertado o uso de C# em tudo da parte programável. Unity foi o primeiro framework, escolhido sem sombra de dúvida.
</p>
<p>
  Para testes de movimentação e aplicação das regras, se foi criado um mapa usando matrizes.
</p>

## Design de Níveis e Mecânicas

<p>
  Para a m, foi desenhado um mapa utilizando matrizes booleanas, onde foram preenchidos a matriz manualmente com "TRUEs" e "FALSEs". Todas as posições com TRUE foram pintadas de verde enquanto as bordas de cada posição da matriz foram sendo construidas e definindo as cores como branco para que não atrapalhasse.
</p>
<p>
  Q
</p>