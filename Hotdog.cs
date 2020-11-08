public class Hotdog : Lanche{
  private int _qtdSalsichas;

  public Hotdog(){}

  public void Hotdog(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }

  public Hotdog(int id, float preco, List<string> complemento, int qtd, int tipoPao) : base(id, preco, complemento, qtd, tipoPao){
    this._id = id;
    this._preco = preco;
    this._complemento = complemento;
    this._qtd = qtd;
    this._tipoPao = tipoPao;
  }

  public int getQtdSalsichas(){
    return this._qtdSalsichas;
  }

  public void setQtdSalsichas(int qtdSalsichas){
    this._qtdSalsichas = qtdSalsichas;
  }
  
  public override void AdicionarComplemento(){}
}