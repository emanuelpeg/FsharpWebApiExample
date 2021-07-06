namespace webAPIFsharp

open System.ComponentModel.DataAnnotations
open Microsoft.EntityFrameworkCore
open EntityFrameworkCore.FSharp.Extensions

type ApiDbContext() =
    inherit DbContext()

    [<DefaultValue>]
    val mutable pruebas : DbSet<Prueba>

    member public this.Pruebas with get() = this.pruebas
                               and set p = this.pruebas <- p

    override _.OnModelCreating builder =
        builder.RegisterOptionTypes() // enables option values for all entities

    override __.OnConfiguring(options: DbContextOptionsBuilder) : unit =
        options.UseSqlite("Data Source=base.db") |> ignore