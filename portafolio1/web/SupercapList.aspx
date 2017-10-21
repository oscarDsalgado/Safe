<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SupercapList.aspx.cs" Inherits="web.Formulario_web7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="panel panel-default" style="margin-right: 10%; margin-left: 10%;">
  <div class="panel-heading"><asp:Label ID="Label3" runat="server" Text="Listar capacitaciones" Font-Bold="True" Font-Size="Larger"></asp:Label>
        </div>
  <div class="panel-body">


  

      <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" CssClass="table table-bordered bs-table" DataSourceID="ObjectDataSource1" Width="90%" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
          <Columns>
              <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" ItemStyle-HorizontalAlign="Center"  HeaderStyle-Width="10px" ItemStyle-Width="40px" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" HeaderStyle-HorizontalAlign="Center" FooterStyle-HorizontalAlign="Center">
<FooterStyle HorizontalAlign="Center"></FooterStyle>

<HeaderStyle HorizontalAlign="Center" ForeColor="White" BackColor="#337ab7"  CssClass=" text-center" Width="10px"></HeaderStyle>

<ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Tema" HeaderText="Tema" SortExpression="Tema" FooterStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" HeaderStyle-CssClass=" text-center" ItemStyle-HorizontalAlign="Center" >
<FooterStyle HorizontalAlign="Center"></FooterStyle>

<HeaderStyle HorizontalAlign="Center" BackColor="#337ab7"  CssClass=" text-center" ForeColor="White"></HeaderStyle>

<ItemStyle HorizontalAlign="Center"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Fecha" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" HeaderText="Fecha" SortExpression="Fecha" HeaderStyle-HorizontalAlign="Center" >
<HeaderStyle HorizontalAlign="Center" BackColor="#337ab7" ForeColor="White"></HeaderStyle>

<ItemStyle CssClass="text-center"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Area" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" HeaderText="Area" SortExpression="Area" >
<HeaderStyle CssClass=" text-center" BackColor="#337ab7" ForeColor="White"></HeaderStyle>

<ItemStyle CssClass="text-center"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Expositor" HeaderText="Expositor" SortExpression="Expositor" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="120px" >
<HeaderStyle HorizontalAlign="Center" BackColor="#337ab7" ForeColor="White"></HeaderStyle>

<ItemStyle Width="120px"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Asistencia" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" HeaderText="Asistencia" SortExpression="Asistencia" ItemStyle-Width="120px" >
<HeaderStyle CssClass=" text-center" BackColor="#337ab7" ForeColor="White"></HeaderStyle>

<ItemStyle Width="120px"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Rut_empresa" HeaderText="Empresa" SortExpression="Rut_empresa" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" >
<HeaderStyle CssClass=" text-center" BackColor="#337ab7" ForeColor="White"></HeaderStyle>

<ItemStyle CssClass="text-center"></ItemStyle>
              </asp:BoundField>
              <asp:BoundField DataField="Tipo_cap" HeaderText="Tipo" SortExpression="Tipo_cap" HeaderStyle-CssClass=" text-center" ItemStyle-CssClass="text-center" >
<HeaderStyle CssClass=" text-center" ForeColor="White" BackColor="#337ab7" ></HeaderStyle>

<ItemStyle CssClass="text-center"></ItemStyle>
              </asp:BoundField>


                     
              <asp:ButtonField ButtonType="Button"  ControlStyle-CssClass="btn btn-warning" Text="Editar" CommandName="Select"  HeaderText="Acción" >
                  <HeaderStyle CssClass=" text-center" ForeColor="White" BackColor="#337ab7" ></HeaderStyle>
<ControlStyle CssClass="btn btn-warning"  ></ControlStyle>
              </asp:ButtonField>
          </Columns>
          <RowStyle HorizontalAlign="Center" />
      </asp:GridView>


     
      <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ListarCapacitaciones" TypeName="web.ServiceReference1.wsa1SoapClient"></asp:ObjectDataSource>


     
  </div>
            </div>

</asp:Content>
