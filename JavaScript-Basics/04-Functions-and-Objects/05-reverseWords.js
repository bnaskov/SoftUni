// Write a JavaScript function reverseWordsInString(str) to reverse the characters of every word 
// in the string but leaves the words in the same order. Words are considered to be sequences of characters 
// separated by spaces. Write a JavaScript program reverseWords.js 

function reverseWordsInString(str) {
    var words = str.split(" "),
        revWords = [],
        revWord,
        tempWord = "";

    for (var i = 0; i < words.length; i++) {
        tempWord = words[i];
        revWord = "";
        for (var j = 0; j < tempWord.length; j++) {
            revWord += tempWord[tempWord.length - 1 - j];
        }
        revWords.push(revWord);
    }

    return revWords.join(" ")
}

console.log(reverseWordsInString("Hello, how are you."));
console.log(reverseWordsInString("Life is pretty good, isn’t it?"));