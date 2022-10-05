
    (function ($) {
      $(function () {

        var agSlideFlickity = $('.js-flickity-slider').flickity({
          autoPlay: 2000,
          imagesLoaded: true,
          percentPosition: false,
          prevNextButtons: false,
          initialIndex: 5,
          pageDots: false,
          groupCells: 1
        });

        var agCard = agSlideFlickity.find('.js-carousel-cell .js-card-bg'),
          agTransform = 'string' == typeof document.documentElement.style.transform ? 'transform' : 'WebkitTransform',
          agSlide = agSlideFlickity.data('flickity');



        setInterval(function () {
          agSlideFlickity.on('scroll.flickity', function () {
            agSlide.slides.forEach(function (t, e) {
              var n = agCard[e],
                i = -1 * (t.target + agSlide.x) / 3;

              n.style[agTransform] = 'translateX(' + i + 'px)';
            });
          });
        }, 2000);

        agSlideFlickity.on('dragStart.flickity', function (t, e) {
          document.ontouchmove = function (t) {
            t.preventDefault();
          }
        });

        agSlideFlickity.on('dragEnd.flickity', function (t, e) {
          document.ontouchmove = function (t) {
            return true;
          }
        });

      });
    })(jQuery);

    $(function () {
      /** -----------------------------------------
       * Modulo del Slider 
       -------------------------------------------*/
      var SliderModule = (function () {
        var pb = {};
        pb.el = $('#slider');
        pb.items = {
          panels: pb.el.find('.slider-wrapper > li'),
        }

        // Interval del Slider
        var SliderInterval,
          currentSlider = 0,
          nextSlider = 1,
          lengthSlider = pb.items.panels.length;

        // Constructor del Slider
        pb.init = function (settings) {
          this.settings = settings || { duration: 8000 };
          var items = this.items,
            lengthPanels = items.panels.length,
            output = '';

          // Insertamos nuestros botones
          for (var i = 0; i < lengthPanels; i++) {
            if (i == 0) {
              output += '<li class="active"></li>';
            } else {
              output += '<li></li>';
            }
          }

          $('#control-buttons').html(output);

          // Activamos nuestro Slider
          activateSlider();
          // Eventos para los controles
          $('#control-buttons').on('click', 'li', function (e) {
            var $this = $(this);
            if (!(currentSlider === $this.index())) {
              changePanel($this.index());
            }
          });

        }

        // Funcion para activar el Slider
        var activateSlider = function () {
          SliderInterval = setInterval(pb.startSlider, pb.settings.duration);
        }

        // Funcion para la Animacion
        pb.startSlider = function () {
          var items = pb.items,
            controls = $('#control-buttons li');
          // Comprobamos si es el ultimo panel para reiniciar el conteo
          if (nextSlider >= lengthSlider) {
            nextSlider = 0;
            currentSlider = lengthSlider - 1;
          }

          controls.removeClass('active').eq(nextSlider).addClass('active');
          items.panels.eq(currentSlider).fadeOut('slow');
          items.panels.eq(nextSlider).fadeIn('slow');

          // Actualizamos los datos del slider
          currentSlider = nextSlider;
          nextSlider += 1;
        }

        // Funcion para Cambiar de Panel con Los Controles
        var changePanel = function (id) {
          clearInterval(SliderInterval);
          var items = pb.items,
            controls = $('#control-buttons li');
          // Comprobamos si el ID esta disponible entre los paneles
          if (id >= lengthSlider) {
            id = 0;
          } else if (id < 0) {
            id = lengthSlider - 1;
          }

          controls.removeClass('active').eq(id).addClass('active');
          items.panels.eq(currentSlider).fadeOut('slow');
          items.panels.eq(id).fadeIn('slow');

          // Volvemos a actualizar los datos del slider
          currentSlider = id;
          nextSlider = id + 1;
          // Reactivamos nuestro slider
          activateSlider();
        }

        return pb;
      }());

      SliderModule.init({ duration: 4000 });

    });
 