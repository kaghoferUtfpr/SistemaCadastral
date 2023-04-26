using SistemaCadastral;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class Carregar
    {
        public static void CarregarDoBanco()
        {
            string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dat");
            string[] nomesArquivos = new string[arquivos.Length];
            for (int i = 0; i < arquivos.Length; i++)
            {
                nomesArquivos[i] = Path.GetFileNameWithoutExtension(arquivos[i]);
            }
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

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("Lista de arquivos existentes: ");

            foreach (var linha in nomesArquivos) Console.WriteLine(linha);

            Console.SetCursorPosition(0, 2);
            Console.WriteLine();
            string mensagemArq = "Insira o nome do arquivo sem a extenção ou digite sair para voltar ao menu principal: ";
            Console.Write(mensagemArq);
            string nomeArquivo = Console.ReadLine().ToLower();
            bool existe = nomesArquivos.Where(f => f.Equals(nomeArquivo)).Any();

            while (!existe || nomeArquivo.Equals("sair"))
            {
                msg = nomeArquivo + " não existe";
                Console.SetCursorPosition(0, 29);
                Console.Write("Msg: " + msg);
                Console.SetCursorPosition(mensagemArq.Length, 3);
                Console.Write("                                     ");
                Console.SetCursorPosition(mensagemArq.Length, 3);
                nomeArquivo = Console.ReadLine().ToLower();
                existe = nomesArquivos.Where(f => f.Equals(nomeArquivo)).Any();
            }

            if (nomeArquivo.Equals("sair"))
            {
                Console.Clear();
                PrincipalVazia.ImprimePrincipalVazia(null);
            }

            while (!nomeArquivo.Contains(nomeArquivo))
            {

                Console.SetCursorPosition(mensagemArq.Length, 3);
                Console.Write(new string(' ', 20));
                Console.SetCursorPosition(mensagemArq.Length, 3);
                nomeArquivo = Console.ReadLine();
                if (nomeArquivo.Equals("sair"))
                {
                    Console.Clear();
                    PrincipalVazia.ImprimePrincipalVazia(null);
                }
                msg = nomeArquivo + " não existe                                           ";
                Console.SetCursorPosition(0, 29);
                Console.Write("Msg: " + msg);
                Task.Delay(2000).Wait();
                Console.SetCursorPosition(0, 29);
                Console.Write("Msg:                                                       ");
            }

            List<Registro> lista = Banco.BuscarRegistros(nomeArquivo);

            Console.Clear();
            Principal.ImprimePrincipal(lista);
        }
    }
}
