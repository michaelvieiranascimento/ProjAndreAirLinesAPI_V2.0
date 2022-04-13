using System.ComponentModel.DataAnnotations;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class Aeroporto
    {
        [Key]
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public Endereco endereco { get; set; }
    }
}
