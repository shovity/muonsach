$(document).ready(function () {
    $('.list-item').slick({
        dots: true,
        infinite: false,
        slidesToShow: 7,
        slidesToScroll: 7
    });


    // stich asideBar
    window.addEventListener('scroll', function (event) {
        if (document.documentElement.scrollTop > 250) {
            asideBar.className = 'stick'
        } else {
            asideBar.className = ''
        }
    })
});