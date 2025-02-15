Algoritmo "troco"


Var


          preco,dinheiro,troco : real
          quantidade : inteiro


Inicio

          escreva ("Preço unitário do produto: ")
          leia (preco)
          
          escreva ("Quantidade comprada: ")
          leia (quantidade)
          
          escreva ("Dinheiro recebido: ")
          leia (dinheiro)

          
          troco <- dinheiro - preco * quantidade
          
          escreval ("Troco=",troco:8:2)

Fimalgoritmo