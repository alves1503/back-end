Algoritmo "soma-linhas"

Var
    // Declara��o das vari�veis
    n, m, i, j : inteiro                 // n = n�mero de linhas, m = n�mero de colunas
    mat : vetor[0..9,0..9] de real       // Matriz para armazenar os elementos inseridos pelo usu�rio
    vet : vetor[0..9] de real            // Vetor para armazenar a soma de cada linha da matriz

Inicio

    // Entrada de dados: Pergunta ao usu�rio a quantidade de linhas e colunas da matriz
    escreva("Qual a quantidade de linhas da matriz? ")
    leia(n)                              // L� a quantidade de linhas da matriz
    escreva("Qual a quantidade de colunas da matriz? ")
    leia(m)                              // L� a quantidade de colunas da matriz

    // Preenchimento da matriz: Pede ao usu�rio para inserir os elementos linha por linha
    para i de 0 ate n-1 faca
        escreval("Digite os elementos da ",i+1," a. linha: ")  // Informa qual linha o usu�rio vai preencher
        para j de 0 ate m-1 faca
            leia(mat[i,j])                // L� cada elemento da matriz
        fimpara
    fimpara

    // Inicializa��o do vetor vet com 0: Esse vetor vai armazenar a soma das linhas
    para i de 0 ate n-1 faca
        vet[i] <- 0                         // Inicializa o valor da soma para a linha i como 0
        para j de 0 ate m-1 faca
            vet[i] <- vet[i] + mat[i,j]     // Soma todos os elementos da linha i da matriz
        fimpara
    fimpara

    // Exibi��o do vetor gerado: Mostra a soma de cada linha
    escreval("VETOR GERADO: ")
    para i de 0 ate n-1 faca
        escreval(vet[i]:3:1)               // Exibe o valor da soma de cada linha formatado com 3 casas e 1 casa decimal
    fimpara

Fimalgoritmo
