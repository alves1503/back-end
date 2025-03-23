Algoritmo "negativos-matrizes"

Var
    n, m, i, j : inteiro             // n = número de linhas, m = número de colunas
    mat : vetor[0..9,0..9] de inteiro // Matriz para armazenar os elementos inseridos pelo usuário

Inicio
    // Solicita ao usuário o número de linhas e colunas para a matriz
    escreva("Qual a quantidade de linhas da matriz? ")
    leia(n)
    escreva("Qual a quantidade de colunas da matriz? ")
    leia(m)

    // Preenchimento da matriz com os valores fornecidos pelo usuário
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            escreva("Elemento[",i," ,",j,"]: ")
            leia(mat[i,j])               // Lê o valor da posição mat[i,j] da matriz
        fimpara
    fimpara

    // Exibe os valores negativos da matriz
    escreval("VALORES NEGATIVOS: ")
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            se mat[i,j] < 0 entao
                escreval(mat[i,j])     // Se o valor for negativo, exibe ele na tela
            fimse
        fimpara
    fimpara

Fimalgoritmo






// Comentario CHATGPT SOBRE O CODIGO

//O código está bem estruturado e correto.Ele faz exatamente o que o enunciado pede, que é percorrer a matriz e exibir os valores negativos nela presentes. A principal melhoria seria, talvez, adicionar uma checagem para o caso de não haver valores negativos na matriz, e também alguns comentários explicativos para tornar o código mais legível.

