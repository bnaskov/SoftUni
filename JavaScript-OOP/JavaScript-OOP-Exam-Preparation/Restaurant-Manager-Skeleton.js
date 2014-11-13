function processRestaurantManagerCommands(commands) {
    'use strict';

    Object.prototype.extends = function (parent) {
    	if (!Object.create) {
    		Object.prototype.create = function (proto) {
    			function F(){}
    			F.prototype = proto;
    			return new F;	
    		}
    	};

        this.prototype = Object.create(parent.prototype);
        //Must have constructor
        this.prototype.constructor = this;
    }

    Object.prototype.isString = function () {
    	return this instanceof String;
    }

    // isEmpty function()
    String.prototype.isEmpty = function () {
    	return this == '';
    }

    var RestaurantEngine = (function () {
        var _restaurants, _recipes;
        var globalConstants = {
        	UNIT_GRAMS: 'g',
        	UNIT_MILLILITERS: 'ml';
        };

        function initialize() {
            _restaurants = [];
            _recipes = [];
        }

        var Restaurant = (function () {
            function Restaurant(name, location){
            	this.setName(name);
            	this.setLocation(location);
            	this._recipes = [];
            }

            Restaurant.prototype.getName = function (){
            	return this._name;
            }

            Restaurant.prototype.setName = function (name){
            	if (!name || !name.isString()) {
            		throw new Error('Name cannot be null or empty!');
            	};

            	this._name = name;
            }

            Restaurant.prototype.getLocation = function (){
            	return this._location;
            }

            Restaurant.prototype.setLocation = function (location){
            	if (!location || !location.isString()) {
            		throw new Error('Location cannot be null or empty!');
            	};

            	this._location = location;
            }

            Restaurant.prototype.addRecipe = function (recipe){
            	// TODO
            }

            Restaurant.prototype.removeRecipe = function (recipe){
            	// TODO
            }

            Restaurant.prototype.printRestaurantMenu = function(){
            	// TODO
            }

            return Restaurant;
        }());

        var Recipe = (function () {	
            function Recipe(name, price, calories, quantity, time, unit){
            	if (this.constructor === Recipe) {
                	throw new Error('Cannot instantiate abstract class Recipe.');
            	}

            	this.setName(name);
            	this.setPrice(price);
            	this.setCalories(calories);
            	this.setQuantity(quantity);
            	this.setTime(time);
            	this._unit = unit;
            }

            Recipe.prototype.getName = function (){
            	return this._name;
            }

            Recipe.prototype.setName = function (name){
            	if (!name || !name.isString()) {
            		throw new Error('The time is required.');
            	};

            	this._name = name;
            }

            Recipe.prototype.getPrice = function (){
            	return this._price;
            }

            Recipe.prototype.setPrice = function (price){
            	if (price <= 0) {
            		throw new Error('The price must be positive.');
            	};

            	this._price = price;
            }

            Recipe.prototype.getCalories = function (){
            	return this._calories;
            }

            Recipe.prototype.setCalories = function (calories){
            	if (calories <= 0) {
            		throw new Error('The calories must be positive.');
            	};

            	this._calories = calories;
            }

            Recipe.prototype.getQuantity = function (){
            	return this._quantity;
            }

            Recipe.prototype.setQuantity = function (quantity){
            	if (quantity <= 0) {
            		throw new Error('The quantity must be positive.');
            	};

            	this._quantity = quantity;
            }

            Recipe.prototype.getTime = function (){
            	return this._time;
            }

            Recipe.prototype.setTime = function (time){
            	if (time <= 0) {
            		throw new Error('The time must be positive.');
            	};

            	this._time = time;
            }

            return Recipe;
        }());

        var Meal = (function () {
            function Meal(name, price, calories, quantity, time, isVegan){
            	if (this.constructor === Meal) {
                	throw new Error('Cannot instantiate abstract class Meal.');
            	}

            	Recipe.call(this, name, price, calories, quantity, time, globalConstants.UNIT_GRAMS);
            	this._isVegan = isVegan;
            }

            Meal.extends(Recipe);

            Meal.prototype.toggleVegan = function(){
            	this._isVegan = !this._isVegan;
            }

            return Meal;
        }());

        var Drink = (function () {
            function Drink(name, price, calories, quantity, time, isCarbonated){
            	Recipe.call(this, name, price, calories, quantity, time, globalConstants.UNIT_MILLILITERS);
            	this._isCarbonated = isCarbonated;
            }

            Drink.extends(Recipe);

            return Drink;
        }());

        var Salad = (function () {
            function Salad(name, price, calories, quantity, time, containsPasta){
            	Meal.call(this, name, price, calories, quantity, time);
            	this._containsPasta = containsPasta;
            }

            Salad.extends(Meal);

            return Salad;
        }());

        var MainCourse = (function () {
            function MainCourse(name, price, calories, quantity, time, type){
            	Meal.call(this, name, price, calories, quantity, time);
            	this._type = type;
            }

            MainCourse.extends(Meal);

            return MainCourse;
        }());

        var Dessert = (function () {
            function Dessert(name, price, calories, quantity, time, isVegan){
            	Meal.call(this, name, price, calories, quantity, tim, isVegan);
            	this._withSugar = true;
            }

            Dessert.extends(Meal);

            Dessert.prototype.toggleSugar = function(){
            	this._withSugar = !this._withSugar;
            }

            return Dessert;
        }());

        var Command = (function () {

            function Command(commandLine) {
                this._params = new Array();
                this.translateCommand(commandLine);
            }

            Command.prototype.translateCommand = function (commandLine) {
                var self, paramsBeginning, name, parametersKeysAndValues;
                self = this;
                paramsBeginning = commandLine.indexOf("(");

                this._name = commandLine.substring(0, paramsBeginning);
                name = commandLine.substring(0, paramsBeginning);
                parametersKeysAndValues = commandLine
                    .substring(paramsBeginning + 1, commandLine.length - 1)
                    .split(";")
                    .filter(function (e) { return true });

                parametersKeysAndValues.forEach(function (p) {
                    var split = p
                        .split("=")
                        .filter(function (e) { return true; });
                    self._params[split[0]] = split[1];
                });
            }

            return Command;
        }());

        function createRestaurant(name, location) {
            _restaurants[name] = new Restaurant(name, location);
            return "Restaurant " + name + " created\n";
        }

        function createDrink(name, price, calories, quantity, timeToPrepare, isCarbonated) {
            _recipes[name] = new Drink(name, price, calories, quantity, timeToPrepare, isCarbonated);
            return "Recipe " + name + " created\n";
        }

        function createSalad(name, price, calories, quantity, timeToPrepare, containsPasta) {
            _recipes[name] = new Salad(name, price, calories, quantity, timeToPrepare, containsPasta);
            return "Recipe " + name + " created\n";
        }

        function createMainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type) {
            _recipes[name] = new MainCourse(name, price, calories, quantity, timeToPrepare, isVegan, type);
            return "Recipe " + name + " created\n";
        }

        function createDessert(name, price, calories, quantity, timeToPrepare, isVegan) {
            _recipes[name] = new Dessert(name, price, calories, quantity, timeToPrepare, isVegan);
            return "Recipe " + name + " created\n";
        }

        function toggleSugar(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }
            recipe = _recipes[name];

            if (recipe instanceof Dessert) {
                recipe.toggleSugar();
                return "Command ToggleSugar executed successfully. New value: " + recipe._withSugar.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleSugar is not applicable to recipe " + name + "\n";
            }
        }

        function toggleVegan(name) {
            var recipe;

            if (!_recipes.hasOwnProperty(name)) {
                throw new Error("The recipe " + name + " does not exist");
            }

            recipe = _recipes[name];
            if (recipe instanceof Meal) {
                recipe.toggleVegan();
                return "Command ToggleVegan executed successfully. New value: " +
                    recipe._isVegan.toString().toLowerCase() + "\n";
            } else {
                return "The command ToggleVegan is not applicable to recipe " + name + "\n";
            }
        }

        function printRestaurantMenu(name) {
            var restaurant;

            if (!_restaurants.hasOwnProperty(name)) {
                throw new Error("The restaurant " + name + " does not exist");
            }

            restaurant = _restaurants[name];
            return restaurant.printRestaurantMenu();
        }

        function addRecipeToRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }
            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.addRecipe(recipe);
            return "Recipe " + recipeName + " successfully added to restaurant " + restaurantName + "\n";
        }

        function removeRecipeFromRestaurant(restaurantName, recipeName) {
            var restaurant, recipe;

            if (!_recipes.hasOwnProperty(recipeName)) {
                throw new Error("The recipe " + recipeName + " does not exist");
            }
            if (!_restaurants.hasOwnProperty(restaurantName)) {
                throw new Error("The restaurant " + restaurantName + " does not exist");
            }

            restaurant = _restaurants[restaurantName];
            recipe = _recipes[recipeName];
            restaurant.removeRecipe(recipe);
            return "Recipe " + recipeName + " successfully removed from restaurant " + restaurantName + "\n";
        }

        function executeCommand(commandLine) {
            var cmd, params, result;
            cmd = new Command(commandLine);
            params = cmd._params;

            switch (cmd._name) {
                case 'CreateRestaurant':
                    result = createRestaurant(params["name"], params["location"]);
                    break;
                case 'CreateDrink':
                    result = createDrink(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["carbonated"]));
                    break;
                case 'CreateSalad':
                    result = createSalad(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["pasta"]));
                    break;
                case "CreateMainCourse":
                    result = createMainCourse(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]), params["type"]);
                    break;
                case "CreateDessert":
                    result = createDessert(params["name"], parseFloat(params["price"]), parseInt(params["calories"]),
                        parseInt(params["quantity"]), params["time"], parseBoolean(params["vegan"]));
                    break;
                case "ToggleSugar":
                    result = toggleSugar(params["name"]);
                    break;
                case "ToggleVegan":
                    result = toggleVegan(params["name"]);
                    break;
                case "AddRecipeToRestaurant":
                    result = addRecipeToRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "RemoveRecipeFromRestaurant":
                    result = removeRecipeFromRestaurant(params["restaurant"], params["recipe"]);
                    break;
                case "PrintRestaurantMenu":
                    result = printRestaurantMenu(params["name"]);
                    break;
                default:
                    throw new Error('Invalid command name: ' + cmdName);
            }

            return result;
        }

        function parseBoolean(value) {
            switch (value) {
                case "yes":
                    return true;
                case "no":
                    return false;
                default:
                    throw new Error("Invalid boolean value: " + value);
            }
        }

        return {
            initialize: initialize,
            executeCommand: executeCommand
        };
    }());


    // Process the input commands and return the results
    var results = '';
    RestaurantEngine.initialize();
    commands.forEach(function (cmd) {
        if (cmd != "") {
            try {
                var cmdResult = RestaurantEngine.executeCommand(cmd);
                results += cmdResult;
            } catch (err) {
                results += err.message + "\n";
            }
        }
    });

    return results.trim();
}

// ------------------------------------------------------------
// Read the input from the console as array and process it
// Remove all below code before submitting to the judge system!
// ------------------------------------------------------------

(function() {
    var arr = [];
    if (typeof (require) == 'function') {
        // We are in node.js --> read the console input and process it
        require('readline').createInterface({
            input: process.stdin,
            output: process.stdout
        }).on('line', function(line) {
            arr.push(line);
        }).on('close', function() {
            console.log(processRestaurantManagerCommands(arr));
        });
    }
})();
