Algoritmo "negativos-matrizes"

Var
    n, m, i, j : inteiro             // n = n�mero de linhas, m = n�mero de colunas
    mat : vetor[0..9,0..9] de inteiro // Matriz para armazenar os elementos inseridos pelo usu�rio

Inicio
    // Solicita ao usu�rio o n�mero de linhas e colunas para a matriz
    escreva("Qual a quantidade de linhas da matriz? ")
    leia(n)
    escreva("Qual a quantidade de colunas da matriz? ")
    leia(m)

    // Preenchimento da matriz com os valores fornecidos pelo usu�rio
    para i de 0 ate n-1 faca
        para j de 0 ate m-1 faca
            escreva("Elemento[",i," ,",j,"]: ")
            leia(mat[i,j])               // L� o valor da posi��o mat[i,j] da matriz
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

//O c�digo est� bem estruturado e correto.Ele faz exatamente o que o enunciado pede, que � percorrer a matriz e exibir os valores negativos nela presentes. A principal melhoria seria, talvez, adicionar uma checagem para o caso de n�o haver valores negativos na matriz, e tamb�m alguns coment�rios explicativos para tornar o c�digo mais leg�vel.

