// DESAFIO

// No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo. 
// Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.
// Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.
// Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

using System;
using System.Collections.Generic;

namespace DesafioMundoOz
{
    class Program
    {
        static void Main(string[] args)
        {
            var joias = new List<string>();
            string joia = "";
            int cont = 0;

            do
            {
              joia = Console.ReadLine();
                if (!joias.Contains(joia))
                {
                    joias.Add(joia);
                    cont++;
                }
            } while (!string.IsNullOrEmpty(joia));

            Console.WriteLine(cont - 1);
        }
    }
}