using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Jogador1
/// </summary>
[Serializable]
public class Jogador
{
    public Jogador(string nome, TipoJogador tipoJogador, bool clique)
    {
        Nome = nome;
        Tipo = tipoJogador;
        Clique = clique;
    }

    public enum TipoJogador
    {
        Bolinha = 0,
        Xizin = 1
    }

    public string Nome { get; set; }
    public TipoJogador Tipo { get; set; }
    public bool Clique { get; set; }
    public string CamposClicados { get; set; }
}