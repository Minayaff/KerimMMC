(function ($) {
	
	'use strict';
	
	/*------------------------------------
		Preloader
	--------------------------------------*/
	$(window).on('load', function () {
		$('#preloader').delay(350).fadeOut('slow');
		$('body').delay(350).css({'overflow': 'visible'});
	});
	
	/*------------------------------------
		Mobile Menu
	--------------------------------------*/
	$('.main-menu > ul>li').slice(-1).addClass('last-elements');
	
	$('#mobile-menu-active').metisMenu();
	
	$('#mobile-menu-active .has-children > a').on('click', function (e) {
		e.preventDefault();
	});
	
	$(".open-mobile-menu > a").on("click", function (e) {
		e.preventDefault();
		$(".slide-bar").toggleClass("show");
		$("body").addClass("on-side");
		$('.body-overlay').addClass('active');
		$(this).addClass('active');
	});
	
	$(".close-mobile-menu > a").on("click", function (e) {
		e.preventDefault();
		$(".slide-bar").removeClass("show");
		$("body").removeClass("on-side");
		$('.body-overlay').removeClass('active');
		$('.open-mobile-menu > a').removeClass('active');
	});
	
	$('.body-overlay').on('click', function () {
		$(this).removeClass('active');
		$(".slide-bar").removeClass("show");
		$("body").removeClass("on-side");
		$('.open-mobile-menu > a').removeClass('active');
	});
	
	$(".open-sidebar > a").on("click", function (e) {
		e.preventDefault();
		$(".slide-bar").toggleClass("show");
		$("body").addClass("on-side");
		$('.body-overlay').addClass('active');
	});
	
	/*------------------------------------
		Search bar
	--------------------------------------*/
	$('.open-search').on('click', function (event) {
		event.preventDefault();
		$('.search-area').addClass('active');
	});
	
	$('.search-close').on('click', function (event) {
		event.preventDefault();
		$('.search-area').removeClass('active');
	});
	
	
	/*------------------------------------
        Overlay Close
	--------------------------------------*/
	$(window).scroll(function () {
		if ($(this).scrollTop() !== 0) {
			$('#scrollUp').fadeIn();
		} else {
			$('#scrollUp').fadeOut();
		}
	});
	
	$('#scrollUp').on('click', function () {
		$("html, body").animate({scrollTop: 0}, 600);
		return false;
	});
	
	/*------------------------------------
        Main Home Slider
	--------------------------------------*/
	
	if (jQuery(".main-home-slider").length > 0) {
		var HomeSlider = $('.main-home-slider');
		
		HomeSlider.on('init', function (e, slick) {
			var $firstAnimatingElements = $('.home-slide:first-child').find('[data-animation]');
			doAnimations($firstAnimatingElements);
		});
		
		HomeSlider.on('beforeChange', function (e, slick, currentSlide, nextSlide) {
			var $animatingElements = $('.home-slide[data-slick-index="' + nextSlide + '"]').find('[data-animation]');
			doAnimations($animatingElements);
		});
		
		HomeSlider.slick({
			slidesToShow: 1,
			slidesToScroll: 1,
			autoplay: true,
			autoplaySpeed: 10000,
			dots: false,
			fade: true,
			arrows: false,
		});
	}
	
	if (jQuery(".home-slider-2").length > 0) {
		var HomeSlider = $('.home-slider-2');
		
		HomeSlider.on('init', function (e, slick) {
			var $firstAnimatingElements = $('.home-slide-2:first-child').find('[data-animation]');
			doAnimations($firstAnimatingElements);
		});
		
		HomeSlider.on('beforeChange', function (e, slick, currentSlide, nextSlide) {
			var $animatingElements = $('.home-slide-2[data-slick-index="' + nextSlide + '"]').find('[data-animation]');
			doAnimations($animatingElements);
		});
		
		HomeSlider.slick({
			slidesToShow: 1,
			slidesToScroll: 1,
			autoplay: true,
			autoplaySpeed: 10000,
			dots: false,
			fade: true,
			arrows: false,
		});
	}
	
	function doAnimations(elements) {
		var animationEndEvents = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
		elements.each(function () {
			var $this = $(this);
			var $animationDelay = $this.data('delay');
			var $animationType = 'animated ' + $this.data('animation');
			$this.css({
				'animation-delay': $animationDelay,
				'-webkit-animation-delay': $animationDelay
			});
			$this.addClass($animationType).one(animationEndEvents, function () {
				$this.removeClass($animationType);
			});
		});
	}
	
	
	/*------------------------------------
        Odometer Counter
	--------------------------------------*/
	$('.odometer').appear(function (e) {
		var odo = $(".odometer");
		odo.each(function () {
			var countNumber = $(this).attr("data-count");
			$(this).html(countNumber);
		});
	});
	
	/*------------------------------------
        Testimonial Slider
	--------------------------------------*/
	if (jQuery(".testimonial-slider").length > 0) {
		$('.testimonial-slider').slick({
			slidesToShow: 2,
			slidesToScroll: 1,
			dots: false,
			arrows: true,
			prevArrow: '<button type="button" class="slick-prev"><i class="fal fa-angle-left"></i></button>',
			nextArrow: '<button type="button" class="slick-next"><i class="fal fa-angle-right"></i></button>',
			autoplay: true,
			responsive: [
				{
					breakpoint: 992,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
						arrows: false,
					}
				}
			]
		});
	}
	
	if (jQuery(".testimonial-slider-2").length > 0) {
		$('.testimonial-slider-2').slick({
			slidesToShow: 2,
			slidesToScroll: 1,
			dots: false,
			arrows: false,
			autoplay: true,
			responsive: [
				{
					breakpoint: 992,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
						arrows: false,
					}
				}
			]
		});
	}
	
	/*------------------------------------
        Brand Slider
	--------------------------------------*/
	if (jQuery(".brand-slider").length > 0) {
		$('.brand-slider').slick({
			dots: false,
			arrows: false,
			infinite: true,
			autoplay: true,
			slidesToShow: 5,
			slidesToScroll: 1,
			responsive: [
				{
					breakpoint: 1650,
					settings: {
						slidesToShow: 4,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 1200,
					settings: {
						slidesToShow: 3,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 992,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 1
					}
				},
				{
					breakpoint: 767,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}
	
	/*------------------------------------
        Work filter
	--------------------------------------*/
	if (jQuery(".work-filter-wrapper").length > 0) {
		$('.work-filter-wrapper .work-filter-grid').imagesLoaded(function () {
			let $grid = $('.work-filter-wrapper .work-filter-grid').isotope({
				itemSelector: '.grid-item',
				percentPosition: true,
				layoutMode: 'fitRows',
				masonry: {
					columnWidth: '.grid-item'
				}
			});
			
			// filter items on button click
			$('.work-filter-wrapper .work-filter-nav').on('click', 'button', function () {
				let filterValue = $(this).attr('data-filter');
				$grid.isotope({filter: filterValue});
			});
			
			//for menu active class
			$('.work-filter-wrapper .work-filter-nav button').on('click', function (event) {
				$(this).siblings('.active').removeClass('active');
				$(this).addClass('active');
				event.preventDefault();
			});
			
		});
	}
	
	if (jQuery(".masonry-wrapper").length > 0) {
		$('.masonry-wrapper').isotope({
			itemSelector: '.grid-item',
			percentPosition: true,
			masonry: {
				// use outer width of grid-sizer for columnWidth
				columnWidth: '.grid-item'
			}
		})
	}
	
	
	/*------------------------------------
        Contact Map
	--------------------------------------*/
	function basicmap() {
		// Basic options for a simple Google Map
		// For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
		var mapOptions = {
			// How zoomed in you want the map to start at (always required)
			zoom: 11,
			scrollwheel: false,
			// The latitude and longitude to center the map (always required)
			center: new google.maps.LatLng(40.6700, -73.9400), // New York
			// This is where you would paste any style found on Snazzy Maps.
			styles: [
				{
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#f5f5f5"
						}
					]
				},
				{
					"elementType": "labels.icon",
					"stylers": [
						{
							"visibility": "off"
						}
					]
				},
				{
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#616161"
						}
					]
				},
				{
					"elementType": "labels.text.stroke",
					"stylers": [
						{
							"color": "#f5f5f5"
						}
					]
				},
				{
					"featureType": "administrative.land_parcel",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#bdbdbd"
						}
					]
				},
				{
					"featureType": "poi",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#eeeeee"
						}
					]
				},
				{
					"featureType": "poi",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#757575"
						}
					]
				},
				{
					"featureType": "poi.park",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#e5e5e5"
						}
					]
				},
				{
					"featureType": "poi.park",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#9e9e9e"
						}
					]
				},
				{
					"featureType": "road",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#ffffff"
						}
					]
				},
				{
					"featureType": "road.arterial",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#757575"
						}
					]
				},
				{
					"featureType": "road.highway",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#dadada"
						}
					]
				},
				{
					"featureType": "road.highway",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#616161"
						}
					]
				},
				{
					"featureType": "road.local",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#9e9e9e"
						}
					]
				},
				{
					"featureType": "transit.line",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#e5e5e5"
						}
					]
				},
				{
					"featureType": "transit.station",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#eeeeee"
						}
					]
				},
				{
					"featureType": "water",
					"elementType": "geometry",
					"stylers": [
						{
							"color": "#c9c9c9"
						}
					]
				},
				{
					"featureType": "water",
					"elementType": "labels.text.fill",
					"stylers": [
						{
							"color": "#9e9e9e"
						}
					]
				}
			]
		};
		// Get the HTML DOM element that will contain your map
		// We are using a div with id="map" seen below in the <body>
		var mapElement = document.getElementById('contact-map');
		
		// Create the Google Map using our element and options defined above
		var map = new google.maps.Map(mapElement, mapOptions);
		
		// Let's also add a marker while we're at it
		var marker = new google.maps.Marker({
			position: new google.maps.LatLng(40.6700, -73.9400),
			map: map,
			icon: "assets/img/icon/map-marker.png",
			title: 'Biver'
		});
	}
	
	if ($('#contact-map').length != 0) {
		google.maps.event.addDomListener(window, 'load', basicmap);
	}
	
})(jQuery);
