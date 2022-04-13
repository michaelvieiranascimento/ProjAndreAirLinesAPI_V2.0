using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Castle.MicroKernel.SubSystems.Conversion;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class PrecoBase
    {
        public int Id { get; set; }
        public Aeroporto Origem { get; set; }
        public Aeroporto Destino { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Preco { get; set; }
        public double PorcentagemPromocao { get; set; }
        public Class Class { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataInclusao { get; set; }
    }
}
