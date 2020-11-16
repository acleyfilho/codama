using System.Collections.Generic;

public class Hotdog : Item{
  private int _qtdSalsichas;

  public Hotdog(){}

  public Hotdog(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

  public Hotdog(int _id, float _preco, List<string> _complemento, int _qtd) : base(id, preco, complemento, qtd){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
    this._qtd = qtd;
  }

  public int getQtdSalsichas(){
    return this._qtdSalsichas;
  }

  public void setQtdSalsichas(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }
  
  public override void AdicionarComplemento(){}
}
