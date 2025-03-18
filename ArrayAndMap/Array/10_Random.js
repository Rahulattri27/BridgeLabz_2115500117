let numbers=[];
//push the random number in array
for(let i=0;i<10;i++){
    numbers.push(Math.floor(Math.random()*900)+100);
}
console.log(numbers);
//find the second element in array
let max_element=0;
let second_max=0;
for(let i=0;i<10;i++){
    if(numbers[i]>max_element){
        second_max=max_element;
        max_element=numbers[i];
    }
    else if((numbers[i]>second_max) && (numbers[i]<max_element)){
        second_max=numbers[i];
    }
}
//second  min element in array
let min_element=second_max;
let second_min= max_element;
for(i=0;i<10;i++){
    if(numbers[i]<min_element){
        second_min=min_element;
        min_element=numbers[i];
    }
    else if(numbers[i]>min_element && numbers[i]<second_min){
        second_min=numbers[i];
    }
}
console.log("Second Max element: "+second_max);
console.log("Second Min element: "+second_min);