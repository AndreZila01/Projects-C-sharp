<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="Trabalho_de_Avaliação_B.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server"><style type="text/css">
		.auto-style8 {
			height: 30px;
			text-align: center;
		}

		.auto-style9 {
			height: 15px;
			width: 781px;
		}

		.auto-style10 {
			height: 169px;
			width: 781px;
		}

		.auto-style11 {
			width: 253px;
			height: 15px;
		}

																		  .auto-style18 {
																			  width: 100%;
																		  }
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<table class="auto-style14">
		<tr>
			<td class="auto-style11">
				<asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
			</td>
			<td class="auto-style9">
				<asp:TextBox ID="TextBox2" runat="server" Width="176px" MaxLength="150"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Completar o Campo" SetFocusOnError="True"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style12">
				<asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label>
			</td>
			<td class="auto-style13">
				<asp:TextBox ID="TextBox3" runat="server" Width="177px" MaxLength="150"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Completar o Campo" SetFocusOnError="True"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style8" colspan="2">
				<table class="auto-style15">
					<tr>
						<td class="auto-style16">&nbsp;</td>
						<td class="auto-style17">
				<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" Width="145px" />
						</td>
						<td>&nbsp;</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>

</asp:Content>
