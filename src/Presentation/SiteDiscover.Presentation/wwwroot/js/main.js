const navbarBurger = document.querySelector(".navbar-burger");
const nav = document.querySelector("nav");
const header = document.querySelector("header");


navbarBurger.addEventListener("click", (e) => {
    nav.classList.toggle("active");
    header.classList.toggle("open");
    document.body.classList.toggle("no-scroll");

});


//$(function () {
//    $(".dropdown-item").click(event => {
//        let selectedLang = $(event.currentTarget).data('lang');
//        console.log(selectedLang);

//        $(".dropdown-toggle").text(selectedLang);
//    })
//});

