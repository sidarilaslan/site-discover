const navbarBurger = document.querySelector(".navbar-burger");
const nav = document.querySelector("nav");
const header = document.querySelector("header");


navbarBurger.addEventListener("click", (e) => {
    nav.classList.toggle("active");
    header.classList.toggle("open");
    document.body.classList.toggle("no-scroll");
});

