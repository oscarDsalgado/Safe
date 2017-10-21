<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SupercapEdit.aspx.cs" Inherits="web.Formulario_web6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

               <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Modificar capacitación" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">

     <div class="form-group">
    <label for="em">Capacitación anual</label>
      <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
  </div>
 

      <div class="form-group">

    <label for="tx_especialidad">Capacitación a editar</label>

       <asp:DropDownList ID="DropDownList2" class="form-control" runat="server"></asp:DropDownList>

  </div>
            <div class="form-group">

    <label for="tx_especialidad">Nueva capacitación</label>

    <asp:DropDownList ID="DropDownList3" class="form-control" runat="server"></asp:DropDownList>

  </div>

               <div class="form-group">

    <label for="tx_especialidad">Fecha</label>

                   <asp:TextBox ID="TextBox1" class="form-control" runat="server" TextMode="Date"></asp:TextBox>
  </div>
 
  
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Modificar" />
     

        </div>
</div>
 

</asp:Content>
