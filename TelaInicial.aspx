<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaInicial.aspx.cs" Inherits="EscolaSieg.TelaInicial" %>

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
                </ul>
            </div>
        </nav>
    </header>
    <body runat="server">
        <div class="d-md-flex justify-content-md-center" padding = "2px" margin = "2px">
            <asp:TextBox type="bi-search" ID="TextBox1" runat="server" Width="225px" class="form-control" aria-placeholder="Pesquisar"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Pesquisar" class="btn btn-primary" OnClick="Button1_Click"/>
        </div>
        <br>
        <asp:GridView ID="GridView1" runat="server" class="table table-dark table-hover container" onrowcommand="gvAlunos_RowCommand" 
            onrowdeleting="gvAlunos_RowDeleting" 
            onrowupdating="gvAlunosTV_RowUpdating">
            <Columns> 
                <asp:CommandField ButtonType="Button" ShowEditButton="True" EditText="Editar" >
                <ControlStyle CssClass="btn-Warning" />
                <ItemStyle CssClass="btn-Warning" />
                </asp:CommandField>

                <asp:CommandField ShowDeleteButton="True" >
                <ControlStyle CssClass="btn-Danger" />
                <ItemStyle CssClass="btn-Danger"/>
                </asp:CommandField>
            </Columns>
        </asp:GridView>
        <div class="container justify-content-md-center">
            <asp:Button ID="Button2" runat="server" Text="Cadastrar" class="btn btn-success" OnClick="Button2_Click1"/>
        </div>
    </body>
</form>
</html>
