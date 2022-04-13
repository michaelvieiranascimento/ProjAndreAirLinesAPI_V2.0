using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAndreAirLinesAPI_V2._0.Model;

namespace ProjAndreAirLinesAPI_V2._0.Data
{
    public class ProjAndreAirLinesAPI_V2_0Context : DbContext
    {
        public ProjAndreAirLinesAPI_V2_0Context (DbContextOptions<ProjAndreAirLinesAPI_V2_0Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Aeronave> Aeronave { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Aeroporto> Aeroporto { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Class> Class { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Endereco> Endereco { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Passageiro> Passageiro { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Passagem> Passagem { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.PrecoBase> PrecoBase { get; set; }

        public DbSet<ProjAndreAirLinesAPI_V2._0.Model.Voo> Voo { get; set; }
    }
}
