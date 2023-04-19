namespace SistemaCadastral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco.lista.Add(new Registro("yurturyu", "789789", "12313", "12345", "585828"));
            Banco.lista.Add(new Registro("dflkgdlg", "44545", "6454", "54654", "45454"));

            Header.Imprimir();

            Menu.ImprimirTela();

            Rodape.RodapePrincipal("");

            ConsoleKey key = Console.ReadKey(true).Key;

            bool exit = false;

            while (!exit)
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
                        Header.Imprimir();
                        break;
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
                        Header.Imprimir();
                        Menu.ImprimirTela();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Rodape.RodapePrincipal("Deseja mesmo sair? (Y) se SIM");
                        Console.ResetColor();
                        key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Y)
                        {
                            Environment.Exit(0);
                            exit = true;
                        }
                        else
                        {
                            Console.Clear();
                            Header.Imprimir();
                            Menu.ImprimirTela();
                            Rodape.RodapePrincipal("");
                        }
                        break;
                    default:
                        key = Console.ReadKey(true).Key;
                        break;
                }
            }



        }
    }
}