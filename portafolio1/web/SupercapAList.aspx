<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SupercapAList.aspx.cs" Inherits="web.Formulario_web41" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Listar capacitaciones anuales " Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">

     
  

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
