const modalOverlay = document.querySelector('.modal-overlay');
const cards = document.querySelectorAll('.card');
const modal = document.querySelector('.modal');

for(let card of cards){
    card.addEventListener("click", function(){
        const imageId = card.getAttribute("id") 
        modalOverlay.classList.add('active')
        modalOverlay.querySelector("iframe").src=`https://www.cursoemvideo.com/.br/${imageId}`
    })
}

document.querySelector(".close-modal").addEventListener("click",function(){
    modalOverlay.classList.remove("active")
    modalOverlay.querySelector("iframe").src=""
})
document.querySelector(".maxmize-modal").addEventListener("click",function(){
    modal.classList.add('active')
    
})