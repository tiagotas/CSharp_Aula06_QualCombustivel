using System;

namespace Aula06_QualCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Sabendo que o etanol rende 70% comparado a gasolina, 
             * qual combustivel um usuário deve colocar no tanque?
             * Para resolver:
             * 1) Identificar variáveis
             * 2) Identificar regra de negócio:
             *    - Preço do etanol deve ser até 70% do preço da gasolina.
             */
            double preco_gasolina = 0.0;
            double preco_etanol = 0.0;

            Console.WriteLine("Qual é o preço da Gasolina?");
            preco_gasolina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qúal é o preço do etanol?");
            preco_etanol = Convert.ToDouble(Console.ReadLine());

            /**
             * preço etanol = 3,00
             * preço gasolina = 4.50
             * 
             * 70% do preço da gasolina = 3,15
             */

            double setenta_porcento_gasolina = preco_gasolina * 0.7;

            Console.WriteLine("70% do Preço da Gasolina = " + setenta_porcento_gasolina);


            if (preco_etanol > setenta_porcento_gasolina)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Compensa a Gasolina");
            } else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Compensa o etanol");
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
