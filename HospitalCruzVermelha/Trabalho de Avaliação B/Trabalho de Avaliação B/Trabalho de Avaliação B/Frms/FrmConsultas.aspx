<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Home.Master" AutoEventWireup="true" CodeBehind="FrmConsultas.aspx.cs" Inherits="Trabalho_de_Avaliação_B.FrmConsultas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style12 {
			width: 100%;
			height: 159px;
		}
		.auto-style13 {
			width: 147px;
		}
		.auto-style14 {
			width: 101px;
		}
		.auto-style15 {
			width: 364px;
		}
	</style>
	<title>Consulta Paciente</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table class="auto-style12">
		<tr>
			<td class="auto-style14" rowspan="2">&nbsp;</td>
			<td class="auto-style13">
				<asp:Label ID="Label3" runat="server" Text="N&amp;deg; Paciente:"></asp:Label>
			</td>
			<td class="auto-style15">
				<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="347px" AutoPostBack="True"></asp:TextBox>
			</td><td rowspan="2"></td>
		</tr>
		<tr>
			<td colspan="2">
				<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="NumCons" DataSourceID="SqlDataSource1">
					<Columns>
						<asp:BoundField DataField="NumCons" HeaderText="Numero de Consulta" InsertVisible="False" ReadOnly="True" SortExpression="NumCons" />
						<asp:BoundField DataField="DataCons" HeaderText="Data de Consulta" SortExpression="DataCons" />
						<asp:BoundField DataField="NomeMed" HeaderText="Nome de M&eacute;dico" SortExpression="NomeMed" />
						<asp:BoundField DataField="NomePac" HeaderText="Nome de Paciente" SortExpression="NomePac" />
						<asp:BoundField DataField="ValorCon" HeaderText="Valor de Consulta" SortExpression="ValorCon" DataFormatString="{0:###.##}€"/>
						<asp:BoundField DataField="MotivoDaConsulta" HeaderText="Motivo da consulta" SortExpression="MotivoDaConsulta" />
						<asp:BoundField DataField="ResultadoMed" HeaderText="Resulta do M&eacute;dico" SortExpression="ResultadoMed" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumCons], [DataCons], [NomeMed], NomePac, [ValorCon], [MotivoDaConsulta], [ResultadoMed] FROM Tbl_Medicos, Tbl_Pacientes,[Tbl_Consulta] WHERE ([NPac] = @NPac) and Tbl_Consulta.NMed=Tbl_Medicos.NumMed and Tbl_Consulta.NPac=Tbl_Pacientes.NumPac">
					<SelectParameters>
						<asp:ControlParameter ControlID="TextBox2" Name="NPac" PropertyName="Text" Type="Int32" />
					</SelectParameters>
				</asp:SqlDataSource>
			</td>
		</tr>
		</table>
</asp:Content>
