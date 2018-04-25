'use strict';

for (let fbc = 1; fbc <= 100; fbc++) {
    if (fbc % 5 === 0 && fbc % 3 === 0) {
        console.log('FizzBuzz');
    } else if (fbc % 5 === 0) {
        console.log('Buzz');
    } else if (fbc % 3 === 0) {
        console.log('Fizz');
    } else {
        console.log(fbc);
    }
}