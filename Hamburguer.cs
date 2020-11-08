public class Hamburguer : Lanche{
  private int _tipoCarne;
  private int _ponto;

  public Hamburguer(){}

  public Hamburguer(int tipoCarne, int ponto){
    this._tipoCarne = tipoCarne;
    this._ponto = ponto;
  }

  public Hamburguer(int id, float preco, List<string> complemento, int qtd, int tipoPao) : base(id, preco, complemento, qtd, tipoPao){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
    this._qtd = qtd;
    this._tipoPao = tipoPao;
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
  
  public override void AdicionarComplemento(){}
}