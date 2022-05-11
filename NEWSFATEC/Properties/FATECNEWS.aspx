<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FATECNEWS.aspx.cs" Inherits="NEWSFATEC.Properties.FATECNEWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
            height: 229px;
        }
        .auto-style2 {
            width: 647px;
            height: 229px;
        }
        .auto-style3 {
            width: 500px;
            height: 79px;
        }
        .auto-style4 {
            width: 647px;
            height: 79px;
        }
        .auto-style5 {
            margin-left: 9px;
            margin-top: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <h1> Jornal Pavão</h1>
            <hr /> <br />
            Bem vindos ao Principal site de Notícia da Fatec.
               </center> <br />
            <table border="2">
                <tr>
                    <td class="auto-style3">
                        Pesquisar por: 
                        <asp:DropDownList ID="cbocampo" runat="server" CssClass="auto-style5" Height="37px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="122px">
                            <asp:ListItem>Autor</asp:ListItem>
                            <asp:ListItem>Assunto</asp:ListItem>
                            <asp:ListItem Value="Titulo">Título</asp:ListItem>
                        </asp:DropDownList>
                        <br /><br />
                        Digite a palavra chave:
                        <asp:TextBox ID="txtpalavra" runat="server" Height="16px"></asp:TextBox>  &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnpesquisar" runat="server" Text="Pesquisar" />
                    </td>
                    <td class="auto-style4"> Cadastre-se já </td>
                </tr>
                <tr>
                    <td class="auto-style1"> Resultado: <br /> <br />
                        <asp:GridView ID="grade" runat="server">
                        </asp:GridView>
                    </td>                  
                    <td class="auto-style2">
                        Usuário: 
                        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
                        <br />                                               
                        <br />
                        Senha:  
                        <asp:TextBox ID="txtsenha" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="btnentrar" runat="server" Text="Entrar" />
                    </td>
                </tr>
            </table>
           
        </div>
    </form>
</body>
</html>
