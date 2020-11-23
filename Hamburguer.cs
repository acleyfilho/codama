using System.Collections.Generic;

public class Hamburguer : Item{
  private int _tipoCarne;
  private int _ponto;

  public Hamburguer(){}

  public Hamburguer(int tipoCarne, int ponto){
    this._tipoCarne = tipoCarne;
    this._ponto = ponto;
  }

  public Hamburguer(int tipoCarne, int ponto, int id, float preco, List<string> complemento) 
  : base(id, preco, complemento){
    this._tipoCarne = tipoCarne;
    this._ponto = ponto;
  }
  
  public int getTipoCarne(){
    return this._tipoCarne;
  }

  public int getPonto(){
    return this._ponto;
  }

  public void setTipoCarne(int tipoCarne){
    this._tipoCarne = tipoCarne;
  }

  public void setPonto(int ponto){
    this._ponto = ponto;
  }

}
