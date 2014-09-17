// Write a JavaScript function findMostFreqWord(value) that finds the most frequent word 
// in a text and prints it, as well as how many times it appears in format "word -> count". 
// Consider any non - letter character as a word separator. Ignore the character casing. 
// If several words have the same maximal frequency, print all of them in alphabetical order.
// Write JS program frequentWord.js that invokes your function with the sample input data below 
// and prints the output at the console. 


function findMostFreqWord(value) {
    var sorted = value.toLowerCase().split(/[^a-zA-z]+/), // or .split(/[\W]+/)
        sorted = sorted.sort(),
        wordFreq = {},
        counter = 1,
        max = 0;
    
    if (sorted[sorted.length - 1] === '') {
        sorted.pop();
    }

    for (var i = 1; i < sorted.length; i++) {
        if (sorted[i] === sorted[i - 1]) {
            counter++;
            wordFreq[sorted[i]] = counter;
            if (counter >= max) {
                max = counter;
            }
        } else {
            counter = 1;
        }
    }

    var result = "";
    for (var word in wordFreq) {
        if (wordFreq[word] === max) {
            result += word + " -> " + wordFreq[word] + " times" + "\n";
        }
    }
    return result;
}

console.log(findMostFreqWord('in the middle of the night'));
console.log(findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.'));
console.log(findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'));