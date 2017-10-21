<%@ Page  EnableEventValidation="false" Language="C#" AutoEventWireup="true" CodeBehind="Log_in.aspx.cs" Inherits="web.Log_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="estilos/estilo1.css" rel="stylesheet" />
    <title></title>
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
	<script type="text/javascript" src="js/jquery.colorbox-min.js"></script>
	<!-- Latest compiled and minified CSS -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />

	<!-- Optional theme -->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" />

	<!-- Latest compiled and minified JavaScript -->
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" ></script>


    <style type="text/css">
        .auto-style1 {
            width: 166px;
        }

        textarea:focus, input[type="text"]:focus, input[type="password"]:focus, input[type="datetime"]:focus, input[type="datetime-local"]:focus, input[type="date"]:focus, input[type="month"]:focus, input[type="time"]:focus, input[type="week"]:focus, input[type="number"]:focus, input[type="email"]:focus, input[type="url"]:focus, input[type="search"]:focus, input[type="tel"]:focus, input[type="color"]:focus, .uneditable-    input:focus {
    border-color: none;
    box-shadow: none;
    -webkit-box-shadow: none;
    outline: -webkit-focus-ring-color auto 5px;
}
        #error,#error1,#error2,#errorserver {
  display: table;
  margin: 0 auto;
}
    </style>


</head>
    <body>
   
   
        <div class="container">
            <div class="row">
                <div class="col-sm-6 col-md-4 col-md-offset-4">
            
                    <div class="account-wall">
                        <img class="profile-img" src="NewFolder1/Logo_SAFE.PNG"
                            alt=""/>
                        <div id="errorserver" runat="server" class="alert alert-warning"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡SERVIDOR OCUPADO!

                        </div>
                        <div id="error1" runat="server" class="alert alert-danger"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡USUARIO INACTIVO!

                        </div>
                        <div id="error2" runat="server" class="alert alert-danger"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡USUARIO NO PERMITIDO!

                        </div>
                         <div id="error" runat="server" class="alert alert-danger"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡CREDENCIALES INVALIDAS!

                        </div>
                        <form class="form-signin"  data-toggle="validator" role="form" runat="server">
                        <input type="text" class="form-control" placeholder="Ingrese RUT" id="user" runat="server" oninput="checkRut(this)" required="required" autofocus="autofocus"/>
                        <input type="password" class="form-control" placeholder="Contraseña" id="pass" runat="server" required="required"/>
                            <div>
            <table>
                <tr>
                    <td class="auto-style1">    <input type="radio" id="contactChoice1" checked="true" name="login" value="Usuario" runat="server"  />
            <label for="contactChoice1">Usuario</label></td>
                    <td class="auto-style1">    <input type="radio" id="contactChoice2" name="login" value="Empresa" runat="server"/>
            <label for="contactChoice2">Empresa</label></td>
                    </tr>
   
            </table>
          </div>

                       
                            <asp:Button class="btn btn-lg btn-primary btn-block" ID="Button1" runat="server" Text="Ingresar" OnClick="Button1_Click" />
      

                        </form>
                    </div>

                </div>
            </div>
        </div>
    </body>


    <script type="text/javascript">
	function checkRut(rut) {
    // Despejar Puntos
    var valor = rut.value.replace('.','');
    // Despejar Guión
    valor = valor.replace('-','');
    
    // Aislar Cuerpo y Dígito Verificador
    cuerpo = valor.slice(0,-1);
    dv = valor.slice(-1).toUpperCase();
    
    // Formatear RUN
    rut.value = cuerpo + '-'+ dv
    
    // Si no cumple con el mínimo ej. (n.nnn.nnn)
    if(cuerpo.length < 7) { rut.setCustomValidity("RUT no válido"); return false;}
    
    // Calcular Dígito Verificador
    suma = 0;
    multiplo = 2;
    
    // Para cada dígito del Cuerpo
    for(i=1;i<=cuerpo.length;i++) {
    
        // Obtener su Producto con el Múltiplo Correspondiente
        index = multiplo * valor.charAt(cuerpo.length - i);
        
        // Sumar al Contador General
        suma = suma + index;
        
        // Consolidar Múltiplo dentro del rango [2,7]
        if(multiplo < 7) { multiplo = multiplo + 1; } else { multiplo = 2; }
  
    }
    
    // Calcular Dígito Verificador en base al Módulo 11
    dvEsperado = 11 - (suma % 11);
    
    // Casos Especiales (0 y K)
    dv = (dv == 'K')?10:dv;
    dv = (dv == 0)?11:dv;
    
    // Validar que el Cuerpo coincide con su Dígito Verificador
    if (dvEsperado != dv) { rut.setCustomValidity("RUT no válido"); return false; }
    
    // Si todo sale bien, eliminar errores (decretar que es válido)
    rut.setCustomValidity('');
}

	
</script>
</html>
