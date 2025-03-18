let numbers=[];
//push the random number in array
for(let i=0;i<10;i++){
    numbers.push(Math.floor(Math.random()*900)+100);
}

console.log(numbers);
numbers=numbers.sort();
//Second largest and smallest element
console.log("Second Max element: "+numbers[numbers.length-2]);
console.log("Second Min element: "+numbers[1]);