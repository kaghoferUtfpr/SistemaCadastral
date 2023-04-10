using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public class Menu
    {
        public static void ImprimirTela()
        {
            string menu = "\nF1 – Cadastrar documentos\r\n" +
                "F2 – Pesquisar documentos\r\n" +
                "F3 – Listar documentos\r\n\n" +
                "F7 – Carregar documentos\r\n" +
                "F8 – Salvar documentos\r\n\n" +
                "F9 – Sair";
            Console.WriteLine(menu);
        }
    }
}
