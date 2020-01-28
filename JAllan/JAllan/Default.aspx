<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>hdjdhjd - Allan</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" ></script>
</head>
<body>
    <form id="form1" runat="server">
        <div><asp:Label ID="lblTitulo" runat="server" Text="Jogo da Velha - V.1" class="badge badge-secondary"></asp:Label></div>
        <div runat="server" id="divJogadorAtual">
            <asp:Label ID="lblJogadorAtual" runat="server"></asp:Label>
        </div>
        <div runat="server" id="divMsgs" visible="false">
            <asp:Label ID="lblMensagemErro" runat="server" Visible="false"></asp:Label>
            <asp:Label ID="lblMensagem" runat="server" Visible="false"></asp:Label>
        </div>
        <div runat="server" id="divQtdJogadores">
            <table>
                <tr>
                    <td><asp:Label runat="server" ID="lblTituloInicial" Text="Bem vindo ao Jogo da Velha!! Selecione a quantidade de jogadores"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" ID="lblQtdeJogadores" Text="Número de Jogadores:"></asp:Label></td>
                    <td>
                        <asp:RadioButtonList ID="rbdQtdeJogadores" runat="server">
                            <asp:ListItem Value="0">1 Jogador</asp:ListItem>
                            <asp:ListItem Value="1">2 Jogadores</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
        <div runat="server" id="divNomesJogadores" visible="false">
            <table>
                <tr>
                    <td><asp:Label runat="server" ID="lblNomesJogadores" Text="Informe o nome do(s) jogador(es):"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" ID="lblNomeJogador1" Text="Nome do primeiro jogador"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtNomeJogador1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" ID="lblNomeJogador2" Text="Nome do segundo jogador"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtNomeJogador2" runat="server"></asp:TextBox></td>
                </tr>
            </table>
        </div>
        <div runat="server" id="divSelecionarTipo" visible="false">
            <table>
                <tr>
                    <td><asp:Label runat="server" ID="lblSelecionarTipo" Text="Selecione o tipo de letra do Jogador:"></asp:Label></td>
                </tr>
                <tr>
                    <td><asp:Label runat="server" ID="Label2" Text="Jogador 1 joga com"></asp:Label></td>
                    <td>
                        <asp:RadioButtonList ID="rbdTipo" runat="server">
                            <asp:ListItem Value="0">Bolinha</asp:ListItem>
                            <asp:ListItem Value="1">Xizin</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
            </table>
        </div>
        <div runat="server" id="divJogoVelha" visible="false">

            <table border="1">
                <tr>
                    <td><asp:ImageButton ID="imbA" runat="server" Width="200px" Height="200px" OnClick="imbA_Click"/></td>
                    <td><asp:ImageButton ID="imbB" runat="server" Width="200px" Height="200px" OnClick="imbB_Click"/></td>
                    <td><asp:ImageButton ID="imbC" runat="server" Width="200px" Height="200px" OnClick="imbC_Click"/></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="imbD" runat="server" Width="200px" Height="200px" OnClick="imbD_Click"/></td>
                    <td><asp:ImageButton ID="imbE" runat="server" Width="200px" Height="200px" OnClick="imbE_Click"/></td>
                    <td><asp:ImageButton ID="imbF" runat="server" Width="200px" Height="200px" OnClick="imbF_Click"/></td>
                </tr>
                <tr>
                    <td><asp:ImageButton ID="imbG" runat="server" Width="200px" Height="200px" OnClick="imbG_Click"/></td>
                    <td><asp:ImageButton ID="imbH" runat="server" Width="200px" Height="200px" OnClick="imbH_Click"/></td>
                    <td><asp:ImageButton ID="imbI" runat="server" Width="200px" Height="200px" OnClick="imbI_Click"/></td>
                </tr>
            </table>
        </div>
        <div runat="server" id="divBotoes">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" Visible="false" OnClick="btnVoltar_Click"/>
                    </td>
                    <td>
                        <asp:Button ID="btnAvancar" runat="server" Text="Avancar" OnClick="btnAvancar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnReiniciar" runat="server" Text="Reiniciar" Visible="false" OnClick="btnReiniciar_Click"  />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
