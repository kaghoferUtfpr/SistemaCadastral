using SistemaCadastral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class SalvarArquivo
    {
        public static void ImprimirSalvar(List<Registro> lista)
        {
            //Cabeçalho
            String nomesist = "Sistema de Quinta";
            DateTime agora = DateTime.Now;
            Console.Write("Sisquinta");
            int n = Console.WindowWidth / 2 - (nomesist.Length / 2);
            Console.SetCursorPosition(n, 0);
            Console.Write(nomesist);
            int n1 = Console.WindowWidth - 10;
            Console.SetCursorPosition(n1, 0);
            Console.Write(agora.ToString("dd/MM/yyyy"));
            string str1 = new string('=', 120);
            Console.WriteLine(str1);

            Console.SetCursorPosition(0, 26);
            Console.WriteLine("<F9> Sair");

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

            Console.SetCursorPosition(0, 2);
            Console.WriteLine();
            string mensagemArq = "Insira o nome do arquivo sem a extenção: ";
            Console.Write(mensagemArq);
            string nomeArquivo = Console.ReadLine();

            Banco.Salvar(lista, nomeArquivo);

            Console.Clear();
            Principal.ImprimePrincipal(lista);


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
