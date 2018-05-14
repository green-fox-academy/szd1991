'use strict';

function CreatePalindrome(somethingNormal) {
    let somethingFunny = somethingNormal;

    for (let i = somethingNormal.length - 1; i >= 0; i--) {
        somethingFunny += somethingNormal[i];
    }

    return somethingFunny;
}

console.log(CreatePalindrome('pingvin'));
