namespace webAPIFsharp

open System

[<CLIMutable>]
type Prueba =
    { Id: int
      Name : string
      Summary: string }