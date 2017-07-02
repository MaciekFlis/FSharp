namespace FSharp.WebHost.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc


type ExpensesController () =
    inherit ApiController()

    member this.Index() =
        "none"