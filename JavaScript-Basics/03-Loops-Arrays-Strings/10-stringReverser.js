// Write a JavaScript function reverseString(value) that reverses string and returns it. 
// Write JS program stringReverser.js that invokes your function with 
// the sample input data below and prints the output at the console. 

function reverseString(str) {
    var revString = '';
    for (var i = 0; i < str.length; i++) {
        revString += str[str.length - 1 - i];
    }
    return revString;
}

console.log(reverseString('sample'));
console.log(reverseString('softUni'));
console.log(reverseString('java script'));