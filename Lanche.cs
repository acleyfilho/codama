public abstract class Lanche{
  private int _id;
  private float _preco;
  private List<string> _complemento;
  private int _qtd;
  private int _tipoPao;

  public Lanche(){}

  public Lanche(int id, float preco, List<string> complemento, int qtd, int tipoPao){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
    this._qtd = qtd;
    this._tipoPao = tipoPao;
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

  public void setPreco(preco){
    this._preco = preco;
  }

  public List<string> getComplemento(){
    return this._complemento;
  }

  public void setComplemento(complemento){
    this._complemento = complemento;
  }

  public int getQtd(){
    return this._qtd;
  }

  public void setQtd(qtd){
    this._qtd = qtd;
  }

  public int getTipoPao(){
    return this._tipoPao;
  }

  public void setTipoPao(tipoPao){
    this._tipoPao = tipoPao;
  }

  public virtual void AdicionarComplemento(){}

}