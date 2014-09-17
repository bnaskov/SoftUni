// Write a JavaScript function checkBrackets(value) to check if in a given expression 
// the brackets are put correctly. Write JS program bracketsChecker.js that invokes your function
// with thesample input data below and prints the output at the console. 

function checkBrackets(str) {
    var brackets = 0;
    
    for (var char in str) {
        if (str[char] === '(') {
            brackets++;
        }
        else if (str[char] === ')') {
            brackets--;
        }        
        if (brackets < 0) {
            break;
        }
    }
    
    if (brackets === 0) {
        return "correct";
    } else {
        return "incorrect";
    }
}

console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));
