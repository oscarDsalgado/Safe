﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngenieroInfoAdd.aspx.cs" Inherits="web.Formulario_web114" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Registrar informe" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">

     <div class="form-group">
    <label for="em">Empresa</label>
       <asp:DropDownList ID="DropDownList1" class="form-control" runat="server"></asp:DropDownList>
  </div>
       <div class="form-group">
    <label for="em">Evaluacion de técnico</label>
        <asp:DropDownList ID="DropDownList2" class="form-control" runat="server"></asp:DropDownList>
  </div>

      <div class="form-group">

    <label for="tx_especialidad">Recomendaciones</label>

          <asp:TextBox ID="TextBox1" class="form-control" runat="server"  placeholder="Ingrese sus recomendaciones" TextMode="MultiLine"></asp:TextBox>
  

  </div>
  
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Registrar" />
     

        </div>
</div>


</asp:Content>