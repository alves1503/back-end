Algoritmo "quadrante"




Var

          x,y : real



Inicio


          escreval("Digite os valores das coordenadas X e Y: ")
          leia(x)
          leia(y)


            enquanto (x <> 0) e (y <> 0) faca
            se (X > 0 ) e (y > 0) entao
               escreval("QUADRANTE Q1")
               leia(x)
               leia(y)
          senao
            se (x > 0)  e (y < 0) entao
               escreval("QUADRANTE Q4")
               leia(x)
               leia(y)
          senao
            se (x < 0) e (y < 0) entao
               escreval("QUADRANTE Q3")
               leia(x)
               leia(y)
          senao
             se (x < 0) e (y > 0) entao
             escreval("QUADRANTE Q2")
             leia(x)
             leia(y)
          
                   fimse
                 fimse
               fimse
             fimse
             fimenquanto




Fimalgoritmo