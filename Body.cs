using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public class Body
    {
        public static void TelaCadastro()
        {
            string l1 = "Registro....: 1 de <N>";
            string l2 = "Nome........:";
            string l3 = "RG..........:";
            string l4 = "CPF.........:";
            string l5 = "Habilitação.:";
            string l6 = "Tit. Eleitor:";
            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);
            Console.WriteLine(l6);

            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F9:
                    Environment.Exit(0);
                    break;
                default:
                    key = Console.ReadKey(true).Key;
                    break;
            }
        }

    }
}
