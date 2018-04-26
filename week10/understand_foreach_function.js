'use strict';

['apple', 'pear', 'melon'].forEach(function(e, i) {
  console.log(e, i);
});


/*

With foreach function you can print out all elements in an array. By default it is given three parameters, in order: the element itself, the index of element, the whole array.

If two of the parameters are missing, only the value of that element will be printed. If the last one misses, only the element and its index will appear.

*/
