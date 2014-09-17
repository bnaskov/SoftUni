// Write a JavaScript function replaceSpaces(value) that replaces the white-space characters 
// in a text with &nbsp;. Write JS program spaceReplacer.js that invokes your function
// with thesampleinput data below and prints the output at the console. 

function replaceSpaces(input) {
    var text = '';

    for (var i = 0; i < input.length; i++) {
        if (input[i] !== ' ') {
            text += input[i];
        }
    }

    return text;
}

console.log(replaceSpaces('But you were living in another world tryin\' to get your message through'));