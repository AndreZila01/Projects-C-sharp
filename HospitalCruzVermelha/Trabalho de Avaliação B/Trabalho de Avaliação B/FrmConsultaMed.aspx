<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="FrmConsultaMed.aspx.cs" Inherits="Trabalho_de_Avaliação_B.FrmConsultaMed" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style12 {
			width: 100%;
		}
	.auto-style13 {
		height: 23px;
	}
	.auto-style14 {
		width: 268435376px;
	}
	.auto-style15 {
		height: 23px;
		width: 268435376px;
	}
	.auto-style17 {
		height: 23px;
		width: 73px;
	}
	.auto-style18 {
		width: 73px;
	}
	.auto-style19 {
		width: 73px;
		text-align: right;
		height: 26px;
	}
	.auto-style20 {
		height: 26px;
	}
	.auto-style21 {
		width: 268435376px;
		height: 26px;
	}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table class="auto-style12">
		<tr>
			<td class="auto-style20"></td>
			<td colspan="2" class="auto-style19">
				<asp:Label ID="Label3" runat="server" Text="Especialidade:"></asp:Label>
			</td>
			<td colspan="2" class="auto-style21">
				<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Especialidade" DataValueField="NumMed">
				</asp:DropDownList>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumMed], [Especialidade] FROM [Tbl_Medicos]"></asp:SqlDataSource>
			</td>
			<td class="auto-style20"></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td colspan="2" class="auto-style18">&nbsp;</td>
			<td colspan="2" class="auto-style14">
				<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="NumMed" DataSourceID="SqlDataSource2">
					<Columns>
						<asp:CommandField ShowSelectButton="True" />
						<asp:BoundField DataField="NumMed" HeaderText="NumMed" InsertVisible="False" ReadOnly="True" SortExpression="NumMed" />
						<asp:BoundField DataField="NomeMed" HeaderText="NomeMed" SortExpression="NomeMed" />
						<asp:BoundField DataField="Sexo" HeaderText="Sexo" SortExpression="Sexo" />
						<asp:BoundField DataField="NumOrdemMed" HeaderText="NumOrdemMed" SortExpression="NumOrdemMed" />
						<asp:BoundField DataField="Telefone" HeaderText="Telefone" SortExpression="Telefone" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumMed], [NomeMed], [Sexo], [NumOrdemMed], [Telefone] FROM [Tbl_Medicos] WHERE ([NumMed] = @NumMed)">
					<SelectParameters>
						<asp:ControlParameter ControlID="DropDownList1" Name="NumMed" PropertyName="SelectedValue" Type="Int32" />
					</SelectParameters>
				</asp:SqlDataSource>
			</td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style13"></td>
			<td colspan="2" class="auto-style17"></td>
			<td colspan="2" class="auto-style15">
				<asp:GridView ID="GridView2" runat="server" Width="415px" AutoGenerateColumns="False" DataKeyNames="NumCons" DataSourceID="SqlDataSource3">
					<Columns>
						<asp:BoundField DataField="NumCons" HeaderText="NumCons" InsertVisible="False" ReadOnly="True" SortExpression="NumCons" />
						<asp:BoundField DataField="DataCons" HeaderText="DataCons" SortExpression="DataCons" />
						<asp:BoundField DataField="NomeMed" HeaderText="Nome Medico" SortExpression="NomeMed" />
						<asp:BoundField DataField="NomePac" HeaderText="Nome Paciente" SortExpression="NomePac" />
						<asp:BoundField DataField="ValorCon" DataFormatString="{0:###.##}€" HeaderText="ValorCon" SortExpression="ValorCon" />
						<asp:BoundField DataField="MotivoDaConsulta" HeaderText="MotivoDaConsulta" SortExpression="MotivoDaConsulta" />
						<asp:BoundField DataField="ResultadoMed" HeaderText="ResultadoMed" SortExpression="ResultadoMed" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:L1949_ConnectionString %>" SelectCommand="SELECT [NumCons], [DataCons], Tbl_Medicos.NomeMed, Tbl_Pacientes.NomePac, [ValorCon], [MotivoDaConsulta], [ResultadoMed] FROM [Tbl_Consulta], Tbl_Medicos, Tbl_Pacientes WHERE NMed=Tbl_Medicos.NumMed and (NMed = @NumMed) and NPac=Tbl_Pacientes.NumPac">
					<SelectParameters>
						<asp:ControlParameter ControlID="GridView1" Name="NumMed" PropertyName="SelectedValue" Type="Int32" />
					</SelectParameters>
				</asp:SqlDataSource>
			</td>
			<td class="auto-style13"></td>
		</tr>
	</table>
</asp:Content>
