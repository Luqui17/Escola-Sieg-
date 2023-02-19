<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EscolaSieg.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Formulário de Cadastro</title>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/style.css"/>
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
<body>
    <div class="container">
        <div class="row">
            <div class="col-6 offset-md-3">
                <div class="card">
                    <div class="card-body">
                        <h1>Cadastro</h1>
                        <form>
                            <div class="form-group">
                                <br/>
                                <label for="nome">Nome :</label>
                                <input class="form-control" type="text" name="Nome" id="nome"
                                    placeholder="Digite o seu nome..." required/>
                            </div>
                            <div class="form-group">
                                <br/>
                                <label for="email">Email :</label>&nbsp;
                            </div>
                            <div class="form-group">
                                <input class="form-control" type="email" name="Email" id="email"
                                    placeholder="Digite o seu email..." required/><br/>
                                <label for="senha">Senha :</label>
                                <input class="form-control" type="password" name="Senha" id="senha"
                                    placeholder="Digite a sua senha..." required/>
                            </div>
                            <div class="form-group text-center">
                                <br/>
                                <button type="submit" class="btn btn-outline-primary" id="botaoCadastrar" name="BotaoCadastrar">Cadastrar</button>
                            </div>
                            <div class="alert alert-danger d-none">
                                Preencha o campo XXXX
                            </div>
                    </div>
                        </form>
                </div>
            </div>
        </div>
    </div>
    <script src="https://code.jquery.com/jquery-3.6.3.min.js"
        integrity="sha256-pvPw+upLPUjgMXY0G+8O0xUf+/Im1MZjXxxgOcBQBXU=" crossorigin="anonymous"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>