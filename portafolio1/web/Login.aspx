<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web.Formulario_web12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="signin-form">

  <div class="container">
     
    
  
      
        <h2 class="form-signin-heading">Inicio de sesión</h2>
        
        <div id="error">
        <!-- error will be shown here ! -->
        </div>
        
        <div class="form-group">
        
            <asp:TextBox ID="user" runat="server" placeholder="Usuario"  class="form-control" ></asp:TextBox>
        </div>
        
        <div class="form-group">
        <input type="password" class="form-control" placeholder="Password" name="password" id="password" />
        </div>
       <div class="form-group">
        
            <asp:TextBox ID="tipo" runat="server" placeholder="Tipo"  class="form-control" ></asp:TextBox>
        </div>
      <hr />
        
        <div class="form-group">
            
                 <span class="glyphicon glyphicon-log-in"></span><asp:Button ID="Button1" class="btn btn-default" runat="server" Text="Iniciar Sesion" OnClick="Button1_Click" />
         
      
        </div>  
      
      </form>

    </div>
    
</div>


</asp:Content>
