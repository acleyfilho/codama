using System.Collections.Generic;

public class Hotdog : Item{
  private string _qtdSalsichas;

  public Hotdog(){}

  public Hotdog(string qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

  public Hotdog(string qtdSalsichas, float preco) 
  : base(preco){
    this._qtdSalsichas = qtdSalsichas;
    preco = 7.99f;
  }

  public override string getQtdSalsichas(){
    return this._qtdSalsichas;
  }

  public override void setQtdSalsichas(string qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

}