// Write a JavaScript function printNumbers(n) that accepts as parameter integer n. 
// The function finds all integer numbers from 1 to n that are not divisible by 4 or by 5. 
// Write a JS program numberChecker.js that invokes your function with
// the sample input data below and prints the output at the console. 

function printNumbers(n) {
    var numbers = "1"
    if (n < 1) {
        return "no";
    } else {
        for (var i = 2; i <= n; i++) {
            if (i % 4 === 0 || i % 5 === 0) {
                continue;                
            } else {
                numbers += ", " + i;
            }
        }
    }
    return numbers;
}

console.log(printNumbers(20));
console.log(printNumbers(-5));
console.log(printNumbers(13));
