<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="RegistoCliente.aspx.cs" Inherits="VesteBem.Teste" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .auto-style10 {
            width: 188px;
            margin-left: 2px;
            margin-right: 0px;
        }
        .auto-style10 {
        width: 269px;
    }
        .auto-style13 {
            width: 354px;
        }
        .auto-style11 {
        width: 188px;
        height: 26px;
    }
    .auto-style12 {
        height: 26px;
            width: 354px;
        }
        .auto-style15 {
        width: 188px;
        font-family: Arial, Helvetica, sans-serif;
        font-size: x-large;
        color: #000000;
        margin-left: 2px;
        margin-right: 0px;
    }
        .auto-style16 {
            width: 188px;
            height: 63px;
            margin-left: 2px;
            margin-right: 0px;
        }
        .auto-style17 {
            width: 354px;
            height: 63px;
        }
        .auto-style18 {
            width: 188px;
            height: 22px;
            margin-left: 2px;
            margin-right: 0px;
        }
        .auto-style19 {
            width: 354px;
            height: 22px;
        }
        .auto-style20 {
            margin-left: 0;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
<p style="font-size: xx-large; text-align:center"> Criar Utilizador</p>
    
    &nbsp;<table style="margin-left:400px"; class="auto-style14">

        <tr>
            <td class="auto-style10" style="font-size: medium; ">Nome do cliente:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtNomeCliente" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Data de nascimento:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtDataNasc" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style15" style="font-size: medium">Sexo:</td>
            <td class="auto-style13" style="font-size: medium">
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Feminino</asp:ListItem>
                    <asp:ListItem Value="I">Indefinido</asp:ListItem>
                </asp:RadioButtonList>
                <br />
            </td>
        </tr>
        <tr>
            <td class="auto-style11" style="font-size: medium; ">NIF:</td>
            <td class="auto-style12" style="font-size: medium">
                <asp:TextBox ID="txtNif" runat="server" MaxLength="9"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Morada:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtMorada" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Código Postal:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtCodPostal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style16" style="font-size: medium; ">Localidade:</td>
            <td class="auto-style17" style="font-size: medium"><asp:TextBox ID="txtLocalidade" runat="server"></asp:TextBox> </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Email</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="auto-style20"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Telefone:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtTelefone" runat="server" TextMode="Phone" MaxLength="9"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Username:</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style10" style="font-size: medium; ">Password</td>
            <td class="auto-style13" style="font-size: medium">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18" style="font-size: medium; ">Confirmar Password</td>
            <td class="auto-style19" style="font-size: medium">
                <asp:TextBox ID="txtPasswordConfirmar" runat="server" TextMode="Password" Font-Size="Medium"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style18" style="font-size: medium; ">
                <asp:Button ID="BtnRegistar" runat="server" OnClick="BtnRegistar_Click" Text="Registar" />
            </td>
            <td class="auto-style19" style="font-size: medium">
                <asp:Button ID="BtnVoltar" runat="server" OnClick="BtnVoltar_Click1" Text="Voltar" />
            </td>
        </tr>
        <tr>
            <td class="auto-style18" style="font-size: medium; ">
                &nbsp;</td>
            <td class="auto-style19" style="font-size: medium">
                &nbsp;</td>
        </tr>
                    
        </table>
    <div id="errorlabel">
    <asp:Label ID="lblMensagem" runat="server"  Font-Size="X-Large"  ></asp:Label>
         </div>   
           
            
        
        

<p>
</p>
<p>
</p>
</asp:Content>
