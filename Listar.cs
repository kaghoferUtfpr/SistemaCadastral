using Microsoft.Win32;
using SistemaCadastral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class Listar
    {
        public static void ListarCadastros(List<Registro> lista)
        {
            //Cabeçalho
            String nome = "Sistema de Quinta";
            DateTime agora = DateTime.Now;
            Console.Write("Sisquinta");
            int n = Console.WindowWidth / 2 - (nome.Length / 2);
            Console.SetCursorPosition(n, 0);
            Console.Write(nome);
            int n1 = Console.WindowWidth - 10;
            Console.SetCursorPosition(n1, 0);
            Console.Write(agora.ToString("dd/MM/yyyy"));
            string str = new string('=', 120);
            Console.WriteLine(str);

            Console.WriteLine("Lista de Registros: ");

            lista.ForEach(x => Console.WriteLine(x));

            //Menu Opcoes
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("<F9> Sair");

            Console.SetCursorPosition(0, 27);
            string str1 = new string('=', 120);
            Console.WriteLine(str);
            string nome1 = "Usuário: Daniel";
            Console.SetCursorPosition(0, 28);
            Console.Write(nome);
            string term = "Terminal: UTFPR 01";
            int n2 = Console.WindowWidth / 2 - (term.Length / 2);
            Console.SetCursorPosition(n2, 28);
            Console.Write(term);
            string strNivel = "Nível: user";
            Console.SetCursorPosition(Console.WindowWidth - (strNivel.Length), 28);
            Console.Write(strNivel);
            Console.SetCursorPosition(0, 29);
            Console.Write("Msg: ");
            
            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {

                    case ConsoleKey.F9:
                        Console.Clear();
                        Principal.ImprimePrincipal(lista);
                        break;
                }
            }



        }
    }
}
