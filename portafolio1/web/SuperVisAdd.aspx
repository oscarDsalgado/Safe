<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SuperVisAdd.aspx.cs" Inherits="web.Formulario_web8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Agregar visita médica" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">

     <div class="form-group">
    <label for="em">Empresa</label>
      <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
  </div>
 

            <div class="form-group">

    <label for="tx_especialidad">Nombre</label>
                <asp:TextBox ID="TextBox1"  class="form-control" runat="server" TextMode="SingleLine"></asp:TextBox>

  </div>
               <div class="form-group">

    <label for="tx_especialidad">Fecha</label>
                <asp:TextBox ID="TextBox2"  class="form-control" runat="server" TextMode="Date"></asp:TextBox>

  </div>
 
  
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Agregar visita" />
     

        </div>
</div>

</asp:Content>
