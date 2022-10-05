<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Fragata.Web.index" %>

<!DOCTYPE html>
<!-- A VER SI FUNCIONAN LOS CAMBIOS JSJS -->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Fragata Gift</title>


    <!--LIBRERIAS Y FRAMEWORKS-->

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

    <script src="https://use.fontawesome.com/ea603c10d8.js"></script>

    <script src="https://kit.fontawesome.com/e5742c2cba.js" crossorigin="anonymous"></script>


    <script  type = "module"  src = "https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js" > </script> 
    <script  nomodule  src = "https: // unpkg .com / ionicons @ 5.5.2 / dist / ionicons / ionicons.js " > </script>

    <link rel="stylesheet" href="https://unpkg.com/aos@next/dist/aos.css" />
  <script src="https://cdn.jsdelivr.net/npm/web-animations-js@2.3.2/web-animations.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/muuri@0.9.5/dist/muuri.min.js"></script>

     <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ" crossorigin="anonymous"></script>
<!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">

    <!-- CARRUSEL -->
      <script src="js/lightslider.js"></script>
      <link rel="stylesheet" href="css/lightslider.css"/>
      <script src="js/flickity.pkgd.min.js"></script>

      <link rel="stylesheet" href="https://unpkg.com/swiper@7/swiper-bundle.min.css"/>
      <script src="https://unpkg.com/swiper@7/swiper-bundle.min.js"></script>

      

    <!--CODIGO PROPIO-->


    <link rel="stylesheet" href="css/styles.css"/>
    <link rel="stylesheet" href="css/media-queries.css"/>
  
    <script src="js/main.js"></script>



</head>
<body>
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
    <!-- Messenger plugin del chat Code -->
    <div id="fb-root"></div>

    <!-- Your plugin del chat code -->
   
    <!--PANTALLA PRINCIPAL-->

    <div class="principal">

     <div class="logo">
       <img src="imagenes/1630449230492.png"  alt="">


       
     </div>

     <div class="texto-principal">
      <h1>FRAGATA GIFT</h1>
      <div class="linea-text"></div>
      <h3>Te presenta las mejores ideas y creaciones en detalles exclusivos para cada momento u ocasión especial</h3>
     </div>

    </div>

    <!--CONTENEDOR DE CUADRITOS-->
    
    <div class="containerNo" id="Notification" runat="server">
	<div class="rectangle">
		<div class="notification-text">
			<ion-icon style="font-size: 20px" name="notifications"></ion-icon>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
		</div>
	</div>
