printfn "HI!"
// val it: unit = ()

let myFunWithUnit a b =
    printfn "%A" (a+b)
    () // not strictly necessary as printfn also returns ()
// val myFunWithUnit: a: int -> b: int -> unit

myFunWithUnit 1 2
// val it: unit = ()