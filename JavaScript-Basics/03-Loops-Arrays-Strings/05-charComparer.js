// Write a JavaScript function compareChars(value) that compares two arrays of chars lexicographically (letter by letter). 
// Write JS program charComparer.js that invokes your function with the sample input data below and 
// prints the output at the console. 

function compareChars(arrChars1, arrChars2) {
    var areEqual = "Equal";
    if (arrChars1.length === arrChars2.length) {
        for (var i = 0; i < arrChars1.length; i++) {
            if (arrChars1[i] !== arrChars2[i]) {
                areEqual = "Not Equal";
                break;
            } else {
                continue;
            }
        }
    } else {
        areEqual = "Not Equal";
    }
    return areEqual;
}

console.log(compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], 
    ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']));
console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], 
    ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));
console.log(compareChars(['m', '&', '1', 's', 'g', '8', 'f', 'u', 'b', 'q'], 
    ['m', '&', '1', 's', 'g', '8', 'f', 'u', 'b', 'q']));