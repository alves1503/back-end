Algoritmo "soma-vetores"




Var


          n,i : inteiro
          vetA,vetB,vetC : vetor[0..9] de inteiro





Inicio

          escreva("Quantos valores vai ter cada vetor? ")
          leia(n)
          
          
          para i de 0 ate n-1 faca
          escreva("Digite os valores do vetor A: ")
          leia(vetA[i])
          fimpara
          
          para i de 0 ate n-1 faca
          escreva("Digite os valores do vetor B: ")
          leia(vetB[i])
          fimpara
          
          
          escreval

          escreval("VETOR RESULTANTE: ")
          
          para i de 0 ate n-1 faca
          vetC[i] <- vetA[i] + vetB[i]
          escreval(vetC[i])
          fimpara





Fimalgoritmo