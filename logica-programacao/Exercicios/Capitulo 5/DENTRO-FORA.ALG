Algoritmo "dentro-fora"




Var

          n,i,x,soma1,soma2 : inteiro




Inicio
          soma1 <- 0
          soma2 <- 0
          
          escreva("Quantos numeros voce vai digitar? ")
          leia(n)
          
          para i de 1 ate n faca
          escreva("Digite um numero: ")
          leia(x)
               se (x >= 10) e (x <= 20) entao
                  soma1 <- soma1 + 1
               senao
                  soma2 <- soma2 + 1
            fimse
          fimpara
          
          escreval(soma1," Dentro")
          escreval(soma2," Fora")
          
          





Fimalgoritmo