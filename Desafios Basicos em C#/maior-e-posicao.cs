// DESAFIO - MAIOR E POSICAO

// Você recebeu o desafio de ler 100 valores inteiros. 
// Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

using System; 

class TESTE {

    static void Main(string[] args) { 

            int n;
            int maior = 0;
            int posicao = 0;
            for(int i = 1; i <= 100 ; i++)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > maior)
                {
                    maior = n;
                    posicao = i;     //Complete o código nos espaços em branco
                } 
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);

    }

}