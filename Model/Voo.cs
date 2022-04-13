using System;
using System.ComponentModel.DataAnnotations;

namespace ProjAndreAirLinesAPI_V2._0.Model
{
    public class Voo
    {
        public int Id { get; set; }
        public Aeroporto Destino { get; set; }
        public Aeroporto Origem { get; set; }
        public Aeronave aeronave { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Embarque { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Desembarque { get; set; }
    }
}
