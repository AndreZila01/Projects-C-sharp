<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EncomendaFeita.aspx.cs" Inherits="VesteBem_Site.EncomendaFeita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style19 {
            margin-left: 421px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <p>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="As suas encomendas"></asp:Label>
    </p>
    <p></p>
        
        <br />
&nbsp;&nbsp;&nbsp;
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" Width="595px" CssClass="auto-style19">
            <Columns>
                <asp:BoundField DataField="IdEncomendas" HeaderText="Nº da encomenda" />
                <asp:BoundField DataField="DataEncomenda" HeaderText="Data da encomenda" SortExpression="DataEncomenda" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Estado" HeaderText="Estado " SortExpression="Estado" />
                <asp:BoundField DataField="ValorEncomendas" HeaderText="Valor" SortExpression="ValorEncomendas" DataFormatString="{0:C}" />
                <asp:BoundField DataField="Id_Cliente" HeaderText="Número de cliente" SortExpression="Id_Cliente" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdConnectionString %>" SelectCommand="SELECT [ValorEncomendas],  [DataEncomenda], tblEstado.[Estado], [EstadoEncomendas], [Id_Cliente], [IdEncomendas] FROM [tbl_Encomendas], tblEstado  WHERE ([Id_Cliente] = @Id_Cliente) and tbl_Encomendas.EstadoEncomendas=tblEstado.IdEstado">
                <SelectParameters>
                    <asp:SessionParameter Name="Id_Cliente" SessionField="IdCliente" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        
    
</asp:Content>
