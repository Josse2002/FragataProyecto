<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Fragata.Web.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Productos</title>

    <!--ENLACES-->  
<script src="https://use.fontawesome.com/ea603c10d8.js"></script>

    <script src="https://kit.fontawesome.com/e5742c2cba.js" crossorigin="anonymous"></script>

    <link href="css/estilos.css" rel="stylesheet" />
   <link rel="stylesheet" href="css/Products.css">

</head>
<body>
 
     
   <!--PORTAFOLIO-->
    
    <!--ESTE ES EL CODIGO DEL PORTAFOLIO-->
    <div class="portafolio">
      
        <div class="portafolio-contenedor">
        <header>
          <div class="portafolio-logo">
            <h2>ARREGLOS PRE-ELABORADOS</h2>
            <form runat="server">
                <asp:TextBox ID="TextBox1" CssClass="barra-busqueda-portafolio" AutoPostBack="true" runat="server" OnTextChanged="TextBox1_TextChanged"  placeholder="Buscar"></asp:TextBox>
            </form>
             <div class="categorias" id="categorias">
                  <input type="button" id="btnTodos" runat="server" class="botonesCategorias" value="Todos" onserverclick="btnTodos_ServerClick" />

                  <input type="button" id="btnsubmit" runat="server" class="botonesCategorias" value="Peluches" onserverclick="btnsubmit_ServerClick" />
               
                  <input type="button" id="btnRamos" runat="server" class="botonesCategorias" value="Ramos" onserverclick="btnRamos_ServerClick" />
             
                  <input type="button" id="btnDulceros" runat="server" class="botonesCategorias" value="Dulceros" onserverclick="btnDulceros_ServerClick" />
               
                  <input type="button" id="btnBisuteria" runat="server" class="botonesCategorias" value="Bisuteria" onserverclick="btnBisuteria_ServerClick"/>
               
                  <input type="button" id="btnGlobos" runat="server" class="botonesCategorias" value="Globos" onserverclick="btnGlobos_ServerClick"/>
              
            </div>
        </header>


        <section class="grid images" id="grid">
        <asp:Repeater ID="Imagenes" runat="server">
            <ItemTemplate>
               <div class="item" data-categoria="Peluches" data-etiquetas="Peluches Almohadas"
                    data-titulo="<%#Eval("Nombre") %>" data-descripcion="<%#Eval("Descripccion") %>" data-price="<%#Eval("Precio").ToString() %>">
                    <div class="item-contenido">
                       <p style="display: none" id="NombreProducto"><%#Eval("Nombre") %> </p>
                      <img src="<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("Fotografia")) %>" alt="">
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>

        </section>
    
        <!--ventana emergente-->
    
        <section class="emergente" id="overlay">
          <div class="boton">
      <button id="btn-cerrar-popup"><i class="fas fa-times"></i></button>
    </div>
    <div class="contenido">
      <img src="owlcarousel/image-2.png" alt="" />
      <div class="descripcion-contenido">
        <h2 class="tittle">Titulo</h2>
        <p class="descripcion-p">Lorem ipsum dolor sit amet consectetur adipisicing elit. Quos earum tempora explicabo maiores, pariatur
          praesentium, suscipit repellendus tenetur autem eveniet cumque consequatur tempore labore nostrum at
          exercitationem, quae esse dolorem?</p>
        
        <div class="compra">
          <p >Precio <span class="precio">$2.90</span></p>
          <button>Agregar a carrito</button>
        </div>
      </div>

    </div>
        </section>
      </div>
  </div>
  </div>
 
    <script src="https://unpkg.com/web-animations-js@2.3.2/web-animations.min.js"></script>
	<script src="https://unpkg.com/muuri@0.8.0/dist/muuri.min.js"></script>
    <script>
        const grid = new Muuri('.grid', {
            layout: {
                rounding: false
            }
        });

        window.addEventListener('load', () => {
            grid.refreshItems().layout();
            document.getElementById('grid').classList.add('imagenes-cargadas');

            // Agregamos los listener de los enlaces para filtrar por categoria.
            const enlaces = document.querySelectorAll('#categorias a');
            enlaces.forEach((elemento) => {
                elemento.addEventListener('click', (evento) => {
                    evento.preventDefault();
                    enlaces.forEach((enlace) => enlace.classList.remove('activo'));
                    evento.target.classList.add('activo');

                    const categoria = evento.target.innerHTML.toLowerCase();
                    categoria === 'todos' ? grid.filter('[data-categoria]') : grid.filter(`[data-categoria="${categoria}"]`);
                });
            });

            // Agregamos el listener para la barra de busqueda
            document.querySelector('#TextBox1').addEventListener('input', (evento) => {
                const busqueda = evento.target.value;
                grid.filter((item) => item.getElement().dataset.etiquetas.includes(busqueda));
            });

            // Agregamos listener para las imagenes
            const overlay = document.getElementById('overlay');
            document.querySelectorAll('.grid .item img').forEach((elemento) => {
                elemento.addEventListener('click', () => {
                    const ruta = elemento.getAttribute('src');
                    const titulo = elemento.parentNode.parentNode.dataset.titulo;
                    const descripcion = elemento.parentNode.parentNode.dataset.descripcion;
                    const precio = elemento.parentNode.parentNode.dataset.price;

                    overlay.classList.add('activo');
                    document.querySelector('#overlay img').src = ruta;
                    document.querySelector('#overlay .tittle').innerHTML = titulo;
                    document.querySelector('#overlay .descripcion-p').innerHTML = descripcion;
                    document.querySelector('#overlay .precio').innerHTML = "$" + precio;
                });
            });

            // Eventlistener del boton de cerrar
            document.querySelector('#btn-cerrar-popup').addEventListener('click', () => {
                overlay.classList.remove('activo');
            });

            // Eventlistener del overlay
            overlay.addEventListener('click', (evento) => {
                evento.target.id === 'overlay' ? overlay.classList.remove('activo') : '';
            });
        });
  
    </script>

    <footer class="foot">
<p>- FRAGATA GIFT - 2021 -</p>

<!-- <p class="Icono"><i class="fas fa-bolt"></i></p> -->
<div class="social_icons">
<a href="https://www.facebook.com/Fragata-gift-179955316216920" target="_blank"><i class="fab fa-facebook-square"></i></a>
<a href="https://www.instagram.com/fragatagift/" target="_blank"><i class="fab fa-instagram"></i></a>

</div>
</footer>
</body>
</html>
