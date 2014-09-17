// Write a JavaScript function findMaxSequence(value) that finds the maximal increasing sequence 
// in an array of numbers and returns the result as an array. If there is no increasing sequence 
// the function returns 'no'. Write JS program maxSequenceFinder.js that invokes your function with 
// the sample input data below and prints the output at the console. 

function findMaxSequence(arr) {
    var length = 1,
        tempLength = 1,
        indexLastElement = 0,
        maxSeq = [];

    for (var i = 1; i < arr.length; i++) {
        if (arr[i] > arr[i - 1]) {
            tempLength += 1;
            if (tempLength >= length) {
                length = tempLength;
                indexLastElement = i;
            }
        } else {
            tempLength = 1;
        }
    }

    if (length === 1) {
        maxSeq = "no";
    } else {
        for (var j = 0; j < length; j++) {
            maxSeq[j] = arr[indexLastElement - length + 1 + j];
        }
    }

    return maxSeq;
}

console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));