var queryEl = document.querySelector("#query")
var sortEl = document.querySelector("#sort")
var container = document.querySelector("#container")
var list = container.querySelectorAll('div')
var verbose = document.querySelector('#verbose')
var sortOrder = document.querySelector('#sortOrder')

queryEl.addEventListener("keyup", function(ev){
  [...list].forEach(el=>{
    let regex = new RegExp(ev.target.value, "i")
    el.style.display = ev.target.value=="" || regex.test(el.dataset.name) ? "" : "none"
  })
})

function sortIt(ev) {
  [...list].sort((a,b)=> {
    let parse = (val)=>{return sortEl.value=="name"? val : parseInt(val)}             
    let first = sortOrder.value=="asc" ? a : b
    let second = sortOrder.value=="asc" ? b : a
    return parse(first.dataset[sortEl.value])>parse(second.dataset[sortEl.value])?1:-1
  }) 
    .forEach(node=>container.appendChild(node));
}
sortEl.addEventListener("change", sortIt)
sortOrder.addEventListener("change", sortIt)

verbose.addEventListener("change", function(ev){
   var list = container.querySelectorAll('span:nth-child(n+2)');
  [...list].forEach(el=>{
    el.style.display = ev.target.checked ? "inline" : "none"
    el.style.whiteSpace = ev.target.checked ? "nowrap" : "normal"
  });
  
})

var classes = ["grid", "list", "compactGrid", "compactList"];
displayMode.addEventListener("change", function(ev){
  container.classList.remove(...classes)
  container.classList.add(ev.target.value)
  
})