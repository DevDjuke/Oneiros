$(document).ready(function () {

    $('#sidebarCollapse').on('click', function () {
        $('#sidebar').toggleClass('active');
        $('#content').toggleClass('active');
    });

    $('.sidebar-li-item').on('click', function () {
        if (!$(this).hasClass('active')) {
            $('.sidebar-li-item').removeClass('active');
            $(this).addClass('active');
        } 
    })
});