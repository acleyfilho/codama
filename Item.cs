using System.Collections.Generic;

public abstract class Item{
  private int _id;
  private float _preco;
  private List<string> _complemento;
  private int _qtd;

  public Item(){}

  public Item(int id, float preco, List<string> complemento, int qtd){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
    this._qtd = qtd;
  }

  public int getId(){
    return this._id;
  }

  public void setId(int id){
    this._id = id;
  }

  public int getPreco(){
    return this._preco;
  }

  public void setPreco(float preco){
    this._preco = preco;
  }

  public List<string> getComplemento(){
    return this._complemento;
  }

  public void setComplemento(List<string> complemento){
    this._complemento = complemento;
  }

  public int getQtd(){
    return this._qtd;
  }

  public void setQtd(int qtd){
    this._qtd = qtd;
  }

  public virtual void AdicionarComplemento(){}

}
