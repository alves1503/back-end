Algoritmo "numeros_pares"



Var

          n,i,qtd : inteiro
          vet : vetor[0..99] de inteiro




Inicio

          escreva("Quantos numeros voce vai digitar? ")
          leia(n)
          
          para i de 0 ate n-1 faca
          escreva("Digite um numero: ")
          leia(vet[i])
          fimpara
          
           qtd <- 0
          escreval
          escreval("NUMEROS PARES: ")
          
          para i de 0 ate n-1 faca
             se vet[i] % 2 = 0 entao
               escreva(vet[i])
               qtd <- qtd + 1
             fimse
          fimpara
          escreval
          escreval
          escreva("QUANTIDADE DE PARES = ",qtd)




Fimalgoritmo