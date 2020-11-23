using System.Collections.Generic;

public abstract class Item{
  private int _id;
  private float _preco;
  private List<string> _complemento;

  public Item(){}

  public Item(int id, float preco){
    this._id = id;
    this._preco = preco;
  }

  public Item(int id, float preco, List<string> complemento){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
  }

  public int getId(){
    return this._id;
  }

  public void setId(int id){
    this._id = id;
  }

  public float getPreco(){
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

}
