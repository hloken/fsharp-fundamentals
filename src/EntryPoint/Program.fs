// For more information see https://aka.ms/fsharp-console-apps

// can get arguments this way
let argv = System.Environment.GetCommandLineArgs()

printfn "%A" argv // [|arguments array|]

// Explicit entry-point
// [<EntryPoint>]
// let main argv =
//     printfn "%A" argv // [|arguments array|]
//     0