<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginrespaldo.aspx.cs" Inherits="web.loginrespaldo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>


     <form id="form1" runat="server">
         
    <div class="signin-form" style="margin-left:30%; margin-right:35%; background-color:#d0d0d0;  border-radius: 20px; margin-top: 10%;" >

  <div class="container">
     
        
       
      
        <h2 class="form-signin-heading">Inicio de sesión</h2>
        

        
  
             
             <div id="error" runat="server" class="alert alert-danger"  style="width:350px" visible="false">   
                 <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; USUARIO O CONTRASEÑA INCORRECTO!

             </div>
        <!-- error will be shown here ! -->
      
            <div>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" CellSpacing="6" CellPadding="4" RepeatLayout="Flow">
                    <asp:ListItem Selected="True">Usuario</asp:ListItem>
                    <asp:ListItem>Empresa</asp:ListItem>
                </asp:RadioButtonList>
             </div>
            <div>
            <asp:TextBox ID="user" runat="server" placeholder="Usuario"  CssClass="form-control" Width="35%" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="user" EnableClientScript="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
        
        <div class="form-group">
        <asp:TextBox ID="pass" runat="server" placeholder="Password"    CssClass="form-control" Width="35%" TextMode="Password" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="pass" EnableClientScript="False" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
        </div>
       
    
        
        <div class="form-group">
            
                 <asp:Button ID="Button1" class="btn btn-default" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click"   />
         
       </div>
           
        </div>  
        
</div>
        

      </form>

   
    

</body>
</html>
