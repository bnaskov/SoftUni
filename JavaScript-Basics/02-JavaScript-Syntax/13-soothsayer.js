// Write a JavaScript function soothsayer(value) that accepts the following parameters (source arrays): 
// array of numbers, array of programming languages, array of cities, array of cars.
// Each array must consist of five elements. The function must return an array result[] 
// that consists of one random item from each source array. Write a JS program that prints on the console 
// the following output: “ You will work result[0] years on result[1]. You will live in result[2] and 
// drive result[3].”. Run the program through Node.js. 

function soothsayer(years, lang, city, car) {
    var randomYear = years[Math.floor(Math.random() * years.length)];
    var randomLang = lang[Math.floor(Math.random() * lang.length)];
    var randomCity = city[Math.floor(Math.random() * city.length)];
    var randomCar = car[Math.floor(Math.random() * car.length)];
    var result = [randomYear, randomLang, randomCity, randomCar];
    
    return "You will work " + randomYear + " years on " + randomLang +
        ".\nYou will live in " + randomCity + " and drive " + randomCar;
}

console.log(soothsayer([3, 5, 2, 7, 9], ["Java", "Python", "C#", "JavaScript", "Ruby"],
    ["Silicon Valley", "London", "Las Vegas", "Paris", "Sofia"], ["BMW", "Audi", "Lada", "Skoda", "Opel"]));