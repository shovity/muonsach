document.addEventListener('DOMContentLoaded', function () {
    // stich asideBar
    window.addEventListener('scroll', function (event) {
        if (document.documentElement.scrollTop > 250) {
            asideBar.className = 'stick'
        } else {
            asideBar.className = ''
        }
    })
})