Algoritmo "media-idade"



Var

          idade,contador,soma : inteiro
          media : real



Inicio
           soma <- 0
           contador <- 0

          escreval("Digite as idades: ")
          leia(idade)
          
          
             enquanto idade >= 0 faca
             
                soma <- soma + idade
                contador <- contador + 1
                
                leia(idade)
             fimenquanto
             
             se contador = 0 entao
             escreval("IMPOSSIVEL CALCULAR!")
          senao
             media <- soma / contador
          escreval("MEDIA = ", media:4:2)
          fimse






Fimalgoritmo