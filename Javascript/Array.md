## :blue_book: Javascript Array

<br>**DECLARATION**
```javascript
var myArray;                      //variable can have value set as Array;
var myArray = [];                 //variable declared as Array;
var myArray = [1,2,3];            //variable declared as Array with value;
var myArray = [[1,2,3],[4,5,6]];  //variable declared as Multidimensional Array with value;
var myArray = [[],[]];            //variable declared as Multidimensional Array;
```
:memo: in javascript, **variables are not restricted by object types**;<br>
it can be morphed in code to fit any usability - thus attention must held when structuring code logics;<br>
this could be an issue when naming variables which would have different meanings; this is called *Reusing Variables*;

<br>**USAGE** adding elements to array; :speech_balloon:
```javascript

//[?]Simple Variable ------------------------------;
var myArray;                      //simple variable;

myArray = [1,2,3];                //set Array value;

//[?]Empty Variable -------------------------------;
var myArray = [];                 //array variable;

myArray.push(1);                  //add value to the end of array with push;

//[?]Defined Array --------------------------------;
var myArray = [1,2,3];            //array variable;

myArray.push(4);                  //add value to the end of array with push;
myArray.push([5,6,7]);            //add another dimension value to the array;

//[?]Empty Multidimensional Array -----------------;
var myArray = [[],[]];            //array variable;


```
