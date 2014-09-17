// Write a JavaScript function findMostFreqNum(value) that finds the most frequent number in an array. 
// If multiple numbers appear the same maximal number of times, print the leftmost of them.
// Write JS program numberFinder.js that invokes your function with the sample input data below 
//and prints the output at the console.

function findMostFreqNum(arr) {
    var mostFreqNum = arr[0],
        count = 1,
        tempCount = 1;

    for (var i = 0; i < arr.length - 1; i++) {
        tempCount = 1;
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[i] === arr[j]){
                tempCount += 1;
                if (tempCount > count) {
                    count = tempCount;
                    mostFreqNum = arr[i];
                }
            }
        }  
    }
    return mostFreqNum + " (" + count + " times)";
}

console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));