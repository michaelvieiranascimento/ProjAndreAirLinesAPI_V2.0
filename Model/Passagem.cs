using System;
using System.ComponentModel.DataAnnotations.Schema;
using Castle.MicroKernel.SubSystems.Conversion;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class Passagem
    {
        public int Id { get; set; }
        public Voo voo { get; set; }
        public Passageiro passageiro { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Preco { get; set; }
        public Class Class { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
