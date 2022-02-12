Argumento de diagonalização de Cantor

Na teoria dos conjuntos, o argumento da diagonalização de Cantor, também chamada de argumento da diagonalização, foi publicado em 1891 por Georg Cantor como uma prova matemática de que existem conjuntos infinitos que não podem ser mapeados em uma correspondência um-para-um ao conjunto infinito de números naturais. Tais conjuntos são agora conhecidos como conjuntos incontáveis, e o tamanho dos conjuntos infinitos agora é tratada pela teoria dos números cardinais que Cantor iniciou.
O argumento da diagonalização não foi a primeira prova da não-enumerabilidade dos números reais de Cantor; ele realmente foi publicado bem posteriormente do que a sua primeira prova, que apareceu em 1874. No entanto, ele demonstra uma técnica poderosa e geral, que desde então tem sido usado em uma ampla gama de provas, também conhecido como argumentos da diagonalização por analogia com o argumento utilizado nesta prova. Os exemplos mais famosos são o paradoxo de Russell, o primeiro dos teoremas da incompletude de Gödel, e a resposta de Turing ao Entscheidungsproblem.


Conjunto incontável

Em seu artigo de 1891, Cantor considerou o conjunto T de todas as sequências infinitas de dígitos binários (isto é, consistindo apenas de zeros e uns). Ele começa com uma prova construtiva do seguinte teorema:
Se s1, s2, … , sn, … é qualquer enumeração dos elementos de T, então existe sempre um elemento s de T que corresponde a nenhum sn na enumeração.
Para provar isso, dada uma enumeração dos elementos arbitrários de T, por exemplo:

s1 =	(0,	0,	0,	0,	0,	0,	0,	...)
s2 =	(1,	1,	1,	1,	1,	1,	1,	...)
s3 =	(0,	1,	0,	1,	0,	1,	0,	...)
s4 =	(1,	0,	1,	0,	1,	0,	1,	...)
s5 =	(1,	1,	0,	1,	0,	1,	1,	...)
s6 =	(0,	0,	1,	1,	0,	1,	1,	...)
s7 =	(1,	0,	0,	0,	1,	0,	0,	...)
...

ele constrói a sequência s escolhendo seu n-ésimo dígito como um complemento para o n-ésimo dígito de sn, para cada n. No exemplo, isso resulta em:

s1	=	(0,	0,	0,	0,	0,	0,	0,	...)
s2	=	(1,	1,	1,	1,	1,	1,	1,	...)
s3	=	(0,	1,	0,	1,	0,	1,	0,	...)
s4	=	(1,	0,	1,	0,	1,	0,	1,	...)
s5	=	(1,	1,	0,	1,	0,	1,	1,	...)
s6	=	(0,	0,	1,	1,	0,	1,	1,	...)
s7	=	(1,	0,	0,	0,	1,	0,	0,	...)
...
s	=	(1,	0,	1,	1,	1,	0,	1,	...)

Por construção, s difere de cada sn, uma vez que seus n-ésimos dígitos diferem (destacado no exemplo). Portanto, não é possível s ocorrer na enumeração.
Com base neste teorema, Cantor, em seguida, usa um argumento indireto para mostrar que:
O conjunto T é incontável.
Ele assume a contradição de que T era contável. Em seguida, (todos) os seus elementos podem ser escritos como uma enumeração s1, s2, … , sn, … . Aplicando o teorema anterior a esta enumeração seria produzir uma seqüência s não pertencente à enumeração. No entanto, s era um elemento de T e, portanto, deve estar na enumeração. Isto contradiz a suposição original, assim T deve ser incontável.


Interpretação

A interpretação do resultado de Cantor depende do ponto de vista matemático levado em consideração. Para os construtivistas, o argumento não mostra mais de que não existe [bijeção] entre os números naturais e T. Não é excluída a possibilidade de que os últimos são subcontáveis. No contexto da matemática clássica, isso é impossível, e o argumento da diagonalização estabelece que, embora ambos os conjuntos sejam infinitos, na verdade existem sequências mais infinitas de zeros e uns do que há números naturais.


Números reais

A incontabilidade dos números reais já foi estabelecida pela primeira prova de incontabilidade de Cantor, mas também decorre do resultado acima. Para ver isso, vamos construir uma correspondência um-para-um entre o conjunto T de cadeias binárias infinitas e um subconjunto de R (o conjunto dos números reais). Como T é incontável, este subconjunto de R deve ser incontável. Daí R é incontável.
Para construir esta correspondência um-para-um (ou bijeção), observa-se que a sequência de t = 0111… aparece depois do ponto flutuante na correspondência binária 0.0111…. Isto sugere a definição da função f(t) = 0.t, em que t é uma cadeia de caracteres em T. Infelizmente, f(1000…) = 0.1000… = 1/2, e f(0111…) = 0.0111… = 1/4 + 1/8 1/16 + + … = 1/2. Assim, esta função não é uma bijeção dado que duas cadeias de caracteres correspondem a um número—um número com duas correspondências binárias.
No entanto, modificar esta função produz uma bijeção de T para o intervalo (0, 1), ou seja, os números reais maiores que 0 e menores que 1. A ideia é remover o elementos "problemáticos" de T e (0, 1) e tratá-los separadamente. A partir de (0, 1), retire os números que tem duas correspondências binárias. Coloque esses números em uma sequência: a = (1/2, 1/4, 3/4, 1/8, 3/8, 5/8, 7/8, ...). Remova as strings de T que aparecem depois da vírgula binária nas correspondências binárias de 0, 1, e os números da sequência de a. Coloque essas strings em uma seqüência: b = (000…, 111…, 1000…, 0111…, 01000…, 11000…, 00111…, 10111…, ...). Uma bijeção g(t) de T a (0, 1) é definida por: Se t é a cadeia n na sequência b, deixe g(t) ser o número de ordem n na sequência de a; caso contrário, g(t) = 0.t.
Para construir um bijeção de T para R: começamos com a função tangente tan(x), que nos dá uma bijeção de (-π / 2, π / 2) para R; veja a imagem à direita. Em seguida observe que a função linear h(x) = πx - π / 2 resulta a bijeção a partir de (0, 1) para (-π / 2, π / 2); veja a imagem à esquerda. A função composta tan(h (x)) = tan (πx - π / 2) fornece uma bijeção a partir de (0, 1) para R. Componha com esta função g(t) para obter tan (h (g (t)) ) = tan (πg (t) - π / 2), que é um bijeção de T para R. Isto significa que T e R têm a mesma cardinalidade-esta cardinalidade é chamada de "cardinalidade do contínuo".


Conjuntos gerais

A forma generalizada do argumento da diagonalização foi usado por Cantor para provar o teorema de Cantor: para cada conjunto S o conjunto das partes de S, ou seja, o conjunto de todos os subconjuntos de S (aqui escrito como P(S)), tem uma cardinalidade maior do que o próprio S. Esta prova é dada da seguinte forma:
Seja f uma função de S para P(S). Basta provar que f não pode ser sobrejetiva. Isso significa que algum membro T de P(S), ou seja, um subconjunto de S, não é a imagem de f. Como um exemplo, considere o seguinte conjunto:
T = { s ∈ S: s ∉ f(s) }.
Para todo s em S, ou s está em T ou não. Se s está em T, então, por definição de T, s não está em f(s), de modo que T não é igual a f(s). Por outro lado, se s não está em T, então por definição de T, s está em f(s), então novamente T não é igual a f(s). Para uma descrição mais completa desta prova, consulte o teorema de Cantor.


Consequências

Este resultado implica que a noção do conjunto de todos os conjuntos é uma noção inconsistente. Se S fosse o conjunto de todos os conjuntos, então P(S) seria ao mesmo tempo maior do que S e um subconjunto de S.
O paradoxo de Russell tem nos mostrado que a teoria ingênua dos conjuntos, baseada em um esquema de compreensão irrestrita, é contraditória. Note que há uma semelhança entre a construção de T e o conjunto no paradoxo de Russell. Portanto, dependendo de como modificamos o esquema do axioma de compreensão, a fim de evitar o paradoxo de Russell, argumentos como a não-existência de um conjunto de todos os conjuntos podem ou não permanecer válido.
O argumento da diagonalização mostra que o conjunto dos números reais é "maior" do que o conjunto dos números naturais (e, portanto, os números inteiros e racionais também). Portanto, podemos perguntar se há um conjunto cuja cardinalidade está "entre" o dos números inteiros e dos reais. Esta questão leva à hipótese do continuum. Da mesma forma, a questão de saber se existe um conjunto cuja cardinalidade está entre |S| and |P(S)| para algum infinito S leva à hipótese do continuum generalizada.
Análogos do argumento da diagonalização são amplamente utilizados na matemática para provar a existência ou não de certos objetos. Por exemplo, a prova convencional da insolubilidade do problema da parada é essencialmente um argumento da diagonalização. Além disso, a diagonalização foi originalmente usada para mostrar a existência de classes de complexidade arbitrariamente difíceis e desempenhou um papel fundamental na primeiras tentativas de provar se P não é igual a NP.
Versão da "New Foundations" de W. V. Quine
A prova acima falha para a teoria dos conjutos de "New Foundations" de W. V. Quine (NF). Em NF, o esquema de axioma ingênuo de compreensão é modificado para evitar os paradoxos através da introdução de uma espécie de teoria local. No esquema do axioma,
{ s ∈ S: s ∉ f(s) }
não é um conjunto - ou seja, não satisfaz o esquema de axioma. Por outro lado, poderíamos tentar criar um argumento da diagonalização modificado por perceber que
{ s ∈ S: s ∉ f({s}) }
é um conjunto no NF. No caso em que, se P1(S) é o conjunto de subconjuntos de um único elemento de Se f é uma proposta bijeção de P1(S) para P(S), ao menos um é capaz de utilizar a prova por contradição para provar que |P1(S)| < |P(S)|.
A prova segue pelo fato de que, se f eram de fato um mapeamento para P(S), então nós poderíamos encontrar r em S, tal que f({r}) coincide com o conjunto da diagonalização modificado, acima. Nós concluiríamos que, se r não está em f({r}), então r está em f({r}) e vice-versa.
Não é possível colocar P1(S) em uma relação um-para-um com S, como os dois têm diferentes tipos, e assim qualquer função assim definida violaria as regras de escrita para o esquema de compreensão.



Fonte: https://pt.wikipedia.org/wiki/Argumento_de_diagonaliza%C3%A7%C3%A3o_de_Cantor
