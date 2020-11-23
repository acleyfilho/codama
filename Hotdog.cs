using System.Collections.Generic;

public class Hotdog : Item{
  private int _qtdSalsichas;

  public Hotdog(){}

  public Hotdog(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

  public Hotdog(int qtdSalsichas, int id, float preco, List<string> complemento) 
  : base(id, preco, complemento){
    this._qtdSalsichas = qtdSalsichas;
  }

  public int getQtdSalsichas(){
    return this._qtdSalsichas;
  }

  public void setQtdSalsichas(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

}
