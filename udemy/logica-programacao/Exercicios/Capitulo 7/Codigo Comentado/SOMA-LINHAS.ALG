Algoritmo "soma-linhas"

Var
    // Declaração das variáveis
    n, m, i, j : inteiro                 // n = número de linhas, m = número de colunas
    mat : vetor[0..9,0..9] de real       // Matriz para armazenar os elementos inseridos pelo usuário
    vet : vetor[0..9] de real            // Vetor para armazenar a soma de cada linha da matriz

Inicio

    // Entrada de dados: Pergunta ao usuário a quantidade de linhas e colunas da matriz
    escreva("Qual a quantidade de linhas da matriz? ")
    leia(n)                              // Lê a quantidade de linhas da matriz
    escreva("Qual a quantidade de colunas da matriz? ")
    leia(m)                              // Lê a quantidade de colunas da matriz

    // Preenchimento da matriz: Pede ao usuário para inserir os elementos linha por linha
    para i de 0 ate n-1 faca
        escreval("Digite os elementos da ",i+1," a. linha: ")  // Informa qual linha o usuário vai preencher
        para j de 0 ate m-1 faca
            leia(mat[i,j])                // Lê cada elemento da matriz
        fimpara
    fimpara

    // Inicialização do vetor vet com 0: Esse vetor vai armazenar a soma das linhas
    para i de 0 ate n-1 faca
        vet[i] <- 0                         // Inicializa o valor da soma para a linha i como 0
        para j de 0 ate m-1 faca
            vet[i] <- vet[i] + mat[i,j]     // Soma todos os elementos da linha i da matriz
        fimpara
    fimpara

    // Exibição do vetor gerado: Mostra a soma de cada linha
    escreval("VETOR GERADO: ")
    para i de 0 ate n-1 faca
        escreval(vet[i]:3:1)               // Exibe o valor da soma de cada linha formatado com 3 casas e 1 casa decimal
    fimpara

Fimalgoritmo
