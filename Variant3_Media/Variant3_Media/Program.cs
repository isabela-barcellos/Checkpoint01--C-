// Projeto de Avaliação (Revisado) - Variante 3: Cálculo de média de três notas
// Este programa deve solicitar o nome do estudante e três notas, calcular e exibir a média.
// Vários erros foram introduzidos na declaração dos tipos, controle de loop e operações aritméticas.
using System;

namespace MyApp {// adicionando o namespace ao código
    internal class Program // adicionando o internal na classe
    {

        static void Main(string[] args) //adicionando o string[] args que não tinha
        {
            String nome; //declarando a variavel nome

            Console.WriteLine("Digite o nome do estudante:");
            nome = Console.ReadLine();// mudei o tipo da variavel nome

            double soma = 0;

            for (int i = 1; i < 4; i++) // mudando a condição para i menor que 4, para o i pedir a nota 1
            {
                String nota;

                Console.WriteLine("Digite a nota " + i + ":"); // retirando o i para não mostrar como a nota começa
                nota = Console.ReadLine();

                soma = soma + double.Parse(nota);// transformando a string em um int para realizar o calculo 
               
            }

            double media = soma / 3; //Corrigindo para dividir por 3 
            Console.WriteLine("A média do estudante " + nome + " é " + media);
        }
    }
}
