﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Home.Master" AutoEventWireup="true" CodeBehind="FrmRegConsulta.aspx.cs" Inherits="Trabalho_de_Avaliação_B.FrmRegConsulta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style12 {
			width: 100%;
			height: 234px;
			margin-left: 10px;
		}
		.auto-stylelabel{
			vertical-align: top;
			margin-top:25%;
		}
		</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:Button ID="Button2" runat="server" Text="Registar Consulta" OnClick="Button2_Click" />
	<br />
	<br />
	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="NumCons" DataSourceID="SqlDataSource1" AutoGenerateDeleteButton="True">
		<Columns>
			<asp:BoundField DataField="NumCons" HeaderText="Numero de Consulta" InsertVisible="False" ReadOnly="True" SortExpression="NumCons" />
			<asp:BoundField DataField="DataCons" HeaderText="Data de Consulta" SortExpression="DataCons" />
			<asp:BoundField DataField="NomeMed" HeaderText="Nome M&eacute;dico" SortExpression="NomeMed" />
			<asp:BoundField DataField="NomePac" HeaderText="Nome Paciente" SortExpression="NomePac" />
			<asp:BoundField DataField="ValorCon" HeaderText="Valor da Consulta" SortExpression="ValorCon" DataFormatString="{0:###.##}€" />
			<asp:BoundField DataField="MotivoDaConsulta" HeaderText="Motivo da Consulta" SortExpression="MotivoDaConsulta" />
		</Columns>
	</asp:GridView>
	<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumCons], [DataCons], [NomeMed], [NomePac], [ValorCon], [MotivoDaConsulta] FROM [Tbl_Consulta], Tbl_Medicos, Tbl_Pacientes where Tbl_Consulta.NMed=Tbl_Medicos.NumMed and Tbl_Consulta.NPac=Tbl_Pacientes.NumPac"></asp:SqlDataSource>
	<br />
	<asp:Panel ID="Panel1" runat="server" Style="margin-left: 10px">
		<table class="auto-style12">
			<tr>
				<td class="col-xs-6 col-sm-6 col-md-6 col-lg-6 marcador">
					<asp:Label ID="Label3" runat="server" Text="Data Consulta:"></asp:Label>
					<asp:TextBox ID="txtData" runat="server" TextMode="Date" Width="140px"></asp:TextBox>
				</td>
				<td class="col-xs-6 col-sm-6 col-md-6 col-lg-6 marcador">
					<asp:Label ID="Label4" runat="server" Text="Nome Doutor:"></asp:Label>
					<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="NomeMed" DataValueField="NumMed">
					</asp:DropDownList>
					<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumMed], [NomeMed] FROM [Tbl_Medicos]"></asp:SqlDataSource>
				</td>
			</tr>
			<tr>
				<td class="col-xs-6 col-sm-6 col-md-6 col-lg-6 marcador">
					<asp:Label ID="Label5" runat="server" Text="Nome Paciente:"></asp:Label>
					<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="NomePac" DataValueField="NumPac">
					</asp:DropDownList>
					<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumPac], [NomePac] FROM [Tbl_Pacientes]"></asp:SqlDataSource>
				</td>
				<td class="col-xs-6 col-sm-6 col-md-6 col-lg-6 marcador">
					<asp:Label ID="Label7" runat="server" Text="Valor de Consulta:"></asp:Label>
					<asp:TextBox ID="TextBox3" runat="server" Width="104px" TextMode="Number"></asp:TextBox>
				</td>
			</tr>
			<tr width:100%" class="col-xs-12 col-sm-12 col-md-12 col-lg-12 marcador">
				<td>
					<asp:Label  CssClass="auto-stylelabel" ID="Label6" runat="server" Text="Motivo da Consulta:"></asp:Label>
				<asp:TextBox ID="TextBox5" runat="server" Height="107px" MaxLength="100" TextMode="MultiLine" Width="75%"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td class="col-xs-12 col-sm-12 col-md-12 col-lg-12 marcador" style="text-align:center" colspan="2">
					<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Adiciona Consulta" Width="174px" />
				</td>
			</tr>
		</table>
	</asp:Panel>

</asp:Content>
