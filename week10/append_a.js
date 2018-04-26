'use strict';
// - Create a variable named `nimals`
//   with the following content: `["kuty", "macsk", "cic"]`
// - Add all elements an `"a"` at the end
// - try to use built in functions instead of loops

const nimals = ['kuty', 'macsk', 'cic', 'rók'];

const animals = nimals.map(nimal => nimal + 'a');

const animalsA = nimals.map(nimal => nimal.concat('a'));

console.log(nimals);
console.log(animals);
console.log(animalsA);