</div>
    <div class="contenedor-cuadros">



        <a href="Nosotross.aspx"> <!--El error estaba en que llamabas a Ajustes.aspx y no a nosotros.aspx -->
        <div class="cuadro box-color-1" id="cuadro1" data-aos="fade-down" data-aos-delay="10">
            <h2><ion-icon name="leaf-outline"></ion-icon></h2>
            <h3>Nosotros</h3>
        </div>
        </a>

        



        <a href="registro.aspx"> 
        <div class="cuadro box-color-1" data-aos="fade-down" data-aos-delay="20">
            <h2><ion-icon name="person-outline"></ion-icon></h2>
            <h3>Cuenta</h3>
        </div>
        </a>




        



        <a href="Carrito.aspx" id="Carrito"> 
        <div class="cuadro box-color-1" data-aos="fade-down" data-aos-delay="30">
            <h2><ion-icon name="cart-outline"></ion-icon></h2>
            <h3>Carrito</h3>
        </div>
        </a>


    </div>

     



    
    <!--CARRUSEL-->
        
     <h2 class="nuevo-producto">ARREGLOS NATURALES</h2>

        <div class="contenedor-slider" >
            <div class="swiper-container mySwiper">
            <div class="swiper-wrapper">
            <div class="swiper-slide" style="background-color: rgb(255, 255, 255);"></div>
            <script>
                window.onload = function () {
                    setTimeout(function () {
                        document.getElementById("Notification").style.display = "none";
                    }, 5000);

                    if (localStorage.getItem("id") != null) {
                        Id = localStorage.getItem("id");

                        document.getElementById("<%=HiddenField1.ClientID%>").value = Id;
                        console.log(Id)
                    }
                }
            </script>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:Repeater ID="carrusel" runat="server">
                    <ItemTemplate>
                      
                        
                        <div class="swiper-slide">
                  <div class="slider-imagen">
                     <asp:Label ID="Wd" runat="server" Text=""><%#Eval("Id") %></asp:Label>
                      <img src="<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("Fotografia")) %>" 
                          alt="">
                  </div>
                  <div class="slider-contenido">
                      <h5 runat="server">Precio: <span><%#Eval("Precio") %></span></h5>
                      <div class="slider-boton">

                        <!--BOTON MAGICO -->
                        <button runat="server" class="boton" onserverclick="Unnamed_ServerClick" ><ion-icon name="cart-outline"></ion-icon></button>
                       
                      </div>
                    
                  </div>
                </div>    
                    </ItemTemplate>
                </asp:Repeater>

                <!--CAMPO OCULTO -->
                <form runat="server">
                    <asp:HiddenField ID="HiddenField1" runat="server"/>
                </form>
                
                <script>
                   
                    document.querySelectorAll('.boton').forEach((elemento) => {
                        elemento.addEventListener('click', () => {
                            const Id = elemento.parentNode.parentNode.parentNode.childNodes[1].childNodes[1].innerHTML;
                            console.log(Id);
                            localStorage.setItem("id", Id);
                        });
                    });
                </script>
                 <div class="swiper-slide" style="background-color: rgb(255, 255, 255); box-shadow: none; "></div>
                 <div class="swiper-slide" style="background-color: rgb(255, 255, 255); box-shadow: none;"></div>
                
            </div>
           <div class="swiper-button-next"></div>
            <div class="swiper-button-prev"></div>
            <div class="swiper-pagination"></div>
          </div> 
        </div>
       
    <!--SCRIPT DE CARRUSEL-->
    <script>
              var swiper = new Swiper(".mySwiper", {
        slidesPerView: 3,
        spaceBetween: 30,
        autoplay: {
          delay: 1000,
        },
        navigation: {
          nextEl: ".swiper-button-next",
          prevEl: ".swiper-button-prev",
        },
        
      });
    </script>

    <!--SEPARADOS-->

    <div class="separador">
      <div class="texto-separador">
        <h2>Tu diseño favorito, recuerda encargarlo 2 días antes </h2>
      </div>
    </div>

   <!--TARJETAS--> 

   <h2 class="servicios">SERVICIOS</h2>

   <div class="tarjetas" >




     <div class="card" data-aos="fade-down">
       <figure>
         <h2><ion-icon name="flower-outline"></ion-icon></h2>
       </figure>
       <div class="contenido-tarjetas">
         <h3>Arreglos <br> Naturales</h3>
         <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati facere, 
           ut laudantium nam veniam eius ullam architecto pariatur esse libero.</p>
           <a href="ArreglosNaturales.aspx">Ver Más</a>
       </div>
     </div>




     <div class="card" data-aos="fade-down" data-aos-delay="50">
      <figure>
        <h2><ion-icon name="color-palette-outline"></ion-icon></h2>
      </figure>
      <div class="contenido-tarjetas">
        <h3>Arreglos Personalizados</h3>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati facere, 
          ut laudantium nam veniam eius ullam architecto pariatur esse libero.</p>
          <a href="ArreglosPerzonalizados.aspx">Ver Más</a>
          <a href="#">Crear</a>
      </div>
    </div>

     

       
    <div class="card" data-aos="fade-down" data-aos-delay="100">
      <figure>
        <h2><ion-icon name="rose-outline"></ion-icon></h2>
      </figure>
      <div class="contenido-tarjetas">
        <h3>Arreglos Pre-elaborados</h3>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Obcaecati facere, 
          ut laudantium nam veniam eius ullam architecto pariatur esse libero.</p>
          <a href="Productos.aspx">Ver Más</a>
      </div>
    </div>



   </div>

   <!--FOOTER-->

   
   <article class="contacto">
    <div class="IMG_Contacto">
        <img src="imagenes/footer-image.jpg" alt="Imagen_Contacto">
    </div>
    <div class="Informacion_CT">
        <h2>CONTACTANOS <i class="fas fa-headset"></i></h2>
        <p>WhatsApp</p>


        <a href="#">
            <p>+503 7798 1569 <i class="fas fa-phone"></i></p>
        </a>

        <p>Correo electronico</p>

        <a href="#">
            <p>Fragata.Asistencia@gmail.com <i class="fas fa-envelope"></i></p>
        </a>
        
                
    </div>
</article>
<footer class="foot">
<p>- FRAGATA GIFT - 2021 -</p>

<!-- <p class="Icono"><i class="fas fa-bolt"></i></p> -->
<div class="social_icons">
<a href="https://www.facebook.com/Fragata-gift-179955316216920" target="_blank"><i class="fab fa-facebook-square"></i></a>
<a href="https://www.instagram.com/fragatagift/"><i class="fab fa-instagram"></i></a>

</div>
</footer>


   <script src="https://unpkg.com/aos@next/dist/aos.js"></script>
   <script>
       AOS.init();
   </script>

    
</body>
</html>
