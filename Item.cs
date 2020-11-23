using System.Collections.Geneusing System.Collections.Generic;

public abstract class Item{
  private int _id;
  private float _preco;


  public Item(){}

  public Item(int id, float preco){
    this._id = id;
    this._preco = preco;
  }

  public Item(int id, float preco){
    this._id = id;
    this._preco = preco;

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

}
