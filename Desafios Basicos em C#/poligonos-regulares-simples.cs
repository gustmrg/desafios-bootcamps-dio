// DESAFIO - POLIGONOS REGULARES SIMPLES

// Na geometria Euclidiana, um polígono regular é um polígono em que todos os ângulos são iguais e todos os lados tem o mesmo comprimento. 
// Um polígono simples é aquele cujos segmentos de reta não se interceptam. Abaixo pode-se ver vários mosaicos feitos por polígonos regulares.

// Você deve escrever um programa que, dados o número e o comprimento dos lados de um polígono regular, mostre seu perímetro.


using System; 

class Problem {

    static void Main(string[] args) { 

        string[] v = Console.ReadLine().Split();
            
        int N = Int32.Parse(v[0]);
        int L = Int32.Parse(v[1]);
        int perimetro = N * L;
        Console.WriteLine(perimetro);
    }

}