// let slideIndex = 0;

// function showSlides() {
//     const slides = document.querySelectorAll('.slide');
//     for (let i = 0; i < slides.length; i++) {
//         slides[i].style.display = 'none';
//     }

//     slideIndex++;

//     if (slideIndex > slides.length) {
//         slideIndex = 1;
//     }

//     slides[slideIndex - 1].style.display = 'block';
// }

// function prevSlide() {
//     slideIndex--;
//     showSlides();
// }

// function nextSlide() {
//     slideIndex+2;
//     showSlides();
// }

// // 2 saniyədə bir avtomatik dövr etmək üçün
// setInterval(showSlides, 2000);

// document.addEventListener("DOMContentLoaded", function () {
//     let currentSlide = 0;
//     const totalSlides = document.querySelectorAll(".slide").length;
//     const slider = document.querySelector(".slider");
//     const nextButton = document.getElementById("nextButton");
//     const prevButton = document.getElementById("prevButton");

//     nextButton.addEventListener("click", function () {
//         currentSlide = (currentSlide + 1) % totalSlides;
//         updateSlider();
//     });

//     prevButton.addEventListener("click", function () {
//         currentSlide = (currentSlide - 1 + totalSlides) % totalSlides;
//         updateSlider();
//     });

//     function updateSlider() {
//         const translateValue = -currentSlide * 100 + "%";
//         slider.style.transform = "translateX(" + translateValue + ")";
//     }
// });

document.addEventListener("DOMContentLoaded", function () {
    let currentSlide = 0;
    const totalSlides = document.querySelectorAll(".slide").length;
    const slider = document.querySelector(".slider");
    const nextButton = document.getElementById("nextButton");
    const prevButton = document.getElementById("prevButton");

    let intervalId;

    nextButton.addEventListener("click", function () {
        currentSlide = (currentSlide + 1) % totalSlides;
        updateSlider();
    });

    prevButton.addEventListener("mousedown", function () {
        intervalId = setInterval(function () {
            currentSlide = (currentSlide - 1 + totalSlides) % totalSlides;
            updateSlider();
        }, 100);
    });

    document.addEventListener("mouseup", function () {
        clearInterval(intervalId);
    });

    function updateSlider() {
        const translateValue = -currentSlide * 100 + "%";
        slider.style.transform = "translateX(" + translateValue + ")";
    }

    // // Otomatik geçiş için bir interval ekleyebilirsiniz.
    // setInterval(function () {
    //     currentSlide = (currentSlide + 1) % totalSlides;
    //     updateSlider();
    // }, 3000);
});
