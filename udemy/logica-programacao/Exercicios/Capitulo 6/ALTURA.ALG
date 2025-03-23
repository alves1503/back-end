Algoritmo "altura"




Var


          n,i,cont : inteiro
          mediaA,somaA,porc : real
          vetA : vetor[0..9] de real
          vetI : vetor[0..9] de inteiro
          vetN : vetor[0..9] de caractere





Inicio
          escreva("Quantas pessoas serao digitadas? ")
          leia(n)
          
          
          somaA <- 0
          
          para i de 0 ate n-1 faca
             escreval("Dados da",i+1,"a pessoa: ")
             escreva("Nome: ")
             leia(vetN[i])
             escreva("Idade: ")
             leia(vetI[i])
             escreva("Altura: ")
             leia(vetA[i])
          fimpara
          
             para i de 0 ate n-1 faca
             somaA <- somaA + vetA[i]
             fimpara
          
          
          mediaA <- somaA / n
          
          escreval
          
          escreval("Altura média: ",mediaA:3:2 )
          
          cont <- 0
          
          
          para i de 0 ate n-1 faca
          
          se vetI[i] < 16 entao
            cont <- cont + 1
          fimse
          fimpara
          
          porc <- cont * 100 / n
          
          escreval("Pessoas com menos de 16 anos: ",porc,"%")
          
          para i de 0 ate n-1 faca
          se vetI[i] < 16 entao
            escreval(vetN[i])
          fimse
          fimpara
          




Fimalgoritmo