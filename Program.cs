using SistemaCadastral;

namespace CadastroV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Registro> lista = Banco.lista;
            if (lista.Count == 0)
            {
                PrincipalVazia.ImprimePrincipalVazia(lista);
            }
            else
            {
                Principal.ImprimePrincipal(lista);
            }

        }
    }
}