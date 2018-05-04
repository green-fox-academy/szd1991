'use strict';

let globalWindow = window;
let information = document.getElementsByTagName('h1')[0];
let keyCounter = 0;

globalWindow.addEventListener('keyup', (keyReleased) => {
    keyCounter++;
    console.log(`Keys were released ${keyCounter} time(s) since window was loaded.`);
    information.innerHTML = `Last pressed key is: ${keyReleased.key}<br></br>
                            Last pressed key code is: ${keyReleased.code}<br></br>
                            Old key value: ${keyReleased.keyCode}`;
});
