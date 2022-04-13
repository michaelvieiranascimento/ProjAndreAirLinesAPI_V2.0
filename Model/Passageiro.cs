using System;
using System.ComponentModel.DataAnnotations;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class Passageiro
    {
        [Key]
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateNasc { get; set; }
        public string Email { get; set; }
        public virtual Endereco endereco { get; set; }
    }
}
