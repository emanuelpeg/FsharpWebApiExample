﻿// <auto-generated />
namespace webAPIFsharp.Migrations

open System
open Microsoft.EntityFrameworkCore
open Microsoft.EntityFrameworkCore.Infrastructure
open Microsoft.EntityFrameworkCore.Metadata
open Microsoft.EntityFrameworkCore.Migrations
open Microsoft.EntityFrameworkCore.Storage.ValueConversion
open webAPIFsharp

[<DbContext(typeof<ApiDbContext>)>]
type ApiDbContextModelSnapshot() =
    inherit ModelSnapshot()

    override this.BuildModel(modelBuilder: ModelBuilder) =
        modelBuilder
            .HasAnnotation("ProductVersion", "5.0.6")
            |> ignore

        modelBuilder.Entity("webAPIFsharp.Prueba", (fun b ->

            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("INTEGER") |> ignore
            b.Property<string>("Name")
                .HasColumnType("TEXT") |> ignore
            b.Property<string>("Summary")
                .HasColumnType("TEXT") |> ignore

            b.HasKey("Id") |> ignore

            b.ToTable("Pruebas") |> ignore

        )) |> ignore
