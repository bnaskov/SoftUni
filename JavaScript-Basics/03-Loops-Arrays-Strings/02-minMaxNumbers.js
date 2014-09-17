// Write a JavaScript function findMinAndMax(value) that accepts as parameter an array of numbers. 
// The function finds the minimum and the maximum number. Write a JS program minMaxNumbers.js that 
// invokes your function with the sample input data below and prints the output at the console. 

function findMinAndMax(numbers) {
    var minVal = Number.MAX_VALUE;
    var maxVal = Number.MIN_VALUE;
    for (var i = 0; i < numbers.length; i++) {
        if (numbers[i] <= minVal) {
            minVal = numbers[i];
        }
        if (numbers[i] >= maxVal) {
            maxVal = numbers[i];
        }
    }
    return "Min -> " + minVal + "\nMax -> " + maxVal;
}

console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));