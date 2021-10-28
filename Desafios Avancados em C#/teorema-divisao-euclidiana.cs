// DESAFIO

// Você recebeu desafio de desenvolver um programa que calcule o quociente e o resto da divisão de dois números inteiros. 
// Não se esqueça que o quociente e o resto da divisão de um inteiro a por um inteiro não-nulo b são respectivamente os únicos inteiros q e r tais que:

// 0 ≤ r < |b|

// Se r < 0: r = r - |b|

// a = b × q + r

// q = ( a - r ) / b

// Caso você não saiba, 
// o teorema que garante a existência e a unicidade dos inteiros q e r é conhecido como ‘Teorema da Divisão Euclidiana’ ou ‘Algoritmo da Divisão’.

// |b| (Módulo / Valor absoluto): É o valor representado de forma positiva.

using System; 

class minhaClasse {
    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split();
        int a = int.Parse(valores[0]);
        int b = int.Parse(valores[1]);
        int q, r;

        q = a / b;
        r = a % b;
    
        if (r < 0) 
        {
            double  qd, rd = 0.0;
            rd = r + Math.Sqrt(b * b);
            qd = (a - rd) / b;
            Console.WriteLine("{0} {1}", qd, rd);
        } 
        else 
            Console.WriteLine("{0} {1}", q, r); 
    }
}