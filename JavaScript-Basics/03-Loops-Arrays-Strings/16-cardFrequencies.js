// Write a JavaScript function findCardFrequency(value) that that accepts the following parameters: 
// array of several cards(face + suit), separated by a space. The function calculates and prints 
// at the console the frequency of each card face in format "card_face -> frequency".
// The frequency is calculated by the formula appearances / N and is expressed in percentages with 
// exactly 2 digits after the decimal point. The card faces with their frequency should be printed
// in the order of the card face's first appearance in the input. The same card can appear multiple times 
// in the input, but its face should be listed only once in the output. Write JS program cardFrequencies.js 
// that invokes your function with the sample input data below and prints the output at the console. 

function findCardFrequency(input) {
    var cards = input.split(' ');
    var result = [];

    for (var i = 0; i < cards.length; i++) {
        var card = cards[i].substring(0, cards[i].length - 1);
        if (result[card]) {
            result[card]++;
        } else {
            result[card] = 1;
        }
    }

    var printed = [];
    for (var j = 0; j < cards.length; j++) {
        var current = cards[j].substring(0, cards[j].length - 1);
        if (printed.indexOf(current) < 0) {
            printed.push(current);
            console.log("%s -> %s%", current, (result[current] / cards.length * 100).toFixed(2));
        }
    }
}
findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');