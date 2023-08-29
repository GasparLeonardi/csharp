using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNum = new HashSet<int>()
            {
            };
            int num;


            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Digite 10 valores inteiros: ");
                num = Convert.ToInt32(Console.ReadLine());
                setNum.Add(num);
            }

            Console.WriteLine($"\nListar dados do HashSet:");
            foreach (var numero in setNum)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
