<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Fragata.Web.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Inicio y registro</title>

    <link rel="stylesheet" href="css/registro.css" />
    <script
  src="https://code.jquery.com/jquery-3.6.0.js"
  integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="
  crossorigin="anonymous"></script>


</head>
<body>
    
    <script>
        window.onload = function () {

            if (localStorage.getItem("Correo") != null && localStorage.getItem("CS") != null) {
                var Correo = localStorage.getItem("Correo");
                var Pass = localStorage.getItem("CS");
                document.getElementById("<%=HiddenField1.ClientID%>").value = Correo;
                document.getElementById("<%=HiddenField2.ClientID%>").value = Pass;
            
            }
        }
    </script>

    <asp:Label ID="CorreoIngresado" style="display:none;" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="ContraseñaIngresada" style="display:none;" runat="server" Text="Label"></asp:Label>
    <section>
    <div class="container">
      <div class="user signinBox">
        <div class="imgBox">
          <img src="imagenes/inicio-foto.jpg" alt="">
        </div>
        <div class="formBox">
         <form id="myFormulario">
            <h2>INICIAR SESIÓN</h2>
            <input runat="server" id="NombreCliente" type="text" name="" placeholder="Nombre del usuario">
            <input type="password" runat="server" id="PasswordUsuario" name="" placeholder="Contraseña">
            <button runat="server" onserverclick="botonSesion_ServerClick2" id="botonSesion">Iniciar</button>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <p class="signup"><a href="#">Registrarse</a></p>
              
</form>
        </div>
      </div>   
   <script>
       $("#myFormulario").on('submit', function (evt) {
           evt.preventDefault();
           // tu codigo aqui
       });
       document.getElementById("<%=Label1.ClientID%>").style.display = "none";
       document.querySelectorAll('#botonSesion').forEach((elemento) => {
           elemento.addEventListener('click', () => {
               const correo = elemento.parentElement.children[1].value;
               const pass = elemento.parentElement.children[2].value;
               document.getElementById("<%=Label1.ClientID%>").textContent = "Validando datos...";
               document.getElementById("<%=Label1.ClientID%>").style.display = "flex";
               console.log(correo);
               localStorage.setItem("Correo", correo);
               localStorage.setItem("CS", pass);
           });
       });
   </script>
        


      <div class="user signupBox">
        <div class="formBox">
          <form class="formulariocrear" runat="server">
            <h2>CREAR UNA CUENTA</h2>
              <asp:FileUpload ID="ArchivoImagen" runat="server" />
            <input type="text" id="Nombre" runat="server" name="" placeholder="Nombre del usuario"/>   
            <input type="email" id="Mail" runat="server" name="" placeholder="Email" required /> 
              <input type="tel" id="Telefono" runat="server" name="" placeholder="Telefono" required /> 

            <input type="password" id="Password" runat="server" placeholder="Crear contraseña"/>
            <input type="password" runat="server" placeholder="Confirmar contraseña"/>
           
              <asp:Button ID="Button"  runat="server" OnClick="Button_Click" Text="Registrarse" />
              <p class="signup"><a href="#">Inicia sesión.</a></p>
              <asp:HiddenField ID="HiddenField1" runat="server"/>
              <asp:HiddenField ID="HiddenField2" runat="server"/>
          </form>
        </div>
        
        <div class="imgBox">
          <img src="imagenes/registro-fondo.jpg" alt="">
        </div>
      </div> 
    </div>


          

  </section>
    <div class="volver-registro">
              <a href="index.aspx">Volver</a>
         </div> 
  


    <script>
        const toggleForm = () => {
            const container = document.querySelector(".container"); const section = document.querySelector("section");

            if (container.classList.contains("active")) {
                container.classList.remove("active");
                section.setAttribute("style", "background-color: #FAAD80")
                return;
            }
            container.classList.add("active");
            section.setAttribute("style", "background-color: #FAAD80")
        }

        const toggleLinks = Array.from(document.querySelectorAll(".signup a"));

        toggleLinks.forEach(toggleLink => {
            toggleLink.addEventListener("click", toggleForm)
        })
    </script>


</body>
</html>
