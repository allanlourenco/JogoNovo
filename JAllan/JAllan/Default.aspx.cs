using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Jogador bolinha;
    Jogador xizin;
    List<string> possibilidades = new List<string>() { "ABC", "DEF", "GHI", "ADG", "BEH", "CFI", "AEI", "CEG" };

    protected void Page_Load(object sender, EventArgs e)
    {
        bolinha = (Jogador)ViewState["bolinha"];
        xizin = (Jogador)ViewState["xizin"];
    }

    #region EVENTOS
    protected void imbA_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbA);
    }

    protected void imbB_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbB);
    }

    protected void imbC_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbC);
    }

    protected void imbD_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbD);
    }

    protected void imbE_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbE);
    }

    protected void imbF_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbF);
    }

    protected void imbG_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbG);
    }

    protected void imbH_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbH);
    }

    protected void imbI_Click(object sender, ImageClickEventArgs e)
    {
        AcoesDoJogo(imbI);
    }

    protected void btnAvancar_Click(object sender, EventArgs e)
    {
        if (divQtdJogadores.Visible)
        {
            if (ValidaCampos("divQtdJogadores"))
            {
                btnVoltar.Visible = true;
                divQtdJogadores.Visible = false;
                divNomesJogadores.Visible = true;
                if (rbdQtdeJogadores.SelectedValue.Equals("0"))
                {
                    txtNomeJogador2.Visible = false;
                    lblNomeJogador2.Visible = false;
                }
                else
                {
                    txtNomeJogador2.Visible = true;
                    lblNomeJogador2.Visible = true;
                }
            }
        }
        else if (divNomesJogadores.Visible)
        {
            if (ValidaCampos("divNomesJogadores"))
            {
                divNomesJogadores.Visible = false;
                divSelecionarTipo.Visible = true;
            }
        }
        else if (divSelecionarTipo.Visible)
        {
            if (ValidaCampos("divSelecionarTipo"))
            {
                divSelecionarTipo.Visible = false;
                divJogoVelha.Visible = true;
                btnAvancar.Visible = false;
                btnVoltar.Visible = false;
                InstanciarJogadores();
            }
        }
    }



    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        if (divNomesJogadores.Visible)
        {
            divNomesJogadores.Visible = false;
            divQtdJogadores.Visible = true;
            btnVoltar.Visible = false;
        }
        else if (divSelecionarTipo.Visible)
        {
            divSelecionarTipo.Visible = false;
            divNomesJogadores.Visible = true;
        }
    }
    #endregion

    #region MÉTODOS
    private void AcaoClique(Jogador jogador, ImageButton imageButton)
    {
        if (jogador.Tipo.Equals(Jogador.TipoJogador.Bolinha))
            imageButton.ImageUrl = @"http://localhost:60536/Images/iconeAzul.png";
        else
            imageButton.ImageUrl = @"http://localhost:60536/Images/iconeVermelho.png";

        if (bolinha.Clique)
        {
            bolinha.Clique = false;
            xizin.Clique = true;
            lblJogadorAtual.Text = "Jogador " + xizin.Nome + " deve jogar agora. Aguardando...";
            bolinha.CamposClicados += imageButton.ID.Substring(3);
        }
        else
        {
            bolinha.Clique = true;
            xizin.Clique = false;
            lblJogadorAtual.Text = "Jogador " + bolinha.Nome + " deve jogar agora. Aguardando...";
            xizin.CamposClicados += imageButton.ID.Substring(3);
        }
    }

    private void InstanciarJogadores()
    {
        int tipo = Convert.ToInt32(rbdTipo.SelectedValue);
        bolinha = new Jogador(tipo.Equals(0) ? txtNomeJogador1.Text : txtNomeJogador2.Text, tipo.Equals(0) ? Jogador.TipoJogador.Bolinha : Jogador.TipoJogador.Xizin, true);

        if (rbdQtdeJogadores.SelectedValue.Equals("1"))
            xizin = new Jogador(tipo.Equals(0) ? txtNomeJogador2.Text : txtNomeJogador1.Text, tipo.Equals(0) ? Jogador.TipoJogador.Xizin : Jogador.TipoJogador.Bolinha, false);

        ViewState["bolinha"] = bolinha;
        ViewState["xizin"] = xizin;

        lblJogadorAtual.Text = "O jogador " + bolinha.Nome + "vai iniciar o jogo. Favor iniciar ";
        btnReiniciar.Visible = true;
    }

    private bool ValidaCampos(string div)
    {
        if (div.Equals("divQtdJogadores"))
        {
            if (rbdQtdeJogadores.SelectedValue.Equals(""))
            {
                divMsgs.Visible = true;
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = "Favor selecionar uma opção(1 ou 2 jogadores)";
                return false;
            }
        }
        if (div.Equals("divNomesJogadores"))
        {
            if (string.IsNullOrEmpty(txtNomeJogador1.Text))
            {
                divMsgs.Visible = true;
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = "Favor incluir o nome do primeiro jogador";
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeJogador2.Text) && txtNomeJogador2.Visible == true)
            {
                divMsgs.Visible = true;
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = "Favor incluir o nome do segundo jogador";
                return false;
            }
        }
        if (div.Equals("divSelecionarTipo"))
        {
            if (rbdTipo.SelectedValue.Equals(""))
            {
                divMsgs.Visible = true;
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = "Favor selecionar o tipo";
                return false;
            }
        }

        return true;
    }

    private void AcoesDoJogo(ImageButton imb)
    {
        if (bolinha.Clique)
            AcaoClique(bolinha, imb);
        else
            AcaoClique(xizin, imb);

        imb.Enabled = false;

        ValidarPossibilidadeVitoria();
    }

    private void ValidarPossibilidadeVitoria()
    {
        foreach (var item in possibilidades)
        {
            if (!string.IsNullOrEmpty(bolinha.CamposClicados))
            {
                if (bolinha.CamposClicados.Contains(item) || bolinha.CamposClicados.Contains(InverteString(item)))
                {
                    lblMensagem.Visible = true;
                    divMsgs.Visible = true;
                    lblMensagem.Text = "Parabéns! Jogador " + bolinha.Nome + " ganhou esse jogo";
                    lblJogadorAtual.Text = string.Empty;
                    BloquearBotoesJogo(true);
                }
            }
            if (!string.IsNullOrEmpty(xizin.CamposClicados))
            {
                if (xizin.CamposClicados.Contains(item) || xizin.CamposClicados.Contains(InverteString(item)))
                {
                    lblMensagem.Visible = true;
                    divMsgs.Visible = true;
                    lblMensagem.Text = "Parabéns! Jogador " + xizin.Nome + " ganhou esse jogo";
                    lblJogadorAtual.Text = string.Empty;
                    BloquearBotoesJogo(true);
                }
            }
        }


    }

    private void BloquearBotoesJogo(bool opcao)
    {
        if (opcao)
        {
            imbA.Enabled = false;
            imbB.Enabled = false;
            imbC.Enabled = false;
            imbD.Enabled = false;
            imbE.Enabled = false;
            imbF.Enabled = false;
            imbG.Enabled = false;
            imbH.Enabled = false;
            imbI.Enabled = false;
        }
        else
        {
            imbA.Enabled = true;
            imbB.Enabled = true;
            imbC.Enabled = true;
            imbD.Enabled = true;
            imbE.Enabled = true;
            imbF.Enabled = true;
            imbG.Enabled = true;
            imbH.Enabled = true;
            imbI.Enabled = true;
        }
    }

    private void LimparBotoesJogo()
    {
        imbA.ImageUrl = string.Empty;
        imbB.ImageUrl = string.Empty;
        imbC.ImageUrl = string.Empty;
        imbD.ImageUrl = string.Empty;
        imbE.ImageUrl = string.Empty;
        imbF.ImageUrl = string.Empty;
        imbG.ImageUrl = string.Empty;
        imbH.ImageUrl = string.Empty;
        imbI.ImageUrl = string.Empty;
    }

    #endregion

    protected void btnReiniciar_Click(object sender, EventArgs e)
    {
        LimparBotoesJogo();
        BloquearBotoesJogo(false);
        InstanciarJogadores();
        lblMensagem.Text = string.Empty;
    }

    public static string InverteString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}