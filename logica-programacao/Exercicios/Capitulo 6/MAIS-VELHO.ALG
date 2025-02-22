Algoritmo "mais-velho"




Var

          n,i,maior : inteiro
          idade : vetor[0..9] de inteiro
          nome : vetor[0..9] de caractere
          nomeV : caractere





Inicio


          escreva("Quantas pessoas voce vai digitar? ")
          leia(n)
          
          
          para i de 0 ate n-1 faca

              escreval("Dados da ",i+1,"a pessoa: ")
              escreva("Nome: ")
              leia(nome[i])
              escreva("Idade: ")
              leia(idade[i])
          fimpara
          
          
          
          maior <- idade[0]
          nomeV <- nome[0]



          para i de 0 ate n-1 faca

             se idade[i] > maior entao
                maior <- idade[i]
                nomeV <- nome[i]
             fimse
          fimpara
          
          escreval
          escreva("PESSOA MAIS VELHA: ",nomeV)
          
          
          
          
          
          





Fimalgoritmo