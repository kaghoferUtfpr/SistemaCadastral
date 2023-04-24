using Microsoft.Win32;
using SistemaCadastral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class Pesquisar
    {
        public static void PesquisarRegistro(List<Registro> lista)
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

            Console.SetCursorPosition(0, 3);

            //Rodape
            string msg = "";
            Console.SetCursorPosition(0, 27);
            string str2 = new string('=', 120);
            Console.WriteLine(str2);
            string nomeuser = "Usuário: Daniel";
            Console.SetCursorPosition(0, 28);
            Console.Write(nomeuser);
            string term = "Terminal: UTFPR 01";
            int n2 = Console.WindowWidth / 2 - (term.Length / 2);
            Console.SetCursorPosition(n2, 28);
            Console.Write(term);
            string strNivel = "Nível: user";
            Console.SetCursorPosition(Console.WindowWidth - (strNivel.Length), 28);
            Console.Write(strNivel);
            Console.SetCursorPosition(0, 29);
            Console.Write("Msg: " + msg);

            Console.SetCursorPosition(0, 3);
            string l1 = "Digite o CPF: ";
            Console.Write(l1);
            Console.SetCursorPosition(l1.Length, 3);
            string cpf = Console.ReadLine();

            Registro registro = new Registro();

            registro = lista.Where(f => f.CPF.Equals(cpf)).FirstOrDefault();

            if (registro != null)
            {
                Console.WriteLine(registro);
                Console.WriteLine("\nTeclar F9 para voltar");
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
            else
            {
                Console.WriteLine("Registro não encontrado");
                Console.WriteLine("\nTeclar F9 para voltar");
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
}
