'use strict';
// - Create a variable named `magicNumbers`
//   with the following content: `[1, 3, 5, 7]`
// - Print the third element of `magicNumbers`

let magicNumbers = [1, 2, 3, 5, 7];

console.log(magicNumbers[2]);

function iterate(numbers) {
  numbers.forEach(function(number) {
    console.log(number);
  });
};

iterate(magicNumbers);
