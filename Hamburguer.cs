class Hamburguer{
  private int _tipoCarne;
  private int _ponto;

  public Hamburguer(){

  }

  public Hamburguer(int tipoCarne, int ponto){
    this._tipoCarne = tipoCarne;
    this._ponto = ponto;
  }

  public int getTipoCarne(){
    return this._id;
  }

  public setTipoCarne(int tipoCarne){
    this._tipoCarne = tipoCarne;
  }

  public int getPonto(){
    return this._ponto;
  }

  public void setPonto(int ponto){
    this._ponto = ponto;
  }
  
}