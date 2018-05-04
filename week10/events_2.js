'use strict';

let htmlList = document.querySelector('ul').querySelectorAll('li');
let resultElement = document.querySelector('.result');
let counterButton = document.querySelector('button');

counterButton.addEventListener('click', countListItems);

function countListItems() {
    htmlList = document.querySelector('ul').querySelectorAll('li');
    let result = htmlList.length;
    resultElement.textContent = result;
    return result;
}
