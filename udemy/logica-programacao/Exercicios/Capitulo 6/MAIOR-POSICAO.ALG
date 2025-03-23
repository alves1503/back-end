Algoritmo "maior-posicao"




Var

          n,i,soma : inteiro
          maior : real
          vet : vetor[0..9] de real



Inicio

          escreva("Quanto numeros voce vai digitar? ")
          leia(n)
          
          para i de 0 ate n-1 faca
          escreva("Digite um numero: ")
          leia(vet[i])
          fimpara
          
          maior <- vet[1]
          
          para i de 0 ate n-1 faca
            se vet[i] > maior entao
              maior <- vet[i]
              soma <- i
            fimse
          fimpara
          
          escreval
          escreval("MAIOR VALOR = ",maior)
          escreva("POSICAO DO MAIOR VALOR = ",soma)





Fimalgoritmo