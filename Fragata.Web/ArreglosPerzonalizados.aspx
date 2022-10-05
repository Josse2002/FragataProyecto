<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArreglosPerzonalizados.aspx.cs" Inherits="Fragata.Web.ArreglosPerzonalizados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Arreglos Personalizados</title>

    <!--ENLACES-->
    <script src="js/jquery-3.6.0.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/web-animations-js@2.3.2/web-animations.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/muuri@0.9.5/dist/muuri.min.js"></script>
    <script src="js/jquery-3.6.0.min.js"></script>
    <link rel="stylesheet" href="css/Personal.css">

</head>
<body>
 
     
   <!--PORTAFOLIO-->
    
    <!--ESTE ES EL CODIGO DEL PORTAFOLIO-->
    <div class="portafolio">
      
        <div class="portafolio-contenedor">
        <header>
          <div class="portafolio-logo">
            <h2>ARREGLOS PERSONALIZADOS</h2>
            <P>Puedes encontrar muchos arreglos que nuestros clientes han personalizado así como tu tambien
                puedes hacerlo
            </P>
            <form action="">
              <input type="text" class="barra-busqueda-portafolio" id="barra-busqueda-portafolio" placeholder="Buscar producto">
            </form>
            <div class="categorias-portafolio" id="categorias-portafolio">
              
            </div>
        </header>
        <section class="grid images" id="grid">
          <div class="item" data-categoria="odalis" data-etiquetas="Juve sexy autos calles"
            data-descripcion="1-hola,es un gusto">
            <div class="item-contenido">
              <img src="imagenes/ciudad1.png" alt="">
            </div>
          </div>
    
          <div class="item" data-categoria="juve" data-etiquetas="persona cabello"
            data-descripcion="1-hola,es un gusto">
            <div class="item-contenido">
              <img src="imagenes/persona1.png" alt="">
            </div>
          </div>
    
          <div class="item" data-categoria="gatito" data-etiquetas="animal pelaje"
            data-descripcion="1-hola,es un gusto">
            <div class="item-contenido">
              <img src="imagenes/animal1.png" alt="">
            </div>
          </div>
    
          <div class="item" data-categoria="panda" data-etiquetas="rio lagos paisajes"
            data-descripcion="1-hola,es un gusto">
            <div class="item-contenido">
              <img src="imagenes/paisaje1.png" alt="">
            </div>
          </div>
    
    
        </section>
    
        <!--ventana emergente-->
    
        <section class="emergente " id="emergente">
          <div class="contenedor-img">
            <button id="btn-cerrar-popup"><i class="fas fa-times"></i></button>
            <img src="" alt="">
          </div>
          <p class="descripcion"></p>
        </section>
      </div>
  </div>
  </div>
  
    
    <script>
      const grid = new Muuri('.grid', {
        layout: {
          rounding: false
        }
      });
  
      window.addEventListener('load', () => {
        grid.refreshItems().layout();
        document.getElementById('grid').classList.add('imagenes-cargadas');
  
        //Agregue los listener de los enlaces para filtrar por categoria.
        const enlaces = document.querySelectorAll('#categorias-portafolio a');
        enlaces.forEach((elemento) => {
          elemento.addEventListener('click', (evento) => {
            evento.preventDefault();
            enlaces.forEach((enlace) => enlace.classList.remove('activo'));
            evento.target.classList.add('activo');
  
            const categoria = evento.target.innerHTML.toLowerCase();
            categoria === 'todos' ? grid.filter('[data-categoria]') : grid.filter(`[data-categoria="${categoria}"]`);
          });
        });
  
        //Agregue el listener para la barra de busqueda.
        document.querySelector('#barra-busqueda-portafolio').addEventListener('input', (evento) => {
          const busqueda = evento.target.value;
          grid.filter((item) => item.getElement().dataset.etiquetas.includes(busqueda));
        });
  
        //agregue listener para las imagenes.
  
        const emergente = document.getElementById('emergente');
        document.querySelectorAll('.grid .item img').forEach((elemento) => {
  
  
          elemento.addEventListener('click', () => {
            const ruta = elemento.getAttribute('src');
            const descripcion = elemento.parentNode.parentNode.dataset.descripcion;
  
            emergente.classList.add('activo');
            document.querySelector('#emergente img').src = ruta;
            document.querySelector('#emergente .descripcion').innerHTML = descripcion;
          });
        });
  
        //eventlistener del boton cerrar.
        document.querySelector('#btn-cerrar-popup').addEventListener('click', () => {
          emergente.classList.remove('activo');
        });
  
        emergente.addEventListener('click', () => {
          evento.target.id === 'emergente' ? emergente.classList.remove('activo') : '';
        });
  
      });
    </script>
</body>
</html>


