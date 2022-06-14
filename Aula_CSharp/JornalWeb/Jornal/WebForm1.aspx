<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Jornal.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Jornal</title>
    <style type="text/css">
        .auto-style6 {
            width: 40px;
        }
        .auto-style7 {
            width: 40px;
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>Jornal da Galera</h1>
                <hr />
                Seja Bem-vindo ao principal <b>portal de notícias</b> da Internet, aqui você pode ler as noticias<br />
                E também pode ser um autor!<br />

                <!--Tabela exemplo-->
                <table border="1"><!--Tabela-->
                    <tr> <!--Linha-->
                        <td>AAAAAAAAA</td> <!--Coluna-->
                        <td>BBBBBBBBB</td>
                    </tr>
                </table>
                <br />

                <!--Tabela pesoXaltura-->
                <table border="1">
                    <tr >
                        <td colspan="4">Peso X Altura</td>
                    </tr>
                    <tr>
                        <td colspan="2">Mulheres</td>
                        <td colspan="2">Homens</td>
                    </tr>
                    <tr class="auto-style6">
                        <td>1,76</td>
                        <td>50</td>
                        <td>1,70</td>
                        <td>75</td>
                    </tr>
                    <tr class="auto-style6">
                        <td>1,60</td>
                        <td>60</td>
                        <td>1,70</td>
                        <td>75</td>
                    </tr>
                    <tr class="auto-style6">
                        <td>1,65</td>
                        <td>70</td>
                        <td>1,75</td>
                        <td>75</td>
                    </tr>
                </table>
                <br />

                <!--Tabela com formas difetentes-->
                <table border="1">
                    <tr>
                        <td colspan="2">1x1</td>
                    </tr>
                    <tr>
                        <td colspan="2">2x1</td>
                    </tr>
                    <tr>
                        <td>3x1</td>
                        <td>3x2</td>
                    </tr>
                    <tr>
                        <td>4x1</td>
                        <td rowspan="2">4x2</td>
                    </tr>
                    <tr>
                        <td>5x1</td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
