Algoritmo "soma-matrizes"

Var
    n, m, i, j : inteiro                      // n = n�mero de linhas, m = n�mero de colunas, i = �ndice de linha, j = �ndice de coluna
    a, b, c : vetor[0..9,0..9] de inteiro     // Matrizes A, B e C de tamanho m�ximo 10x10

Inicio
    // Solicita ao usu�rio o tamanho das matrizes
    escreva("Quantas linhas vai ter cada matriz? ")
    leia(n)
    escreva("Quantas colunas vai ter cada matriz? ")
    leia(m)

    // Preenchimento da matriz A
    escrevaL("Digite os valores da matriz A ")
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            escreva("Elemento [",i,",",j,"]: ")
            leia(a[i,j])  // L� e armazena os valores na matriz A
        fimpara
    fimpara

    // Preenchimento da matriz B
    escreval("Digite os valores da matriz B ")
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            escreva("Elemento [",i,",",j,"]: ")
            leia(b[i,j])  // L� e armazena os valores na matriz B
        fimpara
    fimpara

    // C�lculo da matriz soma C = A + B
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            c[i,j] <- a[i,j] + b[i,j]  // Soma os elementos correspondentes das matrizes A e B
        fimpara
    fimpara

    // Exibi��o da matriz soma
    escreval("MATRIZ SOMA: ")
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            escreva(c[i,j], " ")  // Exibe os elementos da matriz C na mesma linha
        fimpara
        escreval  // Pula para a pr�xima linha ap�s imprimir uma linha da matriz
    fimpara

Fimalgoritmo


// COMENTARIO CHATGPT


// C�digo bem estruturado: A l�gica est� correta e organizada, permitindo a leitura e soma de duas matrizes de qualquer tamanho dentro do limite definido.

// Funcionalidade correta: O programa l� duas matrizes A e B, calcula a soma e exibe o resultado corretamente na forma de uma matriz.

//Melhoria poss�vel: Adicionar uma valida��o para garantir que o usu�rio insira valores v�lidos para n e m (exemplo: n�o permitir n�meros negativos ou maiores que 10).