<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="VesteBem_Site.Detalhes" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
.detailsImage{
width: 400px;
height: 400px;
margin-right: 20px;
}
         .auto-style1 {
             margin-left: 13px;
         }
     </style>
    
   
        <div>
             
            <br />
            <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            <br />
            <asp:Label ID="lblTitle" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="lblItem" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Preço:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblPreco" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btncomprar" runat="server" Text="Comprar" OnClick="btncomprar_Click" />
            <asp:TextBox ID="txtquant" runat="server" CssClass="auto-style1" TextMode="Number"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <p></p>
        </div>

       <!-- src="roupa%20HM/cl2.jfif">-->




</asp:Content>
