<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TrabajadorHistC.aspx.cs" Inherits="web.Formulario_web18" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Historial capacitaciones" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">
            <h4 style="text-align:center">No hay datos que mostrar.</h4>
     
  

      <asp:GridView ID="GridView1" runat="server">
          <Columns>
              <asp:BoundField />
              <asp:BoundField />
              <asp:BoundField />
              <asp:BoundField />
              <asp:BoundField />
              <asp:BoundField />
              <asp:BoundField />
          </Columns>
      </asp:GridView>


     
  </div>
            </div>
</asp:Content>
