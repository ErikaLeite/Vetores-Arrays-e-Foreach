using System;

namespace Vetores_Arrays_e_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Array e Vetor");

            //array
            string[] nomes = new string [3];
            int[] idades = new int [3];

            for (var cont = 0; cont < 3; cont++)
            {
                Console.WriteLine($"Digite o {cont+1}º nome");
                nomes[cont] = Console.ReadLine();
                Console.WriteLine($"Digite a {cont+1}º idade");
                idades[cont] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Nomes e Idades Cadastrados:");

            for (var cont = 0; cont < 3; cont++)
            {
                Console.WriteLine(nomes[cont]);
                Console.WriteLine(idades[cont]);
            }
            
        }
    }
}
