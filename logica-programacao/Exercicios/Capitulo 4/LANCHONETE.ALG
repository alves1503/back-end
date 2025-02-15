Algoritmo "lanchonete"



Var
          codigo,qtd : inteiro
          total : real


Inicio

          escreva("Codigo do produto comprado: ")
          leia(codigo)
          escreva("Quantidade comprada: ")
          leia(qtd)
          
          escolha codigo
          caso 1
             total <- 5 * qtd
          caso 2
             total <- 3.5 * qtd
          caso 3
             total <- 4.8 * qtd
          caso 4
             total <- 8.90 * qtd
          caso 5
             total <- 7.32 * qtd
          fimescolha
          
          escreval("Valor a pagar: ",total:4:2)
          



Fimalgoritmo