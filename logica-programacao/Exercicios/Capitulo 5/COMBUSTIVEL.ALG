Algoritmo "combustivel"



Var


          x,alcool,gasolina,diesel,soma : inteiro



Inicio
          soma <- 0
          alcool <- 0
          gasolina <- 0
          diesel <- 0
          
          escreva("Informe um codigo (1, 2, 3) ou 4 para parar: ")
          leia(x)

          enquanto x <> 4 faca

             escolha x
             caso 1
                alcool <- alcool + 1
             caso 2
                gasolina <- gasolina + 1
                
             caso 3
                diesel <- diesel + 1
             fimescolha

          escreva("Informe um codigo (1, 2, 3) ou 4 para parar: ")
          leia(x)
         fimenquanto
          
          escreval("MUITO OBRIGADO")
          escreval("Alcool:",alcool)
          escreval("Gasolina:",gasolina)
          escreval("Diesel:",diesel)
          







Fimalgoritmo