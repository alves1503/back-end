Algoritmo "tempo de jogo"



Var

          hora1, hora2,duracao : inteiro




Inicio

          escreva("Hora inicial: ")
          leia(hora1)
          
          escreva("Hora final: ")
          leia(hora2)
          
          se hora1 < hora2 entao
             duracao <- hora2 - hora1
          senao
             duracao <- 24 - hora1 + hora2
          fimse
          
          escreval("O JOGO DUROU ",duracao)
          
          




Fimalgoritmo