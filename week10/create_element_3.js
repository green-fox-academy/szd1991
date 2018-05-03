'use strict';

const kids = [{"pet_name":"Wattled crane","owner":"Bryant"},
    {"pet_name":"Devil, tasmanian","owner":"Alejandro"},
    {"pet_name":"Mynah, common","owner":"Nelie"},
    {"pet_name":"Dolphin, common","owner":"Mariele"},
    {"pet_name":"Gray duiker","owner":"Maddalena"},
    {"pet_name":"Crab (unidentified)","owner":"Lucine"},
    {"pet_name":"Ant (unidentified)","owner":"Lorianna"},
    {"pet_name":"Bison, american","owner":"Tommie"},
    {"pet_name":"Yellow mongoose","owner":"Vivyan"},
    {"pet_name":"Carpet snake","owner":"Veda"},
    {"pet_name":"Lesser mouse lemur","owner":"Isidor"}
];

let petsDiv = document.querySelector('#pets');

kids.forEach(function (kid) {
    let articleElement = document.createElement('article');
    let hThree = document.createElement('h3');
    hThree.innerHTML = kid.owner;
    articleElement.appendChild(hThree);

    let paragraph = document.createElement('p');
    paragraph.innerText = kid.pet_name;
    articleElement.appendChild(paragraph);

    petsDiv.appendChild(articleElement);
});
