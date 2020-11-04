class Bebida{
  private int _tipoBebida;


  public Bebida(){

  }


  public Bebida(int tipo){
      this._tipoBebida = tipo;
  }


  public int getTipoBebida(){
    return this._tipoBebida;
  }
  

  public void setTipoBebida(int tipo){
    this._tipoBebida = tipo;
  }


}