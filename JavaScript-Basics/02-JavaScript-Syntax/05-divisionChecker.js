// Write a JavaScript function divisionBy3(value) that finds the sum of 
// digits of integer number n(n > 9) and checks if the sum is divided by 3 without remainder.
// Write JS program divisionChecker.js to check a few numbers.
// The result should be printed on the console(“the number is divided by 3 without remainder” or 
// “the number is not divided by 3 without remainder”). Run the program through Node.js. 

function divisionBy3(value) {
    var numLength = value.toString().length;
    var sumDigits = 0;

    for (var i = 0; i < numLength; i++) {
        sumDigits += value % 10;
        value = Math.floor(value / 10);
    }

    if (sumDigits % 3 === 0) {
        return "the number is divided by 3 without remainder"
    } else {
        return "the number is not divided by 3 without remainder"
    }
}

console.log(divisionBy3(12));
console.log(divisionBy3(188));
console.log(divisionBy3(591));
console.log(divisionBy3(10546));
console.log(divisionBy3(97534212));
