// Functions
/*
function greet_fox_alert() {
  alert("Hello Green Fox!")
}
greet_fox_alert()
*/

function greet_fox_log() {
  console.log("Hello Green Fox!")
}

greet_fox_log()

// Function arguments

function greet_by_name(name) {
  console.log(arguments)
  console.log("Well hi there,", name)
}

greet_by_name("Tojas")
greet_by_name("Barbi", "CEO")

// Default values for function arguments

function greet(greet="Hi", name="pal") {
  console.log(greet, name)
}

greet("Hey")
greet("Hello", "Tojas")

// Function return values

function make_green(name) {
  var newName = "Green " + name
  return newName
}

name = make_green("Tojas")
greet_by_name("Whazzup", name)
