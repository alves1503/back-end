Algoritmo "soma-vetor"




Var

          n,i,soma : inteiro
          total,media : real
          vet : vetor[0..9] de real





Inicio

          total <- 0
          soma <- 0
          
          escreva("Quantos numeros voce vai digitar? ")
          leia(n)
          
          
          para i de 0 ate n-1 faca
             soma <- soma + 1
             escreva("Digite um numero: ")
             leia(vet[i])
          fimpara
          
          
          escreva("VALORES = ")
          para i de 0 ate n-1 faca
             escreva(vet[i]:2:1,"  ")
             total <- vet[i] + total
          fimpara
          
          media <- total / soma
          escreval
          escreval("SOMA = ",total:4:2)
          escreva("MEDIA = ",media:4:2)
          
          
          

Fimalgoritmo