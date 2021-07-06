namespace webAPIFsharp.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.EntityFrameworkCore
open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open webAPIFsharp

[<ApiController>]
[<Route("[controller]")>]
type PruebaController (logger : ILogger<PruebaController>, dbContext : ApiDbContext) =
    inherit ControllerBase()


    [<HttpGet>]
    member _.Get() = ActionResult<IEnumerable<Prueba>>(dbContext.Pruebas)

    [<HttpPost>]
    member _.PostSync(prueba:Prueba) = 
        dbContext.Pruebas.Add prueba |> ignore
        dbContext.SavedChanges |> ignore


    [<HttpPost("async")>]
    member _.PostAsync(entity: Prueba) =
        async {
            dbContext.Pruebas.AddAsync(entity) |> ignore
            let! _ = dbContext.SaveChangesAsync true |> Async.AwaitTask
            return entity
        } 

    [<HttpGet("{id}")>]
    member _.getById id =
        dbContext.Pruebas
        |> Seq.tryFind (fun f -> f.Id = id) 
