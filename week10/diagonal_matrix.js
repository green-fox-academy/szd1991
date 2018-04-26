'use strict';
// - Create (dynamically*) a two dimensional list
//   with the following matrix**. Use a loop!
//
//   0 0 0 1
//   0 0 1 0
//   0 1 0 0
//   1 0 0 0
//
// - Print this two dimensional list to the console
//
// * size should depend on a variable
// ** Relax, a matrix is just like an array

function matrixDrawer(size) {
  for (let i = 1; i <= size; i++) {
    let line = '';
    for (let j = 1; j <= size; j++) {
      line += '*';
    }
    console.log(line);
  }
};

matrixDrawer(5);
