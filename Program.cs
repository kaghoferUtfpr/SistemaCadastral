namespace SistemaCadastral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header.Imprimir();

            Menu.ImprimirTela();

            ConsoleKeyInfo key = Console.ReadKey(true);

            do
            {
                if (key.Key == ConsoleKey.F1)
                {
                    Console.Clear();
                    Header.Imprimir();
                    Body.TelaCadastro();
                }
                else
                {
                    key = Console.ReadKey(true);
                }
            }
            while (key.Key != ConsoleKey.Escape);

        }
    }
}