# LP1 Lamp Puzzle - Report

## Pedro Coutinho - a21905323
## Rodrigo Marques - a21802593
* * Pedro Coutinho:
    * Lógica base do game loop.
    * Classe PrintHandler.
    * Organização de código.
    * Optimização de código.
    * Documentação XML em Program.
    * Fluxograma.
    * Relatório melhorias.

  * Rodrigo Marques:
    * Classe InputHandler.
    * Melhoria da classe PrintHandler.
    * Ligação entre Program com InputHandler e PrintHandler.
    * Documentação XML nas classes Input Hadler e Print Handler.
    * Relatório inicial.

## Git : https://github.com/Pedro-Coutinho/Lp1Project

## Arquitetura da solução:
  O programa começa ao imprimir a regras do jogo e espera por um input do jogador
  para confirmar que o mesmo se encontra pronto para jogar. Após o obter entra num
  for durante 6 turnos no máximo, em cada ciclo do for, é pedido um input ao jogador
  através da classe InputHandler, esse input é avaliado dentro da mesma e o programa 
  só procede após obter um input for válido. De seguida entra num switch onde
  decide que botão clicar e faz a lógica desse botão. Depois dá print das lâmpadas
  e verifica se já estão todas ligadas ou não, se tiverem sai do ciclo for antecipadamente. Após 6 movimentos o ciclo for acaba e o programa dá print da
  resolução do jogo seja esta vitória ou não.

  

---
## Fluxograma:
  ---
  ![fluxograma](Fluxograma.jpg)
