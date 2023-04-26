using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastral.utils
{
    public static class Validador
    {
        public static bool ValidarRG(string rg)
        {
            rg = rg.Replace(".", "").Replace("-", "");

            if (rg.Length != 8 && rg.Length != 9)
            {
                return false;
            }

            if (!long.TryParse(rg, out _))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
            {
                return false;
            }

            if (!long.TryParse(cpf, out _))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarTituloEleitor(string tituloEleitor)
        {
            tituloEleitor = tituloEleitor.Replace(".", "").Replace("-", "");

            if (tituloEleitor.Length != 12)
            {
                return false;
            }

            if (!long.TryParse(tituloEleitor, out _))
            {
                return false;
            }

            return true;
        }

        public static bool ValidarCNH(string cnh)
        {
            cnh = cnh.Replace(".", "").Replace("-", "");

            if (cnh.Length != 11)
            {
                return false;
            }

            if (!long.TryParse(cnh, out _))
            {
                return false;
            }

            return true;
        }
    }
}
