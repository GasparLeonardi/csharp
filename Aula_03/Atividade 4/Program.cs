namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.WriteLine("Digite a primeira palavra");
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite a segunda palavra");
            palavra2 = Console.ReadLine();
            Console.WriteLine("Digite a terceira palavra");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null){
                if (palavra1.Equals("VERTEBRADO"))
                {
                    if (palavra2.Equals("AVE"))
                    {
                        if (palavra3.Equals("CARNIVORO"))
                        {
                            Console.WriteLine("ÁGUIA");
                        }
                        else { Console.WriteLine("POMBA"); }

                    }
                    else
                    {
                        if (palavra3.Equals("ONIVORO"))
                        {
                            Console.WriteLine("HOMEM");
                        }
                        else { Console.WriteLine("VACA"); }
                    }
                }
                else 
                {
                    if (palavra2.Equals("INSETO"))
                        {
                            if (palavra3.Equals("HEMATOFAGO"))
                            {
                                Console.WriteLine("PULGA");
                            }
                            else { Console.WriteLine("LAGARTA"); }

                        } else 
                    {
                        if (palavra3.Equals("HEMATOFAGO"))
                        {
                            Console.WriteLine("SANGUESSUGA");
                        }
                        else { Console.WriteLine("MINHOCA"); }

                    }
                } 
            
            
            }
        }
    }
}