let astring = "Hello from F#"
// val astring: string = "Hello from F#"

astring[1] = 'e'
// val it: bool = true

astring[1] <- 'a' // no can do
// ..\strings.fsx(5,1): error FS0810: Property 'Chars' cannot be set

astring[2..5]
// val it: string = "llo "