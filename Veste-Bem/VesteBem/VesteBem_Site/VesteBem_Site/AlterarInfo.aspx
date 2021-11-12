<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AlterarInfo.aspx.cs" Inherits="VesteBem_Site.AlterarInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style19 {
            margin-left: 282px;
        }
        .auto-style20 {
            width: 100%;
        }
        .auto-style24 {
            width: 147px;
            height: 59px;
        }
        .auto-style25 {
            height: 59px;
        }
        .auto-style26 {
            width: 133px;
            height: 59px;
        }
        .auto-style27 {
            width: 190px;
            height: 59px;
        }
        .auto-style29 {
            height: 59px;
            width: 258px;
        }
        .auto-style31 {
            width: 255px;
            height: 59px;
        }
        .auto-style32 {
            width: 255px;
        }
        .auto-style33 {
            width: 258px;
        }
        .auto-style34 {
            width: 133px;
        }
        .auto-style35 {
            width: 147px;
        }
        .auto-style36 {
            width: 190px;
        }
        
    .header-center{
        text-align:center;
    }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Informações pessoais"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="SqlDataSource1" Width="748px" CssClass="auto-style19" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="IdCliente" HeaderText="IdCliente" InsertVisible="False" ReadOnly="True" SortExpression="IdCliente" Visible="False" />
                <asp:BoundField DataField="Nome" ItemStyle-Width="30px" HeaderText="Nome" SortExpression="Nome"   />
                <asp:BoundField DataField="Sexo"  HeaderText="Sexo" SortExpression="Sexo" />
                <asp:BoundField DataField="Nif"  HeaderText="Nif" SortExpression="Nif" />
                <asp:BoundField DataField="Id_Login"  HeaderText="Id_Login" SortExpression="Id_Login" Visible="False"  />
                <asp:BoundField DataField="Morada"  HeaderText="Morada" SortExpression="Morada" />
                <asp:BoundField DataField="CodPostal"  HeaderText="Código Postal" SortExpression="CodPostal"  />
                <asp:BoundField DataField="Localidade"  HeaderText="Localidade" SortExpression="Localidade"  />
                <asp:BoundField DataField="DataNasc"  HeaderText="Data de nascimento" SortExpression="DataNasc" DataFormatString="{0:d}" />
                <asp:BoundField DataField="Email"  HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Telefone"  HeaderText="Telefone" SortExpression="Telefone" />
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
    </p>
    <p>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:bdConnectionString %>" SelectCommand="SELECT * FROM [tbl_Cliente] WHERE ([IdCliente] = @IdCliente)">
            <SelectParameters>
                <asp:SessionParameter Name="IdCliente" SessionField="IdCliente" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </p>
    <p>
        &nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        <table class="auto-style20">
            <tr>
                <td class="auto-style24">
                    <asp:Label ID="Label10" runat="server" Text="Nome"></asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:TextBox ID="txtNome" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style26">
                    <asp:Label ID="label3213" runat="server" Text="Morada"></asp:Label>
                </td>
                <td class="auto-style31">
                    <asp:TextBox ID="txtMorada" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style27">
                    <asp:Label ID="Label2" runat="server" Text="Data de nascimento"></asp:Label>
                </td>
                <td class="auto-style25">
                    <asp:TextBox ID="txtDataNasc" runat="server" Width="205px" Enabled="False" TextMode="Date"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style35">
                    <asp:Label ID="Label9" runat="server" Text="Sexo"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="F">Feminino</asp:ListItem>
                        <asp:ListItem Value="I">Indefinido</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style34">
                    <asp:Label ID="label89" runat="server" Text="Código Postal"></asp:Label>
                </td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtCP" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style36">
                    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Width="205px" TextMode="Email"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style35">
                    <asp:Label ID="Label8" runat="server" Text="Nif"></asp:Label>
                </td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtNif" runat="server" Width="205px" MaxLength="9"></asp:TextBox>
                </td>
                <td class="auto-style34">
                    <asp:Label ID="Label5" runat="server" Text="Localidade"></asp:Label>
                </td>
                <td class="auto-style32">
                    <asp:TextBox ID="txtLocalidade" runat="server" Width="205px"></asp:TextBox>
                </td>
                <td class="auto-style36">
                    <asp:Label ID="Label4" runat="server" Text="Telefone"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefone" runat="server" Width="205px" MaxLength="9" TextMode="Phone"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br />
        <br />
        <asp:Button ID="BtnVoltar" runat="server" Font-Size="X-Large" OnClick="BtnVoltar_Click" Text="Voltar" Width="102px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnAlterações" runat="server" Font-Size="X-Large" OnClick="BtnAlterações_Click" Text="Guardar alterações" Visible="False" />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

    </asp:Panel>
</asp:Content>
