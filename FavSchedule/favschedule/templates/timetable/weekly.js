var userInfo = undefined

fetch ('http://127.0.0.1:5000/getUserID')
.then((res)=> res.json())
.then((user) => {
    console.log(user)
    userInfo = user
    weeklyTableID = user[1];
    const link = `http://127.0.0.1:5000/getTable/${weeklyTableID}`;

    return fetch(link)
})
.then((res) => res.json())
.then(data => {
    console.log(data)
    $(`.navbar-nav nav-flex-icons`).append(`<li class="nav-item">
      ${userInfo}
    </li>`)
    
    var cur_data = data;
    var sum_data = 0
    for(i in cur_data){
        console.log(cur_data[i])
        for (j in cur_data[i]){
            $(`#${i}`).append(` 
            <div id= "a${j}" >
            <div class="custom-control custom-checkbox">
            <input type="checkbox" class="custom-control-input" id="defaultUnchecked">
            <label class="custom-control-label" for="defaultUnchecked">${cur_data[i][j].name}</label>
            </div>
            <small class="text-muted">${cur_data[i][j].time}</small>
            <hr>
          </div>`);
          sum_data = sum_data + cur_data[i][j].length +1
        }    

        //Append the Summary data
        $(".card-title pricing-card-title mb-4").append(`
            ${cur_data[i].length+1}
            <small class="text-muted">${sum_data}</small>
        `)
    }
    
    //SUBMIT NEW DATA
    document.getElementById('submit').addEventListener('click',()=>{
        var d = document.getElementById("day").value;
        var start = document.getElementById("time_start").value;
        var end = document.getElementById("time_end").value;
        var name = document.getElementById("name").value;
        var des = document.getElementById("description").value;
        
        console.log(d,start,end,name,des);

        var i = 0;
        while (cur_data[d][i] != undefined) {
            i++;
        }
        console.log(i);
        cur_data[d][i] = {
            time:start+ '-' + end,
            name: name,
            description: des,
        }
        $(`#${d}`).append(` 
            <div id= "a${i}" >
            <div class="custom-control custom-checkbox">
            <input type="checkbox" class="custom-control-input" id="defaultUnchecked">
            <label class="custom-control-label" for="defaultUnchecked">${cur_data[d][i].name}</label>
            </div>
            <small class="text-muted">${cur_data[d][i].time}</small>
            <hr>
          </div>`);


    });
    
    //POST NEW DATA
    document.getElementById("save").addEventListener('click',(e)=>{
        res = {
            userInfo: userInfo,
            data: cur_data
        }
        fetch(`http://127.0.0.1:5000/update_table`,{
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
                // 'Content-Type': 'application/x-www-form-urlencoded',
              },
            body:JSON.stringify(res),
        
        })
        
        //CHANGE SUM DATA
        document.getElementById("card-title pricing-card-title mb-4").innerHTML = "";
        
        for(i in cur_data){
            $(".card-title pricing-card-title mb-4").append(`
            ${cur_data[i].length+1}
            <small class="text-muted">${sum_data}</small>
        `)
        
        $('#0').find('#a0').remove()

        }

    });
        

});


console.log('HIi');
var data=[{
    1:{
        name:"Bao",
        time:"9:30-8:30",
        description:"lambaitapvenha",

    },
    2:{
        name:"Bao",
        time:"9:30-8:30",
        description:"danh nhau"
    },
    3:{
        name:"Ly",
        time:"9:30-8:30",
        description:"baobeo"
    }
}]

// for (i=0; i<=data.length; i++){

//     for (key in data[i]){
//         var node = document.createElement("button");
//         var cach=document.createElement("br")
//         var job=document.createElement("span")
//         var text=document.createTextNode(data[i][key].name)
//         node.setAttribute("class","button5")
//         job.setAttribute("class","job")
//         job.appendChild(text)
//         var time=document.createElement("span")
//         var text=document.createTextNode(data[i][key].time)
//         time.setAttribute("class","time")
//         time.appendChild(text)
//         var des=document.createElement("span")
//         var text=document.createTextNode(data[i][key].description)
//         des.setAttribute("class","des")
//         des.appendChild(text)
//         document.getElementById("addtask").appendChild(node);
//         document.getElementById("addtask").appendChild(job);
        
//         document.getElementById("addtask").appendChild(time);
//         document.getElementById("addtask").appendChild(des);
//         document.getElementById("addtask").appendChild(cach)             
//     }
// }
// a=document.getElementsByClassName("des")
// console.log(a)
// a[0].style.display="block"
// b=document.getElementsByClassName('job')

// for (i=0; i<a.length; i++){
//     console.log(i)
//     console.log(a[i])
//     console.log(a[i])
    
//     b[i].addEventListener("click", function(e){
//         console.log(e.target)
//         for (i=0; i<a.length; i++){
//             if (b[i]==e.target){
//                 a[i].style.display="none"
//             }
//         }
        
//     });
// }
