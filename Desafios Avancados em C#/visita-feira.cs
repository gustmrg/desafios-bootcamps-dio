// DESAFIO
// Você está na feira com a sua sacola e parou em uma banca. 
// O feirante lhe entregou pimentões amarelos e vermelhos. 
// Agora iremos somar os pimetões amarelos e vermelhos para descobrir o total de pimentões na sacola.  
// Você receberá 2 inteiros que devem ser lidos e armazenados nas variáveis A (pimentões amarelos) e B (pimentões vermelhos). 
// Faça a soma de A e B atribuindo o seu resultado na variável X (total de pimentões). Apresente X como descrito na mensagem de exemplo abaixo. 
// Não apresente outra mensagem além da mensagem especificada.

using System; 

class minhaClasse{
    static void Main(string[] args) { 

            int a, b, x;
            string[] valores = Console.ReadLine().Split();
            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);

            x = a + b; 

            Console.WriteLine("X = {0}", x);

    }
}