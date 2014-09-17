// Write a JavaScript function findMaxSequence(value) that finds the maximal sequence of 
// equal elements in an array and returns the result as an array. If there is more than one sequence 
// with thesamemaximallength, print the rightmost one. Write JS program sequenceFinder.js that invokes 
// your function with the sample input data below and prints the output at the console. 

function findMaxSequence(array) {
    var indexLastElement = 0,
        maxCounter = 1,
        tempCounter = 1,
        seqElements = [];

    if (array.length === 1) {
        seqElements[0] = array[0];
    } else {
        for (var i = 0; i < array.length - 1; i++) {
            if (array[i] === array[i + 1]) {
                tempCounter += 1;
            } else {
                tempCounter = 1;
            }
            if (tempCounter >= maxCounter) {
                maxCounter = tempCounter;
                indexLastElement = i;
            }
        }
        
        for (var j = 0; j < maxCounter; j++) {
            seqElements[j] = array[indexLastElement - maxCounter + 2 + j];
        }
    }

    return seqElements;
}

console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3', 4, 4, 8, 15]));