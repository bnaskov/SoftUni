//'use strict';

function someFunction(){
    var result = '';

    if(arguments.length <= 0) {
        result = 'No arguments';
    }

    for(var i in arguments) {
        result += 'Argument of position ' + i + ' is of type ' + typeof arguments[i] + "\n";
    }

    console.log(result);
}

someFunction(true, 'function', 8, 3.14);
someFunction();
console.log();

var func = function(){
    var obj = {};
    obj.name = "Arya";
    return obj;
};

someFunction(this);
someFunction.call(null, 82, "Arya");
someFunction.apply(null, [82, "Arya"]);