

/* Scroll to Top */

$(document).ready(function(){
  $(".totop").hide();

  $(function(){
    $(window).scroll(function(){
      if ($(this).scrollTop()>600)
      {
        $('.totop').slideDown();
      } 
      else
      {
        $('.totop').slideUp();
      }
    });

    $('.totop a').click(function (e) {
      e.preventDefault();
      $('body,html').animate({scrollTop: 0}, 500);
    });

  });
});

/* Flex slider #1 (flex-text) - homepage*/

$('.flex-text').flexslider({
  direction: "vertical",
  easing: "easeOutCirc",
  controlNav: true,
  directionNav: false,
  pauseOnHover: true,
  slideshowSpeed: 3000,
  animationSpeed: 3000    
});

/* Flex slider #2 (flex-image) - homepage*/

$('.flex-image').flexslider({
  easing: "easeOutCirc",
  controlNav: true,
  directionNav: true,
  pauseOnHover: true,
  slideshowSpeed: 3000,
  animationSpeed: 3000    
});


/* Header image Carousel */
$(window).load(function(){
  $('.header-caro').carouFredSel({
    responsive: true,
    width: '100%',
    height: "auto",
    auto : {
      duration: 1500
    },
    circular  : true,
    infinite  : false,
    prev : {
      button  : "#car_prev",
      key   : "left"
    },
    next : {
      button  : "#car_next",
      key   : "right"
    },
    swipe: {
      onMouse: true,
      onTouch: true
    },
    scroll: {
      pauseOnHover : true
    },      
    items: {
      visible: {
        min: 1,
        max: 3
      }
    }
  }); 
});


/* Recent posts Carousel */
$(window).load(function(){
  $('.recent-posts-caro').carouFredSel({
    responsive: true,
    width: '100%',
    height: "auto",
    auto : {
      duration: 1500
    },
    circular  : true,
    infinite  : false,
    prev : {
      button  : "#car_prev1",
      key   : "left"
    },
    next : {
      button  : "#car_next1",
      key   : "right"
    },
    swipe: {
      onMouse: true,
      onTouch: true
    },
    scroll: {
      pauseOnHover : true
    },      
    items: {
      visible: {
        min: 1,
        max: 3
      }
    }
  }); 
});

/* Sponsors Carousel */
$(window).load(function(){
  $('.sponsors-caro').carouFredSel({
    responsive: true,
    width: '100%',
    height: "auto",
    auto : {
      duration: 1000
    },
    circular  : true,
    infinite  : false,
    swipe: {
      onMouse: true,
      onTouch: true
    },
    scroll: {
      pauseOnHover : true
    },    
    items: {
      visible: {
        min: 1,
        max: 5
      }
    }
  }); 
});



/* Modal fix */

$('.modal').appendTo($('body'));

/* Support */

$("#slist a").click(function(e){
   e.preventDefault();
   $(this).next('p').toggle(200);
});


/* Portfolio filter */

/* Isotype */

// cache container
var $container = $('#portfolio');
// initialize isotope
$container.isotope();

// filter items when filter link is clicked
$('#filters a').click(function(){
  var selector = $(this).attr('data-filter');
  $container.isotope({ filter: selector });
  return false;
});

/* Pretty Photo for Gallery*/

jQuery(".prettyphoto").prettyPhoto({
overlay_gallery: false, social_tools: false
});