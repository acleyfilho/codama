using System.Collections.Generic;

public class Hamburguer : Item{
  private string _tipoCarne;

  public Hamburguer(){}

  public Hamburguer(string tipoCarne){
    this._tipoCarne = tipoCarne;
  }

  public Hamburguer(string tipoCarne, float preco) 
  : base(preco){
    this._tipoCarne = tipoCarne;
    preco = 9.99f;
  }
  
  public override string getTipoCarne(){
    return this._tipoCarne;
  }

  public override void setTipoCarne(string tipoCarne){
    this._tipoCarne = tipoCarne;
  }

}