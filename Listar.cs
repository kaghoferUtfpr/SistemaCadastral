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

            Console.SetCursorPosition(0, 4);
            lista.ForEach(x =>
            {
                Console.SetCursorPosition(0, Console.GetCursorPosition().Top);
                Console.Write($"Nome: {x.Nome}");
                Console.SetCursorPosition(40, Console.GetCursorPosition().Top);
                Console.Write($"CPF: {x.CPF}");
                Console.SetCursorPosition(60, Console.GetCursorPosition().Top);
                Console.Write($"RG: {x.RG}");
                Console.SetCursorPosition(80, Console.GetCursorPosition().Top);
                Console.Write($"Habilitação: {x.Habilitacao}");
                Console.SetCursorPosition(100, Console.GetCursorPosition().Top);
                Console.Write($"Título: {x.Titulo}");
                Console.WriteLine();
            });




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
