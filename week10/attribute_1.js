'use strict;'

let image = document.querySelector('img');
console.log(image.getAttribute('src'));

image.setAttribute('src', 'https://orig00.deviantart.net/e06c/f/2012/353/3/e/cat_owl_by_dwarf4r-d5oix14.jpg');
image.setAttribute('alt', 'a cat faced owl so trippy af i wonder if it\'s even real');

//image.setAttribute('src', 'http://www.ipswichstar.co.uk/polopoly_fs/1.4941838!/image/image.jpg_gen/derivatives/landscape_630/image.jpg');
//image.setAttribute('alt', 'cute happy owl');

let website = document.querySelector('a');
website.setAttribute('href', 'https://www.greenfoxacademy.com/');

let secondButton = document.querySelector('button.this-one');
secondButton.setAttribute('disabled', true);
secondButton.innerHTML = 'Don\'t click me!';
