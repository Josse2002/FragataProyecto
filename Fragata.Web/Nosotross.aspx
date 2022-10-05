<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nosotross.aspx.cs" Inherits="Fragata.Web.Nosotross" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Nosotros</title>

    <!-- ICONOS -->
    <script  type = "module"  src = "https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js" ></script> 
    
   
   <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/css/bootstrap.min.css">
    <!-- ESTILOS PROPIOS -->
    <link rel="stylesheet" href="css/estilos.css" />
    <link rel="stylesheet" href="css/nosotros.css" /> 
</head>
<body>
    <!-- Imagen de fondo -->

    <div class="separador">
      <div class="texto-separador">
        <h2>UN POCO SOBRE NOSOTROS </h2>
      </div>
    </div>
    

    <div class="contenedor-cuadros">
        <a> <!--El error estaba en que llamabas a Ajustes.aspx y no a nosotros.aspx -->
        <div class="cuadro box-color-1" id="cuadro1" data-aos="fade-down" data-aos-delay="10">
            <h2><ion-icon name="extension-puzzle-outline"></ion-icon></h2>
            <h3>Año 2019, la idea de fundar un negocio en el cual las ideas y manualidades sean un objetivo surge con el nombre Fragata Gift, desde el año 2015 trabajando con manualidades Francely Colindres, actual dueña invierte en sacarle mas provecho a su don de realizar distintos arreglos florales y regalos decorativos, con la frase “Hacer todo con amor y dedicación” Fragata siempre busca satisfacer a los clientes, adquirir mas experiencia y sobre todo, brindar un mejor servicio a aquellos que hacen compras en Fragata Gift</h3>
        </div>
        </a>
      
    </div>

    <h2 class="text-center">Nuestra ubicación</h2>
    <div>
        <iframe style="
             width: 80%;
    margin: 2% 10%;
    height: 357px;
    border: solid 3px #eee;" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d968.9763605957186!2d-89.72563017084539!3d13.724174302213102!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zMTPCsDQzJzI3LjAiTiA4OcKwNDMnMzAuMyJX!5e0!3m2!1ses-419!2ssv!4v1633989251609!5m2!1ses-419!2ssv" width="1200" height="400" style="border:0;" allowfullscreen="" loading="lazy"></iframe>
    </div>

    
</body>
</html>
