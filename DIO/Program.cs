using System;
using System.Collections.Generic;
using System.Linq;
using DIO.pasta;

class Program {
  
    static void Main(string[] args) {
    
    newclass n = new newclass();
    //List<int> lista = montaLista();
    List<int> valores = new List<int>();

    int QtdTestes = int.Parse(Console.ReadLine());
    
// numero de casos que serão testados
    for(int k=0; k < QtdTestes; k++) {
      
      //numero de esferas
      int num = int.Parse(Console.ReadLine());

      valores.Add(montaLista(num));
    }

    for(int k=0; k < valores.Count; k++) {
        Console.WriteLine(valores[k]);
    }

  }//

    //recebe o valor de esferas e devolve o valor que dessa
    static int montaLista(int num) {
      int cont = 0, cont2 = 0;
      List<int> lista = new List<int>();
      List<int> listaF = new List<int>();
      int valor=0;
      int index = 0;

      int qtdNum = num;
       cont =  1;

      for(int i=1; i < qtdNum; i++) {

        if (cont > 0) {
          valor = i;
         // lista.Add(valor);
         index++;
         if(index == qtdNum )
          break;
          cont--;
          
        }
        else if (cont == 0){
          cont2++;
          cont = (cont2 *2) + 1;
         // lista.Add(valor + 1);
         
          index = index + 2;
          if(index == qtdNum )
            break;
          valor = valor + 1;
          //lista.Add(valor + 1);
          
        }
       
        
      }

 
     return valor -1;
  }
}