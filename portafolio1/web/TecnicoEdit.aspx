﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TecnicoEdit.aspx.cs" Inherits="web.Formulario_web14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Modificar evaluación" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">

      <div class="form-group">
    <label for="em">Empresa</label>
          <asp:TextBox ID="TextBox2" class="form-control" EnableViewState="false" runat="server"></asp:TextBox>
  </div>
       <div class="form-group">
    <label for="em">Tipo evaluación</label>

           <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
  </div>

      <div class="form-group">

    <label for="tx_especialidad">Observaciones</label>

          <asp:TextBox ID="TextBox1" class="form-control" runat="server"  placeholder="Ingrese Observaciones" TextMode="MultiLine"></asp:TextBox>
  

  </div>
  
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Modificar evaluación" />
     

        </div>
 

     
  </div>



</asp:Content>
