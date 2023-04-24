using Microsoft.VisualBasic;
using Microsoft.Win32;
using SistemaCadastral;
using SistemaCadastral.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    public static class Cadastrar
    {
        private static string linhaRegistro = string.Empty;
        private static int? pos;
        private static string l1 = $"Registro....: {linhaRegistro}";
        private static string l2 = "Nome........:";
        private static string l3 = "RG..........:";
        private static string l4 = "CPF.........:";
        private static string l5 = "Habilitação.:";
        private static string l6 = "Tit. Eleitor:";

        public static List<Registro> CadastroRegistro(List<Registro> registros, bool novo = false)
        {
            int qtdRegistros = registros.Count;
            Registro registro = new Registro();
            int op = 0;
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

            Console.WriteLine(l2);
            Console.WriteLine(l3);
            Console.WriteLine(l4);
            Console.WriteLine(l5);
            Console.WriteLine(l6);

            //Menu Opcoes
            Console.SetCursorPosition(0, 26);

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
            Console.SetCursorPosition(l1.Length + 1, 2);
            registro.Nome = Console.ReadLine();
            Console.SetCursorPosition(l1.Length + 1, 3);
            registro.RG = Console.ReadLine();
            bool validar = Validador.ValidarRG(registro.RG);
            if (!validar)
            {
                do
                {
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg: RG Inválido.");
                    Task.Delay(2000).Wait();
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg:             ");
                    Console.SetCursorPosition(l1.Length + 1, 3);
                    Console.Write(new string(' ',50));
                    Console.SetCursorPosition(l1.Length + 1, 3);
                    registro.RG = Console.ReadLine();
                    validar = Validador.ValidarRG(registro.RG);
                } while (!validar);

            }
            Console.SetCursorPosition(l1.Length + 1, 4);
            registro.CPF = Console.ReadLine();
            validar = Validador.ValidarCPF(registro.CPF);
            if (!validar)
            {
                do
                {
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg: CPF Inválido.");
                    Task.Delay(2000).Wait();
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg:              ");
                    Console.SetCursorPosition(l1.Length + 1, 4);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(l1.Length + 1, 4);
                    registro.RG = Console.ReadLine();
                    validar = Validador.ValidarCPF(registro.CPF);
                } while (!validar);
            }

            Console.SetCursorPosition(l1.Length + 1, 5);
            registro.Habilitacao = Console.ReadLine();
            validar = Validador.ValidarCNH(registro.Habilitacao);
            if (!validar)
            {
                do
                {
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg: CNH Inválido.");
                    Task.Delay(2000).Wait();
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg:              ");
                    Console.SetCursorPosition(l1.Length + 1, 5);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(l1.Length + 1, 5);
                    registro.RG = Console.ReadLine();
                    validar = Validador.ValidarCNH(registro.Habilitacao);
                } while (!validar);
            }
            Console.SetCursorPosition(l1.Length + 1, 6);
            registro.Titulo = Console.ReadLine();
            validar = Validador.ValidarTituloEleitor(registro.Titulo);
            if (!validar)
            {
                do
                {
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg: Título Inválido.");
                    Task.Delay(2000).Wait();
                    Console.SetCursorPosition(0, 29);
                    Console.Write("Msg:              ");
                    Console.SetCursorPosition(l1.Length + 1, 6);
                    Console.Write(new string(' ', 50));
                    Console.SetCursorPosition(l1.Length + 1, 6);
                    registro.Titulo = Console.ReadLine();
                    validar = Validador.ValidarTituloEleitor(registro.Titulo);
                } while (!validar);
            }

            registros.Add(registro);

            Console.SetCursorPosition(0, 29);
            Console.Write("Msg: Registro incluído com sucesso.");
            Task.Delay(2000).Wait();

            return registros;

        }

        public static List<Registro> ListarRegistros(List<Registro> registros, int? posicao)
        {
            if (posicao == null) posicao = 0;
            pos = posicao.Value;
            int qtdRegistros = registros.Count;
            Registro registro = new Registro();
            int op = 0;
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

            Console.WriteLine(l1 + $"{posicao + 1} de {qtdRegistros}");
            Console.WriteLine(l2 + $" {registros.ElementAt(posicao.Value).Nome}");
            Console.WriteLine(l3 + $" {registros.ElementAt(posicao.Value).RG}");
            Console.WriteLine(l4 + $" {registros.ElementAt(posicao.Value).CPF}");
            Console.WriteLine(l5 + $" {registros.ElementAt(posicao.Value).Habilitacao}");
            Console.WriteLine(l6 + $" {registros.ElementAt(posicao.Value).Titulo}");

            //Menu Opcoes
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("<F1> Insere novo <F2> Anterior <F3> Próximo <F5> Editar <F9> Sair");

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
            return registros;
        }
        public static void Cad(List<Registro> registros, bool novo = false)
        {
            if (registros.Count == 0 || novo == true)
            {
                registros = CadastroRegistro(registros);
                Console.Clear();
                ListarRegistros(registros, null);
            }
            else
            {
                registros = ListarRegistros(registros, null);
            }

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        Cad(registros, true);
                        break;
                    case ConsoleKey.F2:
                        if (pos < 0)
                        {
                            Console.Clear();
                            ListarRegistros(registros, pos);
                            Console.SetCursorPosition(0, 29);
                            Console.Write("Msg: Já está no primeiro registro");
                        }
                        else
                        {
                            Console.Clear();
                            pos--;
                            if (pos < 0)
                            {
                                pos++;
                                ListarRegistros(registros, pos);
                                Console.SetCursorPosition(0, 29);
                                Console.Write("Msg: Já está no primeiro registro");
                            }
                            else { Console.Clear();
                                ListarRegistros(registros, pos);
                            }
                        }
                        break;
                    case ConsoleKey.F3:
                        if (pos >= registros.Count - 1)
                        {
                            Console.Clear();
                            ListarRegistros(registros, pos);
                            Console.SetCursorPosition(0, 29);
                            Console.Write("Msg: Ultimo registro");
                        }
                        else
                        {
                            Console.Clear();
                            pos++;
                            ListarRegistros(registros, pos);
                        }
                        break;
                    case ConsoleKey.F5:
                        Console.Clear();
                        Editar.EditarRegistro(registros, pos.Value);
                        break;
                    case ConsoleKey.F7:
                        Console.Clear();
                        break;
                    case ConsoleKey.F8:
                        Console.Clear();
                        break;
                    case ConsoleKey.F9:
                        Console.Clear();
                        Principal.ImprimePrincipal(registros);
                        break;
                }
            }

        }
    }
}
