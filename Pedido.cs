class Pedidpublic class Pedido{
  private int _numero;
  private string _nomeCliente;
  private int _qtdItens;
  private float _valorTotal;

  public Pedido(){}

  public Pedido(int numero, string nomeCliente, int qtdItens, float valorTotal){
    this._numero = numero;
    this._nomeCliente = nomeCliente;
    this._qtdItens = qtdItens;
    this._valorTotal = valorTotal;
  }

  public int getNumero(){
    return this._numero;
  }

  public string getNomeCliente(){
    return this._nomeCliente;
  }

  public int getQtdItens(){
    return this._qtdItens;
  }

  public float getValorTotal(){
    return this._valorTotal;
  }

  public void setNumero(int numero){
    this._numero = numero;
  }

  public void setNomeCliente(string nomeCliente){
    this._nomeCliente = nomeCliente;
  }

  public void setQtdItens(int qtdItens){
    this._qtdItens = qtdItens;
  }

  public void setValorTotal(float valorTotal){
    this._valorTotal = valorTotal;using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Pedido{
  private int _id;
  private string _nomeCliente;
  private float _valorTotal;

  public Pedido(){}

  public Pedido(int id, string nomeCliente, float valorTotal){
    this._id = id;
    this._nomeCliente = nomeCliente;
    this._valorTotal = valorTotal;
  }

  public int getId(){
    return this._id;
  }

  public string getNomeCliente(){
    return this._nomeCliente;
  }

  public float getValorTotal(){
    return this._valorTotal;
  }

  public void setId(int id){
    this._id = id;
  }

  public void setNomeCliente(string nomeCliente){
    this._nomeCliente = nomeCliente;
  }

  public void setValorTotal(float valorTotal){
    this._valorTotal = valorTotal;
  }

  public void SomarValorPedido(){}

  public void AtualizarStatusPedido(){}

  public void GravarPedido(List<string> i, int id)
  {
    FileStream Arq1 = new FileStream("Pedido_" + id + ".txt", FileMode.Create, FileAccess.Write);
    StreamWriter sw1 = new StreamWriter(Arq1, Encoding.UTF8);

    foreach (string lista in i)
    {
      sw1.WriteLine(lista);
    }

    sw1.Close();
    Arq1.Close();
  }

}
  }

  public void SomarValorPedido(){

    //sobrecarga de metodos e sobrecarga de operadores
  }

  public void AtualizarStatusPedido(){
    //Não sabemos o que fazer por enquanto
  }

}private int _numero;
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
public class Pedido{
  private int _numero;
  private string _nomeCliente;
  private int _qtdItens;
  private float _valorTotal;

  public Pedido(){}

  public Pedido(int numero, string nomeCliente, int qtdItens, float valorTotal){
    this._numero = numero;
    this._nomeCliente = nomeCliente;
    this._qtdItens = qtdItens;
    this._valorTotal = valorTotal;
  }

  public int getNumero(){
    return this._numero;
  }

  public string getNomeCliente(){
    return this._nomeCliente;
  }

  public int getQtdItens(){
    return this._qtdItens;
  }

  public float getValorTotal(){
    return this._valorTotal;
  }

  public void setNumero(int numero){
    this._numero = numero;
  }

  public void setNomeCliente(string nomeCliente){
    this._nomeCliente = nomeCliente;
  }

  public void setQtdItens(int qtdItens){
    this._qtdItens = qtdItens;
  }

  public void setValorTotal(float valorTotal){
    this._valorTotal = valorTotal;
  }

  public void SomarValorPedido(){

    //sobrecarga de metodos e sobrecarga de operadores
  }

  public void AtualizarStatusPedido(){
    //Não sabemos o que fazer por enquanto
  }

}
