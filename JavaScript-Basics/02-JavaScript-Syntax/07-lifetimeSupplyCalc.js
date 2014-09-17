// Write a JavaScript function calcSupply(value) that accepts the following parameters: 
// your age, your maximum age, estimate amount of your favorite food per day(as a number).
// The function calculates how many of the food you will eat for the rest of your life. 
// Write JS program lifetimeSupplyCalc.js that calculates the amount of a few foods that you will eat.
// The result should be printed on the console.Run the program through Node.js.
// Note: we assume that there are no leap years. 

function calcSupply(curreentAge, maxAge, foodPerDay) {
    var maxFood = (maxAge - curreentAge) * 365 * foodPerDay;
    var foods = ["chocolate", "fruits", "nuts", "bacon", "ice-cream"];
    var favFood = foods[Math.round(Math.random(foods.length) * 5)];
    return maxFood + "kg of " + favFood + " would be enough until I am " + maxAge + " years old.";
}

console.log(calcSupply(38, 118, 0.5));
console.log(calcSupply(20, 87, 2));
console.log(calcSupply(16, 102, 1.1));
