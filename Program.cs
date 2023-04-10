namespace SistemaCadastral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Header.Imprimir();

            Menu.ImprimirTela();

            ConsoleKey key = Console.ReadKey(true).Key;

            do
            {
                switch (key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        Header.Imprimir();
                        Body.TelaCadastro();
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        Header.Imprimir();                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        Header.Imprimir();
                        break;
                    case ConsoleKey.F7:
                        Console.Clear();
                        Header.Imprimir();
                        break;
                    case ConsoleKey.F8:
                        Console.Clear();
                        Header.Imprimir();
                        break;
                    case ConsoleKey.F9:
                        Environment.Exit(0);
                        break;
                    default:
                        key = Console.ReadKey(true).Key;
                        break;
                }

            }
            while (key != ConsoleKey.Escape);

        }
    }
}