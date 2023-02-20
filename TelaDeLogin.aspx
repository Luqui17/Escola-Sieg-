<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelaDeLogin.aspx.cs" Inherits="EscolaSieg.TelaDeLogin" %>

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
<header>
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
        <a class="navbar-brand" href="#">Escola Sieg</a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#conteudoNavbarSuportado" aria-controls="conteudoNavbarSuportado" aria-expanded="false" aria-label="Alterna navegação">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="conteudoNavbarSuportado">
            <ul class="navbar-nav mr-auto">
                <li class="nav-item active">
                    <a class="nav-link" href="#">Cadastrar <span class="sr-only">(página atual)</span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Link</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#">Sobre</a>
                </li>
            </ul>
        </div>
    </nav>
</header>
<body runat="server">
    <div class="container">
        <div class="row">
            <div class="col-6 offset-md-3">
                <div class="card">
                    <div class="card-body">
                        <h1>Login</h1>
                        <form id="form-login">
                            <div class="form-group" runat="server">
                                <br />
                                <label for="email">Email :</label>
                            </div>
                            <div class="form-group" runat="server">
                                <input class="form-control" type="email" name="email" id="email"
                                required placeholder="Digite o seu email..." runat="server"/><br />
                                <label for="senha">Senha :</label>
                                <input class="form-control" type="password" name="email" id="senha"
                                    required placeholder="Digite a sua senha..." runat="server"/>
                            </div>
                           <div class="form-group text-center" runat="server">
                                <br />
                                <button onclick="LoginButton" type="submit" class="btn btn-outline-primary" id="botaoLogin" name="BotaoLogin" runat="server">Acessar</button>
                            </div>
                            <div class="alert alert-danger d-none">
                                Preencha o campo XXXX
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.6.3.min.js"
        integrity="sha256-pvPw+upLPUjgMXY0G+8O0xUf+/Im1MZjXxxgOcBQBXU=" crossorigin="anonymous"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
