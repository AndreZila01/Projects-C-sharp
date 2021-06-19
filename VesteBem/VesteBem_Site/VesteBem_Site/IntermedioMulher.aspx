<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IntermedioMulher.aspx.cs" Inherits="VesteBem_Site.IntermedioMulher" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="background-color: red; width: 100%;">
		<div class="col-xs-4 col-sm-3 col-md-3 col-lg-3" style="background-color: white">
			<div style="padding: 15px 15px 2500px; font-size: 30px;">
				<br />
				<div style="color: black; font-size: 15px">
					<asp:Label runat="server" Text="Mulher > " Font-Size="Large"></asp:Label>
				</div>
				<p></p>
				<p></p>
				<asp:Menu ID="Menu1" runat="server" StaticSubMenuIndent="16px" Height="394px" RenderingMode="Table" Width="297px">
                    <Items>
                        <asp:MenuItem Text="Camisa" Value="Camisa" NavigateUrl="~/FrmCMulher.aspx?CategoriaClasse=Camisa"></asp:MenuItem>
                       
                        <asp:MenuItem Text="Casaco" Value="Casaco" NavigateUrl="~/FrmCMulher.aspx?CategoriaClasse=Casaco"></asp:MenuItem>

                        <asp:MenuItem Text="T-Shirts" Value="T-Shirts" NavigateUrl="~/FrmCMulher.aspx?CategoriaClasse=T-Shirts"> </asp:MenuItem>
                        
                        <asp:MenuItem Text="Calças" Value="Calças" NavigateUrl="~/FrmCMulher.aspx?CategoriaClasse=Calças"></asp:MenuItem>
                       
                        <asp:MenuItem Text="Calçado" Value="Calçado" NavigateUrl="~/FrmCMulher.aspx?CategoriaClasse=Calçado"></asp:MenuItem>
                    </Items>
                    <StaticMenuStyle HorizontalPadding="60px" VerticalPadding="100px" />
                </asp:Menu>

				</div>

			</div>
		</div>
		<div class="col-xs-8 col-sm-8 col-md-8 col-lg-8" style="background-color: white;">
			<div class="col-xs-1 col-sm-2 col-md-1 col-lg-1" style="padding-bottom: 2500px"></div>
			<div id="Imagems" runat="server" class="col-xs-10 col-sm-8 col-md-10 col-lg-10" style="margin-top: 15px; padding-bottom: 2500px; padding-left: 0px; padding-right: 0px; background-color: white; font-size: 30px;"></div>
			<div class="col-xs-1 col-sm-2 col-md-1 col-lg-1" style="padding-bottom: 2500px"></div>
			<br />
			<br />
			<br />
		</div>
	
	
	<p>
		<br />
	</p>
	<p>
		&nbsp;
	</p>
</asp:Content>
