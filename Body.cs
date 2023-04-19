using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public static class Body
    {
        static int registros = 0;
        static string linhaRegistro = string.Empty;

        //lista.Add();
        //lista.Add();

        public static void TelaCadastro()
        {
            var li = Banco.lista;
            Rodape.RodapeCadastrar();
            string nome = "";
            string rg = "";
            string cpf = "";
            string habilitacao = "";
            string tituloEleitor = "";
            if (li.Count == 0)
            {
                linhaRegistro = "vazio";
            }
            else
            {
                linhaRegistro = $"{registros} de {li.Count}";
            }
            bool isOk = true;
            bool save = false;

            string l1;
            string l2;
            string l3;
            string l4;
            string l5;
            string l6;
            l1 = $"Registro....: {linhaRegistro}";
            l2 = "Nome........:";
            l3 = "RG..........:";
            l4 = "CPF.........:";
            l5 = "Habilitação.:";
            l6 = "Tit. Eleitor:";



            ConsoleKey key;
            int linha = 5, coluna;
            coluna = l2.Length + 1;

            while (isOk)
            {
                Console.SetCursorPosition(0, 3);
                Console.WriteLine(l1);
                Console.SetCursorPosition(0, linha);
                if (nome.Equals(""))
                {
                    Console.WriteLine(l2);
                }
                else
                {
                    Console.WriteLine(l2 + nome);
                }
                if (rg.Equals(""))
                {
                    Console.WriteLine(l3);
                }
                else
                {
                    Console.WriteLine(l3 + rg);
                }
                if (cpf.Equals(""))
                {
                    Console.WriteLine(l4);
                }
                else
                {
                    Console.WriteLine(l4 + cpf);
                }
                if (habilitacao.Equals(""))
                {
                    Console.WriteLine(l5);
                }
                else
                {
                    Console.WriteLine(l5 + habilitacao);
                }
                if (tituloEleitor.Equals(""))
                {
                    Console.WriteLine(l6);
                }
                else
                {
                    Console.WriteLine(l6 + tituloEleitor);
                }

                Console.SetCursorPosition(coluna, linha++);

                if (nome.Equals(""))
                {
                    nome = Console.ReadLine();
                }
                if (rg.Equals(""))
                {
                    Console.SetCursorPosition((int)coluna, linha++);
                    rg = Console.ReadLine();
                }
                if (cpf.Equals(""))
                {
                    Console.SetCursorPosition((int)coluna, linha++);
                    cpf = Console.ReadLine();
                }
                if (habilitacao.Equals(""))
                {
                    Console.SetCursorPosition((int)coluna, linha++);
                    habilitacao = Console.ReadLine();
                }
                if (tituloEleitor.Equals(""))
                {
                    Console.SetCursorPosition((int)coluna, linha++);
                    tituloEleitor = Console.ReadLine();

                    li.Add(new Registro(nome, cpf, rg, habilitacao, tituloEleitor));
                    nome = "";
                    cpf = "";
                    rg = "";
                    habilitacao = "";
                    tituloEleitor = "";
                }

                Console.Clear();

                Console.SetCursorPosition(0, 0);
                Header.Imprimir();
                Body.TelaCadastro();
                Rodape.RodapeCadastrar();
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.F1:
                        break;
                    case ConsoleKey.F2:
                        break;
                    case ConsoleKey.F3:
                        break;
                    case ConsoleKey.F5:
                        Console.WriteLine("kldkldfklgkjd");
                        break;
                    case ConsoleKey.F9:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.DownArrow:
                        linha++;
                        Console.SetCursorPosition(coluna, linha);
                        break;
                    default:
                        key = Console.ReadKey(true).Key;
                        break;
                }
            }

        }

    }
}
