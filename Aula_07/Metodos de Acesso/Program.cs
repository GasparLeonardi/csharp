using Metodos_de_Acesso.Namespace01;

namespace Metodos_de_Acesso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodoPublico();
            MetodoInternal();
            MetodoProtected();
            MetodoPrivado();

            Classe01.MetodoPublico();
            Classe01.MetodoInternal();
            //Classe01.MetodoProtected();
           // Classe01.MetodoPrivado();

            Classe02.MetodoPublico();
            Classe02.MetodoInternal();
           // Classe02.MetodoProtected();
           // Classe02.MetodoPrivado();
        }

        public static void MetodoPublico()
        {
            Console.WriteLine("Método Publico - Classe Program");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe Program");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protegido - Classe Program");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe Program");
        }
    }
}