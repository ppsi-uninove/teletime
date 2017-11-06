﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Teletime.Models;

namespace Teletime.Migrations
{
    [DbContext(typeof(TeletimeContext))]
    [Migration("20171106004933_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Teletime.Models.Cargo", b =>
                {
                    b.Property<int>("IdCargo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeCargo")
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdCargo");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("Teletime.Models.Departamento", b =>
                {
                    b.Property<int>("IdDepartamento")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdDepartamento");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Teletime.Models.Funcionario", b =>
                {
                    b.Property<long>("CPF");

                    b.Property<long?>("CPFResponsavel");

                    b.Property<DateTime>("DataAdmissao");

                    b.Property<DateTime?>("DataDemissao");

                    b.Property<int>("IdCargo");

                    b.Property<int>("IdDepartamento");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(200)");

                    b.HasKey("CPF");

                    b.HasIndex("CPFResponsavel");

                    b.HasIndex("IdCargo");

                    b.HasIndex("IdDepartamento");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Teletime.Models.Ponto", b =>
                {
                    b.Property<int>("IdPonto")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("CPF");

                    b.Property<DateTime>("DataHora");

                    b.Property<string>("EntradaSaida")
                        .HasColumnType("char(1)");

                    b.HasKey("IdPonto");

                    b.HasIndex("CPF");

                    b.ToTable("Ponto");
                });

            modelBuilder.Entity("Teletime.Models.Funcionario", b =>
                {
                    b.HasOne("Teletime.Models.Funcionario", "Responsavel")
                        .WithMany("Subordinados")
                        .HasForeignKey("CPFResponsavel");

                    b.HasOne("Teletime.Models.Cargo", "Cargo")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdCargo")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Teletime.Models.Departamento", "Departamento")
                        .WithMany("Funcionarios")
                        .HasForeignKey("IdDepartamento")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Teletime.Models.Ponto", b =>
                {
                    b.HasOne("Teletime.Models.Funcionario", "Funcionario")
                        .WithMany("Pontos")
                        .HasForeignKey("CPF")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
