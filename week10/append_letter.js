'use strict';
// Create a function called "appendA()" that adds "a" to every string in the far list.
// The parameter should be a list.
var far = ["kuty", "macsk", "kacs", "rók", "halacsk"];

function appendA(list) {
    list = list.map(ele => ele + 'a');

    return list;
}

/*
function appendA(list) {
    return list.map(function(ele) {
        return ele + 'a';
    });
}
*/

console.log(appendA(far));
module.exports = appendA;
