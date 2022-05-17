// DESAFIO - MEDIA

// Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. 
// A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. 
// Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.


using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, mediaP;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            mediaP = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);
            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.0"));
            Console.ReadKey();
        }
    }
}