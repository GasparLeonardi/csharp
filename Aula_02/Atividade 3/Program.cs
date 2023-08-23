namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sbruto, noturno, extras, descontos;

            Console.WriteLine("Insira o seu Salário Bruto: ");
            sbruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o seu Adicional Noturno: ");
            noturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor das Horas Extras: ");
            extras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o Desconto: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nSeu Salário Líquido é de " + (sbruto + noturno + (extras * 5) - descontos));

        }
    }
}