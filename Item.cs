using System.Collections.Generic;

public abstract class Item
{
    private string _idItem;
    private float _preco;

    public Item() { }

    public Item(float preco)
    {
        this._preco = preco;
    }

    public float getPreco()
    {
        return this._preco;
    }

    public void setPreco(float preco)
    {
        this._preco = preco;
    }

    public virtual string getTipoCarne()
    {
        return "";
    }

    public virtual string getQtdSalsichas()
    {
        return "";
    }

    public virtual void setTipoCarne(string tipoCarne) { }

    public virtual void setQtdSalsichas(string qtdSalsichas) { }

    public virtual void setTipoBebida(string tipoBebida) { }

}