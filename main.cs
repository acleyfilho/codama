using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Primeiro teste \n");

    int numero = 1;
    int cpfCliente = 1627;
    float valorTotal = 25;
    string data = "04/11/2020";
    bool status = true;
    int qtdItens = 8;

    atendente Atendente = new atendente();

    Atendente.IniciarPedido(numero, cpfCliente, valorTotal, data, status, qtdItens);
     
     


  }
}