// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjAndreAirLinesAPI_V2._0.Data;

namespace ProjAndreAirLinesAPI_V2._0.Migrations
{
    [DbContext(typeof(ProjAndreAirLinesAPI_V2_0Context))]
    partial class ProjAndreAirLinesAPI_V2_0ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Aeronave", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Capacidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aeronave");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", b =>
                {
                    b.Property<string>("Sigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("enderecoId")
                        .HasColumnType("int");

                    b.HasKey("Sigla");

                    b.HasIndex("enderecoId");

                    b.ToTable("Aeroporto");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cep")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Passageiro", b =>
                {
                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("enderecoId")
                        .HasColumnType("int");

                    b.HasKey("Cpf");

                    b.HasIndex("enderecoId");

                    b.ToTable("Passageiro");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Passagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(8,2)");

                    b.Property<string>("passageiroCpf")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("vooId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("passageiroCpf");

                    b.HasIndex("vooId");

                    b.ToTable("Passagem");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.PrecoBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinoSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("OrigemSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("PorcentagemPromocao")
                        .HasColumnType("float");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("DestinoSigla");

                    b.HasIndex("OrigemSigla");

                    b.ToTable("PrecoBase");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Voo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Desembarque")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinoSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Embarque")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrigemSigla")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("aeronaveId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("DestinoSigla");

                    b.HasIndex("OrigemSigla");

                    b.HasIndex("aeronaveId");

                    b.ToTable("Voo");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoId");

                    b.Navigation("endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Passageiro", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Endereco", "endereco")
                        .WithMany()
                        .HasForeignKey("enderecoId");

                    b.Navigation("endereco");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Passagem", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Passageiro", "passageiro")
                        .WithMany()
                        .HasForeignKey("passageiroCpf");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Voo", "voo")
                        .WithMany()
                        .HasForeignKey("vooId");

                    b.Navigation("Class");

                    b.Navigation("passageiro");

                    b.Navigation("voo");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.PrecoBase", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoSigla");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", "Origem")
                        .WithMany()
                        .HasForeignKey("OrigemSigla");

                    b.Navigation("Class");

                    b.Navigation("Destino");

                    b.Navigation("Origem");
                });

            modelBuilder.Entity("ProjAndreAirLinesAPI_V2._0.Model.Voo", b =>
                {
                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", "Destino")
                        .WithMany()
                        .HasForeignKey("DestinoSigla");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Aeroporto", "Origem")
                        .WithMany()
                        .HasForeignKey("OrigemSigla");

                    b.HasOne("ProjAndreAirLinesAPI_V2._0.Model.Aeronave", "aeronave")
                        .WithMany()
                        .HasForeignKey("aeronaveId");

                    b.Navigation("aeronave");

                    b.Navigation("Destino");

                    b.Navigation("Origem");
                });
#pragma warning restore 612, 618
        }
    }
}
