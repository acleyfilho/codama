using Systemusing System;


    class Atendente /*: IVerPedidos*/
    {
        private string _nomeAtendente;

        public Atendente() { }

        public Atendente(string nomeAtendente)
        {
            this._nomeAtendente = nomeAtendente;
        }

        public string getNome()
        {
            return this._nomeAtendente;
        }

        public void setNome(string nomeAtendente)
        {
            this._nomeAtendente = nomeAtendente;
        }

        public void IniciarPedido(int numero, string nome, int qtdItens, float valorTotal)
        {
            Pedido p = new Pedido(numero, nome, qtdItens, valorTotal);
            // Console.Write("Nº Pedido: " + p.getNumero() + "\n Nome Cliente: " + p.getNomeCliente()
            // + " \n Qtd. Itens: " + p.getQtdItens() + " \n Total (R$): " + p.getValorTotal() + "\n");


            
        }

        public void FinalizarPedido() { }

        public void EmitirRelatorioDia() { }
    }
;

class Atendente{

  private string _nome;
  private string _senha;
using System;


    class Atendente /*: IVerPedidos*/
    {
        private string _nomeAtendente;

        public Atendente() { }

        public Atendente(string nomeAtendente)
        {
            this._nomeAtendente = nomeAtendente;
        }

        public string getNome()
        {
            return this._nomeAtendente;
        }

        public void setNome(string nomeAtendente)
        {
            this._nomeAtendente = nomeAtendente;
        }

        public void IniciarPedido() { }

        public void FinalizarPedido() { }

        public void EmitirRelatorioDia() { }
    }

  public Atendente(){

  }

  public Atendente(string nome, string senha){
    this._nome = nome;
    this._senha = senha;

  }

  public string getNome(){
    return this._nome;
  }
  public string getSenha(){
    return this._senha;
  }

  public void setNome(string nome){
    this._nome = nome;
  }

  public void setSenha(string senha){
    this._senha = senha;
  }

  public void IniciarPedido(int numero, int cpfCliente, float valorTotal, string data, bool status, int qtdItens){
      pedido Pedido = new pedido(numero,cpfCliente,valorTotal,data,status,qtdItens);

        Console.WriteLine (" numero pedido " + Pedido.getNumero() + " \n cpfCliente " + Pedido.getCpfCliente() + "\n valorTotal " + Pedido.getValorTotal() + "\n data " + Pedido.getData() + " \n status " + Pedido.getStatus() + " \n qtdItens " + Pedido.getQtsItens());
    
  }

  public void FinalizarPedido(){

  }
  public void EmitirRelatorioDia(){
    
  }
}
