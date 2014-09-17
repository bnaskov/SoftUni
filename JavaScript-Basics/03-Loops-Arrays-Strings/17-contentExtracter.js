// Write a JavaScript function extractContent(value) that extracts the text content 
// from given HTML fragment(givenas string).The function should return anything that is in a tag, 
// without the tags. Write JS program contentExtracter.js that invokes your function 
// with thesample input data below and prints the output at the console. 

function extractContent(input) {
    var result = "";
    var isContent = true;
    for (var i = 0; i < input.length; i++) {
        if (input[i] === "<") {
            isContent = false;
        } else if (input[i] === ">") {
            isContent = true;
        } else if (isContent) {
            result += input[i];
        }
    }
    return result;
}
console.log(extractContent("<p>Hello</p><a href='http://w3c.org'>W3C</a>"));
console.log(extractContent("<ul><li><a href='http://softuni.bg'>SoftUni</a></li></ul>"));