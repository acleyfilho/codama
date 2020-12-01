public abstract class Item
{
    private string _idItem;
    private int _preco;

    public static int operator+(Item i1, Item i2)
    {
        int soma;

        soma = i1._preco + i2._preco;

        return soma;
    }

    public Item() { }

    public Item(string idItem, int preco)
    {
        _idItem = idItem;
        _preco = preco;
    }

    public string getIdItem()
    {
        return _idItem;
    }

    public bool setIdItem(string idItem)
    {
        if (idItem == "1" || idItem == "2" || idItem == "3")
        {
            _idItem = idItem;
            return true;
        }
        return false;
    }

    public float getPreco()
    {
        return _preco;
    }

    public void setPreco(int preco)
    {
        _preco = preco;// Classe abstrata Item
public abstract class Item
{
    // Atributos
    private string _idItem;
    private int _preco;

    // Construtores
    public Item() { }

    public Item(string idItem, int preco)
    {
        _idItem = idItem;
        _preco = preco;
    }

    // Gets e sets
    public string getIdItem()
    {
        return _idItem;
    }

    public float getPreco()
    {
        return _preco;
    }
    
    public void setIdItem(string idItem)
    {
        _idItem = idItem;
    }

    public void setPreco(int preco)
    {
        _preco = preco;
    }

    // Utilização de sobrecarga de operadores (operador +)
    public static int operator+(Item i1, Item i2)
    {
        int soma;

        soma = i1._preco + i2._preco;

        return soma;
    }

    // Métodos virtuais
    public virtual string getTipoCarne()
    {
        return "";
    }

    public virtual string getQtdSalsichas()
    {
        return "";
    }

    public virtual string getTipoBebida()
    {
        return "";
    }

    public virtual void setTipoCarne(string tipoCarne) { }

    public virtual void setQtdSalsichas(string qtdSalsichas) { }

    public virtual void setTipoBebida(string tipoBebida) { }

}
    }

    public virtual string getTipoCarne()
    {
        return "";
    }

    public virtual string getQtdSalsichas()
    {
        return "";
    }

    public virtual string getTipoBebida()
    {
        return "";
    }

    public virtual void setTipoCarne(string tipoCarne) { }

    public virtual void setQtdSalsichas(string qtdSalsichas) { }

    public virtual void setTipoBebida(string tipoBebida) { }

}
