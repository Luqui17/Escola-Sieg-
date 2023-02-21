﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaInicial.aspx.cs" Inherits="EscolaSieg.TelaInicial" %>

<!DOCTYPE html>
<script runat="server">
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulário de Cadastro</title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/style.css" />
</head>
<form id="form1" runat="server">
<header>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Escola Sieg</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="TelaCadastro.aspx">Cadastrar <span class="sr-only">(página atual)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="WebForm1.aspx">Login</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="TelaInicial.aspx">Sobre</a>
                </li>
            </ul>
        </div>
    </nav>
</header>
    <asp:GridView ID="GridView1" runat="server" Width="892px">
    </asp:GridView>
<body>
   
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mostrar" />
    </form>
   
</body>
</html>
