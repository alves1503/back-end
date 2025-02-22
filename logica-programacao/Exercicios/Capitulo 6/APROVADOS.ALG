Algoritmo "aprovados"




Var

          n,i : inteiro
          vet1,vet2,soma,media : vetor[0..9] de real
          nome : vetor[0..9] de caractere




Inicio


          escreva("Quantos alunos serao digitados? ")
          leia(n)
          
          
          para i de 0 ate n-1 faca
             escreval("Digite nome, primeira e segunda nota do",i+1,"o aluno: ")
             leia(nome[i])
             leia(vet1[i])
             leia(vet2[i])
             soma[i]<- vet1[i] + vet2[i]
             media[i] <- soma[i] / 2
          fimpara
          
          

          escreval
          escreval("Alunos aprovados: ")
          para i de 0 ate n-1 faca
              se media[i] >= 6 entao
              escreval(nome[i])
              fimse
          fimpara



Fimalgoritmo