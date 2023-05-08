﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoFiGroupApi.Data;

#nullable disable

namespace ToDoFiGroupApi.Migrations
{
    [DbContext(typeof(ToDoDbContext))]
    [Migration("20230507232600_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDoFiGroupApi.Models.ToDoItem", b =>
                {
                    b.Property<Guid>("UID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Completado")
                        .HasColumnType("bit");

                    b.Property<int>("Orden")
                        .HasColumnType("int");

                    b.Property<string>("Tarea")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UID");

                    b.ToTable("ToDoItems");
                });
#pragma warning restore 612, 618
        }
    }
}