﻿// <auto-generated />
using finlab.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace finlab.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20171117221653_AdicionadoCitys")]
    partial class AdicionadoCitys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("finlab.Dominio.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("finlab.Dominio.Despesas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("data");

                    b.Property<string>("grupo");

                    b.Property<string>("local");

                    b.Property<decimal>("numDoc");

                    b.Property<string>("valor");

                    b.HasKey("id");

                    b.ToTable("Gasto");
                });
#pragma warning restore 612, 618
        }
    }
}
