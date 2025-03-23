Algoritmo "diagonal-negativos"




Var


          N,i,j,contagem : inteiro
          mat : vetor [0..9,0..9] de inteiro




Inicio


          escreva("Qual a ordem da matriz? ")
          leia(N)
          
          contagem <- 0
          para i de 0 ate N-1 faca
              para j de 0 ate N-1 faca
                 escreva("Elemento [", i, ",", j, "]: ")
                 leia(mat[i,j])
              fimpara
          fimpara
          
          escreval
          escreval("DIAGONAL PRINCIPAL: ")
          
          para i de 0 ate N-1 faca
                  escreva(mat[i,i])
          fimpara
          
          
          para i de 0 ate N-1 faca
               para j de 0 ate N-1 faca
                  se mat[i,j] < 0 entao
                  contagem <- contagem + 1
                  fimse
               fimpara
          fimpara
          
          
          escreval
          escreva("QUANTIDADE DE NEGATIVOS = ",contagem)
          




Fimalgoritmo