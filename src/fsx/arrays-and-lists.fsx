let myArray = [|1.; 5; 10.|]

myArray[0]
myArray[1] = 5.
myArray[1] <- 20.
myArray

let myList = [1; 2; 3;]
myList[2]
myList[2] = 3
// myList[1] <- 3 // compile error