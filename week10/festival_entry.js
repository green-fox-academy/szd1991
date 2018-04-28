'use strict';

let watchlist = [];

let security_alcohol_loot = 0;

const queue = [
	{ 'name': 'Amanda', 'alcohol': 10, 'guns': 1 },
	{ 'name': 'Tibi', 'alcohol': 0, 'guns': 0 },
	{ 'name': 'Dolores', 'alcohol': 0, 'guns': 1 },
	{ 'name': 'Wade', 'alcohol': 1, 'guns': 1 },
	{ 'name': 'Anna', 'alcohol': 10, 'guns': 0 },
	{ 'name': 'Rob', 'alcohol': 2, 'guns': 0 },
	{ 'name': 'Joerg', 'alcohol': 20, 'guns': 0 }
];

function printList(list) {
    list.forEach(function(person) {
        console.log(person);
    });
    console.log('\n');
}

// Queue of festivalgoers at entry
// no. of alcohol units
// no. of guns
function securityCheck(festivalgoers) {
    festivalgoers.forEach(function(festivalgoer) {
        if (festivalgoer.guns > 0) {
            festivalgoer.guns -= festivalgoer.guns;
            watchlist.push({ 'name': festivalgoer.name });
        }
        if (festivalgoer.alcohol > 0) {
            security_alcohol_loot += festivalgoer.alcohol;
            festivalgoer.alcohol = 0;
        }
    });
}
// Create a securityCheck function that takes the queue as a parameter and returns a list of festivalgoers who can enter the festival
console.log('Queue: ');
printList(queue);
securityCheck(queue);
console.log('Entered: ');
printList(queue);
console.log('Watchlist: ');
printList(watchlist);
console.log('Security alcohol loot: ' + security_alcohol_loot);
// If guns are found, remove them and put them on the watchlist (only the names)
// If alcohol is found confiscate it (set it to zero and add it to security_alchol_loot) and let them enter the festival

// module.exports = securityCheck;
