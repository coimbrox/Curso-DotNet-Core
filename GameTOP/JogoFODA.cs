using System;

namespace GameTOP
{
  public class JogoFODA
  {

    private readonly Jogador _jogador;


    public JogoFODA(Jogador jogador)
    {
      _jogador = jogador;
    }



    public void IniciarJogo()
    {
      _jogador.correr();
      _jogador.passe();
      _jogador.chutar();
    }
  }

  public class Jogador
  {
    public readonly string _Nome;
    public Jogador(string nome)
    {
      _Nome = nome;
    }
    //chuta
    public void chutar()
    {
      Console.Write($"{_Nome} está chutando");
    }
    // corre
    public void correr()
    {
      Console.Write($"{_Nome} está correndo");
    }
    // passe
    public void passe()
    {
      Console.Write($"{_Nome} está  tocando");
    }

  }


}
