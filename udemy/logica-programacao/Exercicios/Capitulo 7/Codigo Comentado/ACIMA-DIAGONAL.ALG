Algoritmo "acima-diagonal"

Var
    n, i, j, soma : inteiro                      // n = ordem da matriz, i = �ndice de linha, j = �ndice de coluna, soma = soma dos elementos acima da diagonal
    mat : vetor[0..9,0..9] de inteiro            // Matriz quadrada de tamanho m�ximo 10x10

Inicio
    // Solicita ao usu�rio a ordem da matriz quadrada (n x n)
    escreva("Qual a ordem da matriz? ")
    leia(n)

    // Preenchimento da matriz
    para i de 0 ate n-1 faca
        para j de 0 ate n-1 faca
            escreva("Elemento [",i,",",j,"]: ")
            leia(mat[i,j])  // L� e armazena os valores na matriz
        fimpara
    fimpara

    // Inicializa a vari�vel soma com 0
    soma <- 0

    // Percorre os elementos acima da diagonal principal e realiza a soma
    para i de 0 ate n-1 faca
        para j de i+1 ate n-1 faca   // j come�a de i+1, garantindo que apenas os elementos acima da diagonal sejam somados
            soma <- soma + mat[i,j]  // Acumula a soma dos elementos acima da diagonal
        fimpara
    fimpara

    // Exibe o resultado da soma
    escreval
    escreva("SOMA DOS ELEMENTOS ACIMA DA DIAGONAL PRINCIPAL = ", soma)

Fimalgoritmo



// COMENTARIO CHATGPT? C�digo bem estruturado: A l�gica para somar os elementos acima da diagonal principal est� correta e otimizada.
//Execu��o correta: O c�digo percorre apenas os elementos necess�rios, evitando somar elementos da diagonal ou abaixo dela.
//Poss�vel melhoria: Adicionar valida��es para n (por exemplo, garantir que n esteja dentro do intervalo permitido).

