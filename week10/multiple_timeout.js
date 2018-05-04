'use strict';

// Write a program that prints the following fruits:
// apple -> immediately
// pear -> after 1 seconds
// melon -> after 3 seconds
// grapes -> after 5 seconds

function printThatSheit(firstArriver, secondArriver, thirdArriver, fourthArriver) {
    setTimeout(function() {console.log(secondArriver)}, 1000);
    setTimeout(function() {console.log(fourthArriver)}, 5000);
    setTimeout(() => {console.log(thirdArriver)}, 3000);
    console.log(firstArriver);
}

printThatSheit('apple', 'pear', 'melon', 'grapes');
