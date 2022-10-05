<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Fragata.Web.Carrito" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Carrito</title>
    <%-- ICONS --%>
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
<script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
    <!-- CSS only -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-/bQdsTh/da6pkI1MST/rWKFNjaCP5gBSY4sEBT38Q/9RBh9AH40zEOg7Hlq2THRZ" crossorigin="anonymous"></script>

</head>
<body>
    
<h1>Tu carrito de compras.</h1>
    <div class="main">
  
 

  <section class="shopping-cart">
    <ol class="ui-list shopping-cart--list" id="shopping-cart--list">

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <li class="_grid shopping-cart--list-item">
          <div class="_column product-image">
            <img class="product-image--img" src="<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("Fotografia")) %>" alt="Item image" />
          </div>
          <div class="_column product-info">
            <h4 class="product-name"><%# Eval("Nombre") %></h4>
            <p class="product-desc"><%# Eval("Descripccion") %></p>
            <div class="price product-single-price">$ <%# Eval("Precio") %></div>
          </div>
             

          <div class="_column product-modifiers" data-product-price="{{=price}}">
            <p style="display: none;"><%# Eval("Id") %></p>
            <button class="boton-delete" runat="server" id="botonEliminar" onserverclick="botonEliminar_ServerClick"><ion-icon name="trash-outline"></ion-icon></button>
            
          </div>
        </li>
           </ItemTemplate>
        </asp:Repeater>
        
      

    </ol>
        <script>
            window.onload = function () {

                if (localStorage.getItem("id") != null) {
                    Id = localStorage.getItem("id");

                    document.getElementById("<%=Campo.ClientID%>").value = Id;
                    console.log(Id)
                }
            }
        </script>
         
                <!--CAMPO OCULTO -->
                <form runat="server">
                    <asp:HiddenField ID="Campo" runat="server"/>
                </form>
      <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <script>

        document.querySelectorAll('.boton-delete').forEach((elemento) => {
            elemento.addEventListener('click', () => {
                const Id = elemento.parentElement.children[0].innerHTML;
                console.log(Id);
                localStorage.setItem("id", Id);
            });
        });
    </script>

    <footer class="_grid cart-totals" style="width: 90%; margin-left: 25px;">
     
      
    
      <div class="_column total" id="totalCtr">
        <div class="cart-totals-key">Total</div>
        <div runat="server" id="Total" class="cart-totals-value">$0.00</div>
      </div>
      <div class="_column checkout">
        <a href="formCompra.aspx">Siguiente</a>
      </div>
    </footer>

  </section>
<div class="image">
       <img src="imagenes/image-2.png"/>
     <img src="imagenes/image-3.png"/>
    
   </div>
   
</div>

     <link rel="stylesheet" href="css/carro.css" />
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>

    
  
</body>
</html>
