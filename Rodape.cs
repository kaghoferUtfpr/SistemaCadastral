using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public class Rodape
    {
        public static void RodapePrincipal(string msg)
        {
            Console.SetCursorPosition(0, 27);
            string str = new string('=', 120);
            Console.WriteLine(str);
            string nome = "Usuário: Daniel";
            Console.SetCursorPosition(0, 28);
            Console.Write(nome);
            string term = "Terminal: UTFPR 01";
            int n = Console.WindowWidth / 2 - (term.Length / 2);
            Console.SetCursorPosition(n, 28);
            Console.Write(term);
            string strNivel = "Nível: user";
            Console.SetCursorPosition(Console.WindowWidth - (strNivel.Length), 28);
            Console.Write(strNivel);
            Console.SetCursorPosition(0, 29);
            Console.Write("Msg: "+msg);
        }

        public static void RodapeCadastrar()
        {
            Console.SetCursorPosition(0, 27);
            string str = new string('=', 120);
            Console.WriteLine(str);
            string nome = "Usuário: Daniel";
            Console.SetCursorPosition(0, 28);
            Console.Write(nome);
            string term = "Terminal: UTFPR 01";
            int n = Console.WindowWidth / 2 - (term.Length / 2);
            Console.SetCursorPosition(n, 28);
            Console.Write(term);
            string strNivel = "Nível: user";
            Console.SetCursorPosition(Console.WindowWidth - (strNivel.Length), 28);
            Console.Write(strNivel);
            Console.SetCursorPosition(0, 29);
            Console.Write("Msg: ");
            Console.SetCursorPosition(0, 3);
        }
    }
}
