'use strict';
// - Create a variable named `af` with the following content: `[4, 5, 6, 7]`
// - Log each the element of `af` to the console*
// *hint: use a loop, console.log(af) won't cut it
// - bonus for using the correct built in array method

let af = [4, 5, 6, 7];

af.forEach(function(item) {
  console.log(item);
});

for (let i = 0; i < af.length; i++) {
  console.log(af[i]);
}

let whileI = 0;
while (whileI != af.length) {
  console.log(af[whileI]);
  whileI++;
}
