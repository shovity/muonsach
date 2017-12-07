$(document).ready(function () {
    var wH = document.documentElement.clientHeight;
    var bH = document.body.clientHeight;

    $('.list-item').slick({
        dots: true,
        infinite: false,
        slidesToShow: 7,
        slidesToScroll: 7
    });


    
    window.addEventListener('scroll', function (event) {      
        var sct = document.documentElement.scrollTop;
        // stich asideBar
        if (sct > bH - wH - 100) {
            asideBar.className = 'stick-bot'
        } else if (sct > 300) {
            asideBar.className = 'stick'  
        } else {
            asideBar.className = ''
        }

        // stick navbar
        if (sct > 250) {
            navBar.className = 'fixed'
        } else {
            navBar.className = ''
        }
    })
});