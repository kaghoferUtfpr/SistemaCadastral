using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public static class Banco
    {
        public static List<Registro> lista = new List<Registro>();
        
        public static void Salvar(List<Registro> lista, string nome)
        {
            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText(Directory.GetCurrentDirectory() + $"/{nome}.dat", json);
        }

        public static List<Registro> BuscarRegistros(string nome)
        {
            string jsonLido = File.ReadAllText(Directory.GetCurrentDirectory() + $"/{nome}.dat");
            List<Registro> registros = JsonSerializer.Deserialize<List<Registro>>(jsonLido);
            return registros;
        }

    }
}
