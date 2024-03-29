﻿// <auto-generated />
using System;
using AppChurch.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AppChurch.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AppChurch.Domain.Model.DizimoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("MembroId")
                        .HasColumnType("uuid");

                    b.Property<string>("MesReferente")
                        .HasColumnType("text");

                    b.Property<decimal>("Valor")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Dizimo");
                });

            modelBuilder.Entity("AppChurch.Domain.Model.EnderecoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("CEP")
                        .HasColumnType("integer");

                    b.Property<string>("Complemento")
                        .HasColumnType("text");

                    b.Property<string>("Logradoro")
                        .HasColumnType("text");

                    b.Property<int>("numero")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AppChurch.Domain.Model.MembroModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DataBatismo")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataConversao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DizimoId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EnrecoId")
                        .HasColumnType("uuid");

                    b.Property<int>("Idade")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("sexo")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DizimoId");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("AppChurch.Domain.Model.MembroModel", b =>
                {
                    b.HasOne("AppChurch.Domain.Model.DizimoModel", "Dizimo")
                        .WithMany()
                        .HasForeignKey("DizimoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppChurch.Domain.Model.EnderecoModel", "Endereco")
                        .WithMany("Membros")
                        .HasForeignKey("EnderecoId");

                    b.Navigation("Dizimo");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("AppChurch.Domain.Model.EnderecoModel", b =>
                {
                    b.Navigation("Membros");
                });
#pragma warning restore 612, 618
        }
    }
}
