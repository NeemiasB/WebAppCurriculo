using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCurriculo.Models
{
    public class Curriculo
    {
        //INFORMAÇÕES PESSOAIS
        public int CurriculoId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Altura { get; set; }
        public string Site { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Sexo Sexo { get; set; }

        //ENDEREÇO
        public string Endereco { get; set; }
        public string CEP { get; set; }

        //CONTATO
        public string TelefoneFixo { get; set; }
        public string TelefoneMovel { get; set; }

        //CONHECIMENTOS
        public bool HTML { get; set; }
        public bool CSS { get; set; }
        public bool Javascript { get; set; }
        public string MaisConhecimentos { get; set; }


    }
}
