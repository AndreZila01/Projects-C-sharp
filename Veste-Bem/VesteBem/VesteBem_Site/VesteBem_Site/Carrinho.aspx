<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Carrinho.aspx.cs" Inherits="VesteBem_Site.Carrinho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #Tabela {
            margin-left: 40px;
        }

        #Tabela2 {
            margin-left: 40px;
        }

        .auto-style3 {
            width: 100%;
        }

        .auto-style8 {
            height: 32px;
        }

        .auto-style22 {
            height: 50px;
            width: 66px;
        }
        .auto-style23 {
            height: 40px;
            width: 66px;
        }
        .auto-style24 {
            width: 66px;
        }
        .auto-style25 {
            height: 50px;
            width: 535px;
        }
        .auto-style26 {
            height: 40px;
            width: 535px;
        }
        .auto-style27 {
            width: 535px;
        }
        .auto-style28 {
            height: 50px;
            width: 449px;
        }
        .auto-style29 {
            height: 40px;
            width: 449px;
        }
        .auto-style30 {
            width: 449px;
        }
    </style>

    <p></p>
    <table id="Tabela" class="auto-style3">
        <tr>
            <td class="auto-style8">
                <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="O meu carrinho"></asp:Label>
            </td>
        </tr>
    </table>
    <p></p>
        <table id="Tabela2" class="auto-style3">
            <tr>
                <td class="auto-style22">:<asp:Label ID="Label2" runat="server" Font-Size="X-Large" Text="Produto:"></asp:Label>
                </td>
                <td class="auto-style28">
                    <asp:ListBox ID="lstProduto" runat="server" Width="251px" Height="145px"></asp:ListBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" BorderStyle="None" Height="21px" ImageUrl="~/Resources/Eliminar.jpg" OnClick="ImageButton1_Click" Width="33px" />
                </td>
                <td class="auto-style25">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="Preço"></asp:Label>
                </td>
                <td class="auto-style29">
                    <asp:Label ID="lblpreco" runat="server"></asp:Label>
                </td>
                <td class="auto-style26">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23"></td>
                <td class="auto-style29">
                    </td>
                <td class="auto-style26">
                    </td>
            </tr>
            <tr>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style30">
                    <asp:Button ID="btnContinuarCompras" runat="server" Height="36px" Text="Continuar Compras" Width="179px" OnClick="btnContinuarCompras_Click" Font-Size="Large" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnFinalizar" runat="server" Height="35px" Text="Finalizar encomenda" Width="182px" Font-Size="Large" OnClick="BtnFinalizar_Click" />
                </td>
                <td class="auto-style27">
                    &nbsp;</td>
            </tr>
        </table>
</asp:Content>
