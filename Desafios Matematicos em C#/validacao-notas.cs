// DESAFIO

// O calendário escolar está passando bem rápido, devido a isso, as professoras de uma escola estão com dificuldade para calcular as notas dos alunos. 
// Visando em resolver a situação, a diretora da escola contratou você para 
// desenvolver um programa que leia as notas da primeira e da segunda avaliação de um aluno. Calcule e imprima a média semestral.

// O programa só aceitará notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

// No final deve ser impressa a mensagem “novo calculo (1-sim 2-nao)”, 
// solicitando as professoras que informe um código (1 ou 2) indicando se ele deseja ou não executar o algoritmo novamente, 
// (aceitar apenas os código 1 ou 2). Se for informado o código 1 deve ser repetida a execução de todo o programa para permitir um novo cálculo, 
// caso contrário o programa deve ser encerrado.

using System;

public class Desafio {
  public static void Main() {

    double nota1, nota2, flag = 1;
    while (flag == 1) {
        
        nota1 = double.Parse(Console.ReadLine());
        while (nota1 > 10 || nota1 < 0) 
        {
            Console.WriteLine("nota invalida");
            nota1 = double.Parse(Console.ReadLine());
        }
        
        nota2 = double.Parse(Console.ReadLine());
        while (nota2 > 10 || nota2 < 0) 
        {
            Console.WriteLine("nota invalida");
            nota2 = double.Parse(Console.ReadLine());
        }
        
        double media = (nota1 + nota2) / 2;
        Console.WriteLine("media = " + media.ToString("N2"));
        
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        flag = int.Parse(Console.ReadLine());
        while (flag != 1 && flag != 2) 
        {
            Console.WriteLine("novo calculo (1-sim 2-nao)");
            flag = int.Parse(Console.ReadLine());
        }
    }
  }
}