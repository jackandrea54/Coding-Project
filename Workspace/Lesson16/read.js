function search() {
    var searchBar = document.getElementById("search_bar");
    var search = searchBar.textContent;
    console.log(search)
}
var box = document.getElementById("box")
var intElemClientHeight = box.clientHeight;
var intElemClientWidth = box.clientWidth;
console.log("Height Box:",intElemClientHeight);
console.log("Widht box:",intElemClientWidth);
var boxid = document.getElementsByClassName("rect")
for(i = 0;i < boxid.length; i++) {
    console.log(boxid[i])
}