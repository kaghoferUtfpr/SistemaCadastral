﻿using SistemaCadastral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CadastroV2
{
    internal class PrincipalVazia
    {
        private static int op = 0;
        public static void ImprimePrincipalVazia(List<Registro> registros)
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

            string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.dat");
            string menu;
            if (arquivos.Length == 0)
            {
                menu = "\nF1 – Cadastrar documentos\r\n" +
                "F9 – Sair";
            }
            else
            {
                menu = "\nF1 – Cadastrar documentos\r\n" +
                "F7 – Carregar documentos\r\n" +
                "F9 – Sair";
            }

            //Menu
            Console.WriteLine(menu);

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



            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        Cadastrar.Cad(registros);
                        break;
                    case ConsoleKey.F7:
                        Console.Clear();
                        Carregar.CarregarDoBanco();
                        break;
                    case ConsoleKey.F9:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 29);
                        Console.Write("Msg: Deseja mesmo sair? (Y) se SIM");
                        Console.ResetColor();
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Y)
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.SetCursorPosition(0, 29);
                            Console.Write("Msg:                                    ");
                            Console.SetCursorPosition(5, 29);

                        }
                        break;
                }
            }

        }
    }
}
