<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="formCompra.aspx.cs" Inherits="Fragata.Web.formCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Pedido</title>
	<!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ" crossorigin="anonymous"></script>
	
<!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">


   <link rel="stylesheet" href="css/compras.css" />
</head>
<body>
    


 
<div class="container" id="container">
	<div class="form-container sign-up-container">
		<form runat="server" >
			
			<h1>Pedido con envio</h1>
			
			<span>Llena los campos solicitados.</span>


		<div id="pedido" class="pedido"> 

			<div class="input">
				<label for="fecha-pedido">Codigo del pedido:</label>
				<input runat="server" id="CodigoPedido" type="text" placeholder="..." name="fecha-pedido" disabled="disabled" />
			</div>

			<div class="input">
				<label for="fecha-pedido">Nombre completo:</label>
				<input type="text"  placeholder="..." name="fecha-pedido" runat="server" id="NombreCompleto" />
			</div>

		</div>

		<div id="envio" class="envio"> 

			<div class="input">
				<label for="fecha-pedido">Fecha de envío:</label>
				<input type="date" runat="server" id="FechaEnvio" placeholder="Fecha" name="fecha-pedido" />
			</div>

			<div class="input">
				<label for="direccion-pedio">Dirección a enviar:</label>
				<input type="text" runat="server" id="DireccionEnvio" placeholder="..." name="direccion-pedio" />
			</div>

			<div class="input">
				<label for="Telefono">Numero de telefono:</label>
				<input type="tel" runat="server" id="TelefonoEnvio" placeholder="..." name="Telefono"/>
			</div>
			<div class="input">
				<label for="Correo">Correo electronico:</label>
				<input type="email" id="CorreoEnvio" runat="server" placeholder="..." name="Correo"/>
			</div>

			<div class="input">
				<h4>Total a pagar: <span runat="server" id="TotalPagarEnvio">$5.25</span></h4>
			</div>

		</div>
			

			<button id="boton-envio" >Siguiente</button>
			<button style="display: none" runat="server" id="BotonEnvio" onserverclick="BotonEnvio_ServerClick">Finalizar</button>
		</form>


		<script>
			var Envio = document.getElementById("envio")
			Envio.style.display = "none"
			var Botón = document.getElementById("boton-envio")
			var FormPedido = document.getElementById("pedido")

			Botón.addEventListener("click", function (e) {
				e.preventDefault();
				if (Botón.textContent == "Siguiente") {
					FormPedido.style.display = "none"
                    FormPedido.style.flexDirection = "column"
					Botón.textContent = "Finalizar"
					Envio.style.display = "flex";
					this.style.display = "none";
					document.getElementById("BotonEnvio").style.display = "flex";
                }
			}, false)

        </script>

		<script>
            window.onload = function () {

                if (localStorage.getItem("Codigo") != null && localStorage.getItem("Nombre") != null && localStorage.getItem("fecha") != null) {
                    var Codigo = localStorage.getItem("Codigo");
					var Nombre = localStorage.getItem("Nombre");
                    var Fecha = localStorage.getItem("fecha");
                    document.getElementById("<%=Label2.ClientID%>").value = Codigo;
					document.getElementById("<%=Label3.ClientID%>").value = Nombre;
                    document.getElementById("<%=Label4.ClientID%>").value = fecha;
                }
            }
        </script>

		

	</div>
	<div class="form-container sign-in-container">
		<form  id="myFormulario">
			<h1>Pedido</h1>
		
			<asp:Label ID="Label1" style="display:none" runat="server" Text="Label"></asp:Label>
			<span>Llena los campos solicitados</span>

			<div class="input">
				<label for="fecha-pedido">Codigo del pedido:</label>
				<input type="text" runat="server" id="CodigoPedidoEnvio" placeholder="..." name="fecha-pedido" disabled="disabled" />
			</div>

			<div class="input">
				<label for="fecha-pedido">Nombre completo:</label>
				<input type="text" runat="server" id="NombreUser" placeholder="..." name="fecha-pedido" />
			</div>
			
			<div class="input">
				<label for="fecha-pedido">Fecha de retiro:</label>
				<input type="date" runat="server" id="FechaRetiro" value="<%# DateTime.Now.Date.ToString() %>" placeholder="Fecha" name="fecha-pedido" />
				
			</div>

			<script>
				var fecha = document.getElementById("<%=Label1.ClientID%>").textContent;
				document.getElementById("FechaRetiro").setAttribute("min", fecha);
				console.log(fecha);
            </script>
			
			<div class="input">
				<h4>Total a pagar: <span runat="server" id="Total">-</span></h4>
			</div>
			
			<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
		<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
		<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
			
			
			<button runat="server" id="FinalizarPedido" onserverclick="FinalizarPedido_ServerClick">Finalizar pedido</button>
		</form>
	</div>
		<script
  src="https://code.jquery.com/jquery-3.6.0.js"
  integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="
  crossorigin="anonymous"></script>
	<script>
        $("#myFormulario").on('submit', function (evt) {
            evt.preventDefault();
            // tu codigo aqui
		});
        document.querySelectorAll('#FinalizarPedido').forEach((elemento) => {
            elemento.addEventListener('click', () => {
				const codigo = elemento.parentNode.children[4].children[1].value;
				const name = elemento.parentNode.children[5].children[1].value;
				const fecha = elemento.parentNode.children[6].children[1].value;

               localStorage.setItem("Codigo", codigo);
				localStorage.setItem("Nombre", name);
                localStorage.setItem("fecha", fecha);
           });
        });
    </script>
	<div class="overlay-container">
		<div class="overlay">
			<div class="overlay-panel overlay-left">
				<h1>Si puedes recoger tu pedido en la tienda...</h1>
				<p>Registra tu pedido dando clic en el boton de abajo para que Fragata Gift sea conocedor de tu pronta visita.
					(pedido sin envio)
				</p>
				<button class="ghost" id="signIn">Hacer pedido</button>
			</div>
			<div class="overlay-panel overlay-right">
				<h1>¿Quisieras recibir tu pedido hasta la puerta de tu casa?</h1>
				<p>Registra tu pedido con envio dando clic en el boton de abajo.
				</p>
				<button class="ghost" id="signUp">Hacer pedido con envio</button>
			</div>
		</div>
	</div>
</div>





	<script>
        const signUpButton = document.getElementById('signUp');
        const signInButton = document.getElementById('signIn');
        const container = document.getElementById('container');

        signUpButton.addEventListener('click', () => {
            container.classList.add("right-panel-active");
        });

        signInButton.addEventListener('click', () => {
            container.classList.remove("right-panel-active");
        });
    </script>





</body>
</html>
