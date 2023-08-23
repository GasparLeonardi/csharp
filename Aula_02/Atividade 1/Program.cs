namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono;
            Console.WriteLine("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o abono: ");
            abono = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine($"{salario} + {abono} = " + (salario + abono));
            Console.WriteLine("O seu salario somado ao abono é " + (salario + abono));
           
        }
    }
}