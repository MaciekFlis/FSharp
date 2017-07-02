namespace FSharp.WebHost.Controllers

open System
open System.Collections.Generic
open System.Linq
open System.Threading.Tasks
open Microsoft.AspNetCore.Mvc

[<ControllerAttribute>]
type ApiController() =  
     [<ActionContextAttribute>]
     member val ActionContext : ActionContext = null with get, set