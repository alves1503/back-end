Algoritmo "MATRIZES-GERAL"

Var
    n, i, j, soma, linha, coluna : inteiro      // n = ordem da matriz, soma = soma dos positivos, linha e coluna escolhidas pelo usuário
    mat : vetor[0..9,0..9] de inteiro           // Matriz quadrada de tamanho máximo 10x10

Inicio
    // Solicita ao usuário a ordem da matriz quadrada (n x n)
    escreva("Qual a ordem da matriz? ")
    leia(n)

    // Preenchimento da matriz
    para i de 0 ate n-1 faca
        para j de 0 ate n-1 faca
            escreva("Elemento [",i,",",j,"]: ")
            leia(mat[i,j])  // Lê e armazena os valores na matriz
        fimpara
    fimpara

    // Inicializa a soma dos valores positivos
    soma <- 0

    // Soma apenas os valores positivos da matriz
    para i de 0 ate n-1 faca
        para j de 0 ate n-1 faca
            se mat[i,j] > 0 entao
                soma <- soma + mat[i,j]  // Acumula os valores positivos
            fimse
        fimpara
    fimpara

    // Exibe a soma dos valores positivos
    escreval
    escreva("SOMA DOS POSITIVOS: ", soma)

    // Solicita ao usuário uma linha para exibição
    escreval
    escreva("Escolha uma linha: ")
    leia(linha)

    // Exibe os elementos da linha escolhida
    escreva("LINHA ESCOLHIDA: ")
    para j de 0 ate n-1 faca
        escreva(mat[linha, j], " ")
    fimpara

    // Solicita ao usuário uma coluna para exibição
    escreval
    escreva("Escolha uma coluna: ")
    leia(coluna)

    // Exibe os elementos da coluna escolhida
    escreva("COLUNA ESCOLHIDA: ")
    para i de 0 ate n-1 faca
        escreva(mat[i, coluna], " ")
    fimpara

    // Exibe os elementos da diagonal principal
    escreval
    escreva("DIAGONAL PRINCIPAL: ")
    para i de 0 ate n-1 faca
        escreva(mat[i, i], " ")
    fimpara

    // Substitui os valores negativos da matriz pelos seus quadrados
    para i de 0 ate n-1 faca
        para j de 0 ate n-1 faca
            se mat[i, j] < 0 entao
                mat[i, j] <- mat[i, j] * mat[i, j]  // Eleva ao quadrado os valores negativos
            fimse
        fimpara
    fimpara

    // Exibe a matriz alterada após as modificações
    escreval
    escreval("MATRIZ ALTERADA: ")

    para i de 0 ate n-1 faca
        para j de 0 ate n-1 faca
            escreva(mat[i, j], " ")
        fimpara
        escreval
    fimpara

Fimalgoritmo



// COMENTARIO CHATGPT

//Código bem estruturado e funcional, cobrindo várias operações em uma matriz:

//Soma de valores positivos.
//Exibição de uma linha e uma coluna escolhidas pelo usuário.
//Impressão da diagonal principal.
//Transformação dos valores negativos em seus quadrados.
//Lógica correta: O código percorre a matriz de forma eficiente e realiza todas as operações conforme esperado.
//Possível melhoria:
//Validação de entrada: Verificar se linha e coluna inseridas pelo usuário estão dentro do intervalo válido (0 a n-1).