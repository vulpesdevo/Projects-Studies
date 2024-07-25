// Toggle mobile navigation menu and change icon on click
let barIcon = document.querySelector('#checkbtn');
let navbar = document.querySelector('.nav-list');

barIcon.onclick = () => {
    barIcon.classList.toggle('bx-x');
    navbar.classList.toggle('active');
};

// Highlight the navigation link corresponding to the active section
let sections = document.querySelectorAll('section');
let navLink = document.querySelectorAll('header .nav-list a');
window.onscroll = () => {
    sections.forEach(sec => {
        let top = window.scrollY;
        let offset = sec.offsetTop - 150;
        let height = sec.offsetHeight;
        let id = sec.getAttribute('id');

        if (top >= offset && top < offset + height) {
            navLink.forEach(links => {
                links.classList.remove('active');
                document.querySelector('header .nav-list a[href*=' + id + ']').classList.add('active');
            });
        };
    });

    // Make the navigation header sticky on scroll
    let header = document.querySelector('.nav-header');
    header.classList.toggle('sticky', window.scrollY > 100);

    // Close the mobile menu when a link is clicked
    barIcon.classList.remove('bx-x');
    navbar.classList.remove('active');
};

// Add event listeners to navigation links to set the "active" class
const navLinks = document.querySelectorAll(".nav-list a");

navLinks.forEach(link => {
    link.addEventListener("click", function () {
        // Remove the "active" class from all links
        navLinks.forEach(link => link.classList.remove("active"));
        // Add the "active" class to the clicked link
        this.classList.add("active");
    });
});

// Initialize the Typed.js text animation
let typed = new Typed(".multiple-text", {
    strings: ["Web Developer", "Human"],
    typeSpeed: 100,
    backSpeed: 100,
    backDelay: 1000,
    loop: true
});

document.addEventListener("DOMContentLoaded", function () {
    // Initialize the custom carousel for project items
    let customCarousel = document.querySelector(".custom-carousel");
    let items = customCarousel.querySelectorAll(".item");

    // Add a click event listener to each item to toggle the "active" class
    items.forEach(function (item) {
        item.addEventListener("click", function () {
            // Remove the "active" class from all items except the clicked one
            items.forEach(function (otherItem) {
                if (otherItem !== item) {
                    otherItem.classList.remove("active");
                }
            });

            // Toggle the "active" class for the clicked item
            item.classList.toggle("active");
        });
    });
});

function addRemoveClass(selector, element) {
    document.getElementById(selector + "-btn").addEventListener("click", function () {
        document.getElementsByClassName(selector + "-modal")[0].classList.add("active");
    });
    document.getElementById(selector + "-close").addEventListener("click", function () {
        document.getElementsByClassName(selector + "-modal")[0].classList.remove("active");
    });
}
addRemoveClass("vibely", "modal");
addRemoveClass("bs", "modal");
addRemoveClass("idris", "modal");