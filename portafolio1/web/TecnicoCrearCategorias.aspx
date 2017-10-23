<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TecnicoCrearCategorias.aspx.cs" Inherits="web.TecnicoCrearCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 30%;
            }
        .style2 {
            margin-left: 30%;

            }


        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Agregar Categoria" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">
  
      
      <h4 style="text-align:center;">Seleccione tipo de evaluacion</h4>
      &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style1" Height="24px" Width="320px"  DataTextField="nombre" DataValueField="id">
          </asp:DropDownList>
      <br />
      <h4 style="text-align:center">Agregar Categoria</h4>
      <asp:TextBox ID="TextBox1"  runat="server" CssClass="style2" Width="265px"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Agregar" Width="86px" OnClick="Button1_Click" />

       <h4 style="text-align:center;">Listado de categorias actuales</h4>

      <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" CssClass="table table-bordered bs-table">
         <HeaderStyle BackColor="#337ab7" Font-Bold="True" ForeColor="White" />
  
          <Columns>
              <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
              <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
              <asp:BoundField DataField="Estado" HeaderText="Estado" SortExpression="Estado" />
             
             
          </Columns>
      </asp:GridView>


     
      


     
      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="listarCategoria" TypeName="BLL.CategoriaDTO"></asp:ObjectDataSource>


     
      


     
  </div>
            </div>
</asp:Content>
