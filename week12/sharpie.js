'use strict';

function sharpie(colour, width) {
    this.colour = colour;
    this.width = width;
    this.inkAmount = 100;
    this.use = function() {
        if (this.inkAmount < this.width) {
            console.log(`${this.colour} sharpie\'s out of szufla, please put it down and choose another one!`)
        } else {
            this.inkAmount -= this.width;
            console.log(`Drawing with ${this.colour} sharpie, ink left is ${this.inkAmount}%.`)
        }
    }
}

let blueishSharpieSet = [
    new sharpie('turquoise', 0.03),
    new sharpie('teal', 0.012),
    new sharpie('navy', 0.06),
    new sharpie('royal', 0.0777),
    new sharpie('sky', 0.023),
];

function drawSomethingBlueish(sharpies) {
    sharpies.forEach(function(sharpie) {
        sharpie.use();
    });
}

drawSomethingBlueish(blueishSharpieSet);
