'use strict';

const numberToGuess = Math.floor(Math.random() * 100);
console.log('Thought of a number between 0 and 100. Try to guess it!');

const readline = require('readline');

let rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});
