// For more information see https://aka.ms/fsharp-console-apps

// printf
let a = [|1; 2; 3;|]
printfn "%A" a

// Using System.Console
System.Console.WriteLine(a)

//
printf "Enter your command human:"
let input = System.Console.ReadLine()  // read input from console
printfn "Your command is: %A" input
