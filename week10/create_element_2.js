'use strict';

const planetData = [
  {
    category: 'inhabited',
    content: 'Foxes',
    asteroid: true
  },
  {
    category: 'inhabited',
    content: 'Whales and Rabbits',
    asteroid: true
  },
  {
    category: 'uninhabited',
    content: 'Baobabs and Roses',
    asteroid: true
  },
  {
    category: 'inhabited',
    content: 'Giant monsters',
    asteroid: false
  },
  {
    category: 'inhabited',
    content: 'Sheep',
    asteroid: true
  }
];

let asteroidList = document.querySelector('.asteroids');
let king = asteroidList.getElementsByTagName('li')[0];
asteroidList.removeChild(king);

planetData.forEach(function(planet) {
    if (planet.asteroid) {
        let planetElement = document.createElement('li');
        planetElement.classList.add(planet.category);
        planetElement.textContent = planet.content;
        asteroidList.appendChild(planetElement);
    }
});
