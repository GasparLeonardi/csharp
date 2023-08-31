using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_de_Acesso.Namespace01
{
    public class Classe02
    {
        public static void MetodoPublico()
        {
            Console.WriteLine("Método Publico - Classe Classe 02");
        }

        internal static void MetodoInternal()
        {
            Console.WriteLine("Método Internal - Classe 02");
        }
        protected static void MetodoProtected()
        {
            Console.WriteLine("Método Protegido - Classe 02");
        }
        private static void MetodoPrivado()
        {
            Console.WriteLine("Método Privado - Classe 02");
        }
    }
}
