Algoritmo "coordenadas"



Var


          x,y : real


Inicio

          escreva("Valor de X: ")
          leia(x)
          escreva("Valor de Y: ")
          leia(y)
          
          
          se (x > 0) e (y > 0) entao
             escreval("Q1")
          senao
             se (x < 0) e (y > 0) entao
                escreval("Q2")
             senao
                se (x < 0) e (y < 0) entao
                   escreval("Q3")
                senao
                   se (x > 0) e (y < 0) entao
                      escreval("Q4")
                   senao
                      se (x = 0) e (y = 0) entao
                         escreval("ORIGEM")
                      senao
                            se x = 0 entao
                               escreval("EIXO Y")
                            senao
                               escreval("EIXO Y")
                                  fimse
                                fimse
                              fimse
                            fimse
                         fimse
                      fimse




Fimalgoritmo