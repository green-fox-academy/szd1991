'use strict';

let unorderedList = document.getElementsByTagName('ul');
unorderedList[0].style.backgroundColor = 'limegreen';

let listElements = unorderedList[0].getElementsByTagName('li');

let contentArray = ['apple', 'banana', 'cat', 'dog'];

for (i = 0; i < listElements.length; i++) {
    listElements[i].innerHTML = contentArray[i];
}
