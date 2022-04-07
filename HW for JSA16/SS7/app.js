const student=(name,age,adress) => ({ten: name, tuoi: age, diachi: adress})
console.log(student())


var smartPhones=[{name: 'iphone', price: 649},{name: 'Galaxy S6', price: 576},{name: 'Galaxy Note 5', price: 489}]

function gia(phone){
    let a=['iphone','Galaxy S6','Galaxy Note 5'];
    let b=[649,576,489];
    for (let i=0;i<3;i++){
        if(phone== a[i]){
            return b[i];
        }
    }
}

const sum=(x,y,z) =>  {console.log(x+y+z)};
var foo=()=> {alert("hello")};
var m=(a,b) =>{console.log(a+100*b)};

function time(){
    const today=new Date();
    let h=today.getHours();
    let m=today.getMinutes();
    let s=today.getSeconds();
    m=checkTime(m);
    s=checkTime(s);
    document.getElementById("clock").innerHTML= h+":"+m+":"+s;
    setTimeout(time,1000);
}
var checkTime=(i) => {
    if (i<10){
        i="0"+i
    }
}