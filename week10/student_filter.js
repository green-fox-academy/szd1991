'use strict';

var students = [
        {'name': 'Rezso', 'age': 9.5, 'candies': 2},
        {'name': 'Gerzson', 'age': 10, 'candies': 1},
        {'name': 'Aurel', 'age': 7, 'candies': 3},
        {'name': 'Zsombor', 'age': 12, 'candies': 5}
]

function studentsRichInCandies(listOfStudents) {
    return listOfStudents.filter(student => student.candies > 4);
}

function candyAverage(listOfStudents) {
    let candyCounter = 0;
    listOfStudents.forEach(stu => candyCounter += stu.candies);
    return (candyCounter / listOfStudents.length);
}

// create a function that takes a list of students and logs:
// - Who has got more candies than 4 candies
console.log(studentsRichInCandies(students));
// create a function that takes a list of students and logs:
//  - how many candies they have on average
console.log(candyAverage(students));
