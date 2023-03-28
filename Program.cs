namespace SistemaCadastral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header.Imprimir();

            string menu = "\nF1 – Cadastrar documentos\r\nF2 – Pesquisar documentos\r\nF3 – Listar documentos\r\n\nF7 – Carregar documentos\r\nF8 – Salvar documentos\r\n\nF9 – Sair";
            Console.WriteLine(menu);


        }
    }
}