<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SupercapAdd.aspx.cs" Inherits="web.Formulario_web5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Crear plan capacitación" Font-Bold="True" Font-Size="Larger"></asp:Label>
      <style>
             #mensajeSI,#mensajeNO {
  display: table;
  margin: 0 auto;
}

      </style> 
       </div>


  <div class="panel-body">

     <div class="form-group">
         <div id="mensajeSI" runat="server" class="alert alert-success"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡CAPACITACIÓN AGREGADA EXITOSAMENTE!

                        </div>
           <div id="mensajeNO" runat="server" class="alert alert-danger"  style="width:90%" visible="false">   
                            <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <span class="glyphicon glyphicon-info-sign"></span> &nbsp; ¡ERROR DE CONEXIÓN, INTENTE OTRA VEZ!

                        </div>

    <label for="em">Empresa</label>
      <asp:DropDownList ID="Comboemp" class="form-control" runat="server" DataSourceID="ObjectDataSource1" DataTextField="nombre_empresa" DataValueField="rut_empresa" ></asp:DropDownList>
  </div>
 

      <div class="form-group">

    <label for="tx_especialidad">Tipo de capacitacion</label>

       <asp:DropDownList ID="Combotipocap" class="form-control" runat="server" DataSourceID="ObjectDataSource2" DataTextField="nombre" DataValueField="id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>

          <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetListarTipoCap" TypeName="web.ServiceReference1.wsa1SoapClient"></asp:ObjectDataSource>

  </div>
            <div class="form-group">

    <label for="tx_especialidad">Tema</label>
                <asp:TextBox ID="Txttema" CssClass="form-control" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>


                      <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Txttema" ErrorMessage="El rango es de 5 a 20 caracteres" Font-Bold="False" ForeColor="Red" ValidationExpression="^[\s\S]{5,20}$"></asp:RegularExpressionValidator>
  

  </div>
                  <div class="form-group">

    <label for="tx_especialidad">Area</label>

          <asp:DropDownList ID="Comboarea" class="form-control" runat="server" DataSourceID="ObjectDataSource3" DataTextField="nombre_area" DataValueField="nombre_area" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>

                      <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="listarArea" TypeName="web.ServiceReference1.wsa1SoapClient"></asp:ObjectDataSource>
  

  </div>
                  <div class="form-group">

    <label for="tx_especialidad">Expositor</label>

          <asp:TextBox ID="txtExpositor" class="form-control" runat="server"  TextMode="Date"></asp:TextBox>
  

  </div>
                  <div class="form-group">

    <label for="tx_especialidad">Asistencia minima</label>

          <asp:TextBox ID="TxtAsistencia" class="form-control" runat="server"  TextMode="Number" ValidationGroup="valivali"></asp:TextBox>
  

                      <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Valor fuera de rango" ControlToValidate="txtasistencia" MaximumValue="300" MinimumValue="10" Type="Integer" ForeColor="Red"  ValidationGroup="valivali" Font-Bold="False"></asp:RangeValidator>
  

  </div>
            <div class="form-group">

    <label for="tx_especialidad">Fecha</label>

                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="#337ab7" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
  

  </div>
           
  
                <asp:Button ID="Button1" runat="server" class="btn btn-primary" Text="Agregar capacitación" ValidationGroup="valivali" OnClick="Button1_Click" />
     

        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetlistarEmpresaList" TypeName="web.ServiceReference1.wsa1SoapClient"></asp:ObjectDataSource>
     

        </div>
</div>


</asp:Content>
