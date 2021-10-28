// DESAFIO 

// O microblog Twitter é conhecido por limitar as postagens em 140 caracteres. 
// Conferir se um texto vai caber em um tuíte é sua tarefa.

using System; 

class minhaClasse {

    static void Main(string[] args) 
    { 

      string v = Console.ReadLine();
      char[] arr = v.ToCharArray();
      if(arr.Length <= 140) 
          Console.WriteLine("TWEET");
      else
          Console.WriteLine("MUTE");

    }

}