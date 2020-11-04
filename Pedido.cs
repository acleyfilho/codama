class Pedido{
  private int _numero;
  private int _cpfCliente;
  private float _valorTotal;
  private string _data;
  private bool _status;
  private int _qtdItens;

  public Pedido(){

  }

  public Pedido(int numero, int cpfCliente, float valorTotal, string data, bool status, int qtdItens){
      this._numero = numero;
      this._cpfCliente = cpfCliente;
      this._valorTotal = valorTotal;
      this._data = data;
      this._status = status;
      this._qtdItens = qtdItens;

  }

  public int getNumero(){
    return this._numero;
  }
  public int getCpfCliente(){
    return this._cpfCliente;
  }

  public float  getValorTotal(){
    return this._valorTotal;
  }
  public string getData(){
    return this._data;
  }

  public bool getStatus(){
    return this._status;
  }
  public int  getQtsItens(){
    return this._qtdItens;
  }

  public void setNumero(int numero){
    this._numero = numero;
  }

  public void setCpfCliente(int cpfCliente){
    this._cpfCliente = cpfCliente;
  }
  public void setData(string data){
    this._data = data;
  }

   public void setValorTotal(float valorTotal){
    this._valorTotal = valorTotal;
  }

   public void setStatus(bool status){
    this._status = status;
  }

  public void setQtdItens(int qtdItens){
    this._qtdItens = qtdItens;
  }

  public void SomarValorPedido(){

  }

  public void AtualizarStatusPedido(){
    
  }
}