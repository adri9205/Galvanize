const name="Tanner";
const letters= name.split('');

const count = letters.reduce((acc, element, index, array) =>{
console.log('acc',acc);
console.log('element', element);
console.log('index', index);
console.log('array', array);
const newAcc = Object.create(acc);
if(newAcc[element]){
newAcc[element]+=1;
}
else{
    newAcc[element]=1;
}
return newAcc;
},{});
console.log(count);
/*to run => node filename


[1,2,3,4].reduce((acc,element)=>
{
    console.log(acc+element);
    return acc+element;
}
);*/
