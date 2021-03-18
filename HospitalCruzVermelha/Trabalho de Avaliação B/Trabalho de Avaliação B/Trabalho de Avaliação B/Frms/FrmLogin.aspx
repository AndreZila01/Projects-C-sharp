<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Login.Master" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="Trabalho_de_Avaliação_B.FrmLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style>
    
	</style>
    <link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
	<link rel="stylesheet" type="text/css" href="css/normalize.css">
	<link href="css/estilo.css" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">  
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>  
    <script type="text/javascript">  
        $(document).ready(function () {  
            $('#show_password').hover(function show() {  
                //Change the attribute to text  
                $('#txtPassword').attr('type', 'text');  
                $('.icon').removeClass('fa fa-eye-slash').addClass('fa fa-eye');  
            },  
            function () {  
                //Change the attribute back to password  
                $('#txtPassword').attr('type', 'password');  
                $('.icon').removeClass('fa fa-eye').addClass('fa fa-eye-slash');  
            });  
            //CheckBox Show Password  
            $('#ShowPassword').click(function () {  
                $('#Password').attr('type', $(this).is(':checked') ? 'text' : 'password');  
            });  
        });  
	</script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="row">
        <div class="col-xxl-2 col-xs-2 col-xl-2 col-sm-2 col-md-1 col-lg-1 marcador"></div>
            <div class="col-xxl-8 col-xs-8 col-xl-8 col-sm-8 col-md-10 col-lg-10 marcador" style="background-color:#bff3ff">

                <h3>Registo</h3>

                <div>


                    <div class="form-group">
                        <label for="user">Username</label>&nbsp;
						<asp:TextBox runat="server" class="form-control" ID="txtUser" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="password">Password</label>

                        <asp:TextBox type="password" runat="server" class="form-control" TextMode="Password" ID="txtPassword" CssClass="form-control"></asp:TextBox>
					</div>

                	<asp:Button ID="Button2" class="btn btn-primary" onclick="btn_click" runat="server" Text="Login" />

                </div>

            </div>
        <div class="col-xxl-2 col-xs-2 col-xl-2 col-sm-2 col-md-1 col-lg-1 marcador"></div>


        </div>
</asp:Content>
