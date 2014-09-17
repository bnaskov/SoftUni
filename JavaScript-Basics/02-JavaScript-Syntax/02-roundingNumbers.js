// Write a JavaScript function roundNumber(value) that rounds floating - 
// point number using Math.round(), Math.floor().Write a JS program roundingNumbers.js 
// that rounds a few sample values.Run the program through Node.js. 

function roundNumber(value) {    
    var numberFloor = Math.floor(value);
    var numberRound = Math.round(value);
    
    return numberFloor + "\n" + numberRound;
}

console.log(roundNumber(22.7));
console.log(roundNumber(12.3));
console.log(roundNumber(58.7));
