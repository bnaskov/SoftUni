// Write a JavaScript function replaceATag(value) that replaces in a HTML document given as string 
// all the tags < a href="…">…</a> with corresponding tags [URL=…] …/ URL]. Write JS program aTagReplacer.js 
// that invokes your function with thesample input data below and prints the output at the console. 

function replaceATag(input) {
    var result = input.replace("<a", "[URL").replace("</a>", "[/URL]");
    var index = result.indexOf(">", result.indexOf("[URL"));
    result = result.substring(0, index) + "]" + result.substring(index + 1);
    return result;
}
console.log(replaceATag("<ul><li><a href='http://softuni.bg'>SoftUni</a></li></ul>"));