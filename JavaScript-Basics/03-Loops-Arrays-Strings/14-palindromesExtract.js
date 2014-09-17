// Write a JavaScript function findPalindromes(value) that extracts from a given text 
// all palindromes, e.g. "ABBA", "lamal", "exe".Write JS program palindromesExtract.js 
// that invokes your function with the sample input data below and prints the output at the console. 

function findPalindromes(input) {
    var words = input.toLowerCase().split(/\W+/), //you can also use: (/[^a-zA-z]+/) or (/[^\w']+/);
        tempWord = '',
        reversedTempWord = '',
        palindromes = [];
    
    for (var i = 0; i < words.length-1; i++) {
        tempWord = words[i];
        for (var j = 0; j < tempWord.length; j++) {   // you can use tempWord.split('').reverse().join('') instead of this loop
            reversedTempWord += tempWord[tempWord.length - 1 - j];
        }
        if (tempWord === reversedTempWord) {  
            palindromes.push(tempWord);
        }
        reversedTempWord = '';
    }
    
    return palindromes.join(', ');
}

console.log(findPalindromes('There is a man, his name was Bob.'));
console.log(findPalindromes('ABBA is the best; lamal; exe; deVOved; kayAK;'));