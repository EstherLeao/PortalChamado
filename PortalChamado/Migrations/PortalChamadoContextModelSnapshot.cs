﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortalChamado.Data;

namespace PortalChamado.Migrations
{
    [DbContext(typeof(PortalChamadoContext))]
    partial class PortalChamadoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PortalChamado.Models.Acesso", b =>
                {
                    b.Property<int>("IdAcesso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoAcesso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAcesso");

                    b.ToTable("Acesso");
                });

            modelBuilder.Entity("PortalChamado.Models.Chamado", b =>
                {
                    b.Property<int>("IdChamado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assunto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Carteira")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataResposta")
                        .HasColumnType("datetime2");

                    b.Property<int>("Importancia")
                        .HasColumnType("int");

                    b.Property<string>("LoginCriador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoginTratamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Texto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdChamado");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("Chamado");
                });

            modelBuilder.Entity("PortalChamado.Models.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AcessoIdAcesso")
                        .HasColumnType("int");

                    b.Property<int>("IdAcesso")
                        .HasColumnType("int");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("AcessoIdAcesso");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PortalChamado.Models.Chamado", b =>
                {
                    b.HasOne("PortalChamado.Models.Usuario", "Usuario")
                        .WithMany("Chamado")
                        .HasForeignKey("UsuarioIdUsuario");
                });

            modelBuilder.Entity("PortalChamado.Models.Usuario", b =>
                {
                    b.HasOne("PortalChamado.Models.Acesso", "Acesso")
                        .WithMany("Usuarios")
                        .HasForeignKey("AcessoIdAcesso");
                });
#pragma warning restore 612, 618
        }
    }
}
