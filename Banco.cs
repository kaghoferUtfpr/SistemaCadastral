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
        
        public static void Salvar(Registro registro)
        {
            string json = JsonSerializer.Serialize(registro);
            File.WriteAllText(Directory.GetCurrentDirectory() + "/arquivo.json", json);
        }

        public static List<Registro> Listar()
        {
            string jsonLido = File.ReadAllText(Directory.GetCurrentDirectory() + "/arquivo.json");
            List<Registro> registros = JsonSerializer.Deserialize<List<Registro>>(jsonLido);
            return registros;
        }

    }
}
