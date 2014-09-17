// Write a JavaScript function isPrime(value) that checks if an integer number is prime.
// Write JS program primeChecker.js that checks if a few numbers are prime.
// The result should be printed on the console(true or false) on the console. Run the program through Node.js.

function isPrime(value) {
    var sqrRoot = Math.sqrt(value);
    var prime = false;

    for (var i = 2; i <= sqrRoot; i++) {
        if (value % i !== 0) {
            prime = true;
        } else {
            prime = false;
            break;
        }
    }    
    return prime;
}

console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));
