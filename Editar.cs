using SistemaCadastral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class Editar
    {

        private static string l2 = "Nome........:";
        private static string l3 = "RG..........:";
        private static string l4 = "CPF.........:";
        private static string l5 = "Habilitação.:";
        private static string l6 = "Tit. Eleitor:";
        public static void EditarRegistro(List<Registro> registros, int posicao)
        {
            Registro registro = new Registro();
            registro = registros.ElementAt(posicao);

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

            Console.WriteLine(l2 + $" {registros.ElementAt(posicao).Nome}");
            Console.WriteLine(l3 + $" {registros.ElementAt(posicao).RG}");
            Console.WriteLine(l4 + $" {registros.ElementAt(posicao).CPF}");
            Console.WriteLine(l5 + $" {registros.ElementAt(posicao).Habilitacao}");
            Console.WriteLine(l6 + $" {registros.ElementAt(posicao).Titulo}");

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


            Console.SetCursorPosition(l2.Length + 1, 2);
            registros.ElementAt(posicao).Nome = Console.ReadLine().Trim();
            Console.SetCursorPosition(l2.Length + 1, 3);
            registros.ElementAt(posicao).RG = Console.ReadLine().Trim();
            Console.SetCursorPosition(l2.Length + 1, 4);
            registros.ElementAt(posicao).CPF = Console.ReadLine().Trim();
            Console.SetCursorPosition(l2.Length + 1, 5);
            registros.ElementAt(posicao).Habilitacao = Console.ReadLine().Trim();
            Console.SetCursorPosition(l2.Length + 1, 6);
            registros.ElementAt(posicao).Titulo = Console.ReadLine().Trim();

            Console.SetCursorPosition(l2.Length, 2);

            Console.Clear();
            Cadastrar.ListarRegistros(registros, posicao);
        }
             


    }
}

