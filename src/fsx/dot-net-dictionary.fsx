open System.Collections.Generic
let dictionary = new Dictionary<string, int>()
// val dictionary : System.Collections.Generic.Dictionary<string,int> = dict []

dictionary["a"] <- 1 // val it : unit = ()
dictionary["b"] <- 2 // val it : unit = ()
dictionary
// val it: Dictionary<string,int> = dict [("a", 1); ("b", 2)]

dictionary["a"] = 1
// val it: bool = true
