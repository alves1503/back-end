Algoritmo "MATRIZES-GERAL"





Var


          n,i,j,soma,linha,coluna : inteiro
          mat : vetor[0..9,0..9] de inteiro





Inicio


          escreva("Qual a ordem da matriz? ")
          leia(n)
          
          
          
          para i de 0 ate n-1 faca
               para j de 0 ate n-1 faca
                    escreva("Elemento [",i,",",j,"]: ")
                    leia(mat[i,j])
               fimpara
          fimpara
          
          
          soma <- 0
          
          para i de 0 ate n-1 faca
               para j de 0 ate n-1 faca
                    se mat[i,j] > 0 entao
                        soma <- soma + mat[i,j]
                    fimse
               fimpara
          fimpara
          
          
          escreval
          escreva("SOMA DOS POSITIVOS: ",soma)
          
          escreval
          escreva("Escolha uma linha: ")
          leia(linha)
          
          escreva("LINHA ESCOLHIDA: ")
          para j de 0 ate n-1 faca
               escreva(mat[linha,j]," ")
          fimpara
          
          escreval
          escreva("Escolha uma coluna: ")
          leia(coluna)
          escreva("COLUNA ESCOLHIDA: ")
          para i de 0 ate n-1 faca
               escreva(mat[i,coluna]," ")
          fimpara
          
          
          
          escreval
          escreva("DIAGONAL PRINCIPAL:")
          
          para i de 0 ate n-1 faca
               escreva(mat[i,i])
          fimpara
          
          
          
          para i de 0 ate n-1 faca
               para j de 0 ate n-1 faca
                    se mat[i,j] < 0 entao
                       mat[i,j] <- mat[i,j] * mat[i,j]
                    fimse
               fimpara
          fimpara
          
          escreval
          escreval("MATRIZ ALTERADA: ")
          

          para i de 0 ate n-1 faca
                 para j de 0 ate n-1 faca
                 escreva(mat[i,j])
                 fimpara
                 escreval
          fimpara
          
          





Fimalgoritmo