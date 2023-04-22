using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastral
{
    public class Registro
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Habilitacao { get; set; }
        public string Titulo { get; set; }

        public Registro()
        {
        }

        public Registro(string nome, string cPF, string rG, string habilitacao, string titulo)
        {
            Nome = nome;
            CPF = cPF;
            RG = rG;
            Habilitacao = habilitacao;
            Titulo = titulo;
        }

        public override string? ToString()
        {
            return $"Nome: {Nome}   CPF: {CPF}  RG: {RG}    Habilitação: {Habilitacao}  Titulo: {Titulo}";
        }
    }

    
}
