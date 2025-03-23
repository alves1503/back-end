Algoritmo "validacao-de-nota"



Var


          pri,seg,media : real

Inicio


          escreva("Digite a primeira nota: ")
          leia(pri)
          enquanto pri < 0 faca
            escreva("Valor invalido! Tente novamente:")
            leia(pri)
          fimenquanto
          
          escreva("Digite a segunda nota: ")
          leia(seg)
          enquanto seg > 10 faca
            escreva("Valor invalido! Tente novamente:")
            leia(seg)
          fimenquanto
          
          media <- (pri + seg) / 2
          
          
          escreva("MEDIA = ",media:3:2)

          




          
          

Fimalgoritmo