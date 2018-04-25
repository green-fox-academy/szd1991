'use strict';
// - Create a variable named `abc` with the following content: `["Arthur", "Boe", "Chloe"]`
// - Swap the first and the third element of `abc`

let abc = ["Arthur", "Boe", "Chloe"];

function swapFirstLast(array) {
  let first = array.shift();
  let last = array.pop();

  array.push(first);
  array.unshift(last);

  return array;
}

console.log(swapFirstLast(abc));
