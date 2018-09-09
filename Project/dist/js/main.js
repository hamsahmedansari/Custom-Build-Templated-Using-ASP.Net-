$(document).ready(function(){



    $('.owl-carousel').owlCarousel({
        loop: false,
        margin: 1,
        responsiveClass: true,
        autoplay: true,
        autoplayTimeout: 1000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            }
        }
    });


    $(".img_popup").click(function () {

        $(".img_popup_model").attr('src', $(this).attr('src'));

    });

    $(".navbar-nav li a[href^='#'],a[href^='#'].scroll_top").on('click', function (e) {

        // prevent default anchor click behavior
        e.preventDefault();

        // store hash
        var hash = this.hash;

        var navOffset;
        navOffset = $('.navbar').height();

        // animate
        $('html, body').animate({
            scrollTop: $(hash).offset().top - 70
        }, 300, function () {

            console.log(navOffset);
            // when done, add hash to url
            // (default click behaviour)
        });
    });
    $(window).on('scroll', function () {
        var scrollPos = window.pageYOffset;
        if (scrollPos > 400) {
            $(".scroll_top").removeClass("d-none");
        } else if (scrollPos <= 400) {
            $(".scroll_top").addClass("d-none");
        }
    });
});
