let myList = [1; 2; 3;]

-5 :: myList // create new list with -5 as the head

// extract head and tail from the list (note: empty list will explode)
let head :: tail = myList

myList @ [-5; -10] // concatenate the two lists, return new list