'use strict;'

let king = document.getElementById('b325');
console.log('King is this: ' + king);

let businessLamp = document.querySelectorAll('.big');
console.log('businessLamp collection: ' + businessLamp.length + ' items');
businessLamp.forEach(item => console.log(item));

let section = document.getElementsByTagName('section');
let conceitedKing = section[0].getElementsByTagName('div');
console.log('conceitedKing collection: ' + conceitedKing.length + ' items');
for (var i = 0; i < conceitedKing.length; i++) {
    console.log(conceitedKing[i]);
}

let noBusiness = document.getElementsByTagName('body')[0].getElementsByTagName('div');
console.log('noBusiness collection: ' + noBusiness.length + ' items');
for (var j = 0; j < noBusiness.length; j++) {
    console.log(noBusiness[j]);
}
