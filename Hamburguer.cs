using System.Collections.Generic;

public class Hamburguer : Item{
  private int _tipoCarne;
  private int _ponto;

  public Hamburguer(){}

  public Hamburguer(int tipoCarne, int ponto){
    this._tipoCarne = tipoCarne;
    this._ponto = ponto;
  }

  public Hamburguer(int id, float preco, List<string> complemento, int qtd) : base(id, preco, complemento, qtd){
    this.id = id;
    this.preco = preco;
    this.complemento = complemento;
    this.qtd = qtd;
  }
  
  public int getTipoCarne(){
    return this._tipoCarne;
  }

  public void setTipoCarne(int tipoCarne){
    this._tipoCarne = tipoCarne;
  }

  public int getPonto(){
    return this._ponto;
  }

  public void setPonto(int ponto){
    this._ponto = ponto;
  }
  
  public override void AdicionarComplemento(){}
}
