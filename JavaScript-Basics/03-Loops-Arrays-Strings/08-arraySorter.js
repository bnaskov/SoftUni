// Sorting an array means to arrange its elements in increasing order. 
// Write a JavaScript function sortArray(value) to sort an array. Use the "selection sort" algorithm: 
// find the smallest element, move it at the first position, find the smallest from the rest, 
// move it at the second position, etc. Write JS program arraySorter.js that invokes your function with 
// the sample input data below and prints the output at the console.Use a second array. 

function sortArray(arr) {
    arr.sort(function (a, b) { return a - b });
    
    var sortedArr = arr[0];
    for (var i = 1; i < arr.length; i++) {
        sortedArr += ", " + arr[i];
    }

    return sortedArr;
}

console.log(sortArray([5, 4, 3, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));
console.log(sortArray([8, 81, 32, 21, 3, 0, 2]));