using Systemusing System;

class MainClass
{
    public static void Main(string[] args)
    {
        Atendente atend = new Atendente();

        bool iniciar = true;

        System.Console.WriteLine("- Novo Pedido -");

        while (iniciar == true)
        {
            System.Console.Write("Nº do pedido: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.Write("Nome do cliente: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("1 - Hambúrguer");
            System.Console.WriteLine("2 - Hotdog");
            System.Console.WriteLine("3 - Bebida");

            System.Console.Write("Tipo de item: ");
            int tipoItem = int.Parse(Console.ReadLine());

            if (tipoItem == 1)
            {
                Hamburguer burguer = new Hamburguer();
                
                System.Console.WriteLine("1 - Blend clássico americano");
                System.Console.WriteLine("2 -Blend clássico americano");
                System.Console.WriteLine("2 - Blend com carne de sol");

                System.Console.Write("Escolha a opção de carne: Opções [ 1 - 2 - 3 ] ");
                int tipoCarne = int.Parse(Console.ReadLine());


                
                if(tipoCarne == 1 || tipoCarne == 2 || tipoCarne == 3){
                  burguer.setTipoCarne(tipoCarne);
                }

                System.Console.WriteLine("1 - Carne mal passada");using System;public class Hamburguer : Item
{
  // Atributo
  private string _tipoCarne;

  // Construtores
  public Hamburguer() { }

  public Hamburguer(string tipoCarne)
  {
    _tipoCarne = tipoCarne;
  }

  public Hamburguer(string tipoCarne, string idItem, int preco) 
  : base(idItem, preco)
  {
    _tipoCarne = tipoCarne;
  }
  
  // Gets e sets
  public override string getTipoCarne()
  {
    return _tipoCarne;
  }

  public override void setTipoCarne(string tipoCarne)
  {
    _tipoCarne = tipoCarne;
  }

  public override string ToString()
  {
    return "ID: " + getIdItem() + " | Item: Hambúrguer" + " | Carne: " + _tipoCarne + " | Preço: R$ " + getPreco();
  }

}
using System.Collections.Generic;

class MainClass
{
  public static void Main(string[] args)
  {

    bool iniciar = true;

    while (iniciar == true)
    {
      System.Console.WriteLine("- Novo Pedido -");

      Pedido p = new Pedido();

      System.Console.Write("ID do pedido: ");
      int id = int.Parse(Console.ReadLine());
      p.setId(id);

      System.Console.Write("Nome do cliente: ");
      string nomeCliente = Console.ReadLine();
      p.setNomeCliente(nomeCliente);

      System.Console.WriteLine("1 - Hambúrguer");
      System.Console.WriteLine("2 - Hotdog");

      System.Console.Write("Tipo de item: ");
      int tipoItem = int.Parse(Console.ReadLine());
    
      if (tipoItem == 1)
      {

        System.Console.WriteLine("1 - Blend clássico americano");
        System.Console.WriteLine("2 - Blend com carne de sol");

        System.Console.Write("Escolha a opção de carne - Opções [ 1 - 2 ]: ");
        int carne = int.Parse(Console.ReadLine());
        string tipoCarne = "";

        if (carne == 1){
          tipoCarne = "Blend clássico americano";
        }
        else if (carne == 2){
          tipoCarne = "Blend com carne de sol";
        }

        Hamburguer burguer = new Hamburguer(tipoCarne);
        List<string> listaItens = new List<string>();
        listaItens.Add("Hambúrguer " + burguer.getTipoCarne());

        System.Console.WriteLine("Deseja bebida? - Opções [ s / n ]: ");
        char opcaoBebida = char.Parse(Console.ReadLine());
        
        if (opcaoBebida == 's')
        {
          System.Console.WriteLine("1 - Refrigerante");
          System.Console.WriteLine("2 - Suco");

          System.Console.Write("Escolha a bebida - Opções [ 1 - 2 ]: ");
          int bebida = int.Parse(Console.ReadLine());
          string tipoBebida = "";

          if (bebida == 1){
            tipoBebida = "Refrigerante";
          }
          else if (bebida == 2){
            tipoBebida = "Suco";
          }

          Bebida bebi = new Bebida();
          bebi.setTipoBebida(tipoBebida);

          listaItens.Add("Bebida: " + bebi.getTipoBebida());
        }
          

        p.GravarPedido(listaItens, id);

      }
        if (tipoItem == 2)
        {
          System.Console.Write("Quantidade de salsichas - Opções [ 1 - 2 ]: ");
          int salsichas = int.Parse(Console.ReadLine());
          string qtdSalsichas = "";
          
          if (salsichas == 1){
            qtdSalsichas = "1 salsicha";
          }
          else if (salsichas == 2){
            qtdSalsichas = "2 salsichas";
          }

          Hotdog dog = new Hotdog();
          dog.setQtdSalsichas(qtdSalsichas);

          List<string> lista = new List<string>();
          lista.Add("Hotdog com " + dog.getQtdSalsichas());

          System.Console.WriteLine("Deseja bebida? - Opções [ s / n ]: ");
          char opcaoBebida = char.Parse(Console.ReadLine());

        if (opcaoBebida == 's')
        {
          System.Console.WriteLine("1 - Refrigerante");
          System.Console.WriteLine("2 - Suco");

          System.Console.Write("Escolha a bebida - Opções [ 1 - 2 ]: ");
          int bebida = int.Parse(Console.ReadLine());
          string tipoBebida = "";

          if (bebida == 1){
            tipoBebida = "Refrigerante";
          }
          else if (bebida == 2){
            tipoBebida = "Suco";
          }

          Bebida bebi = new Bebida();
          bebi.setTipoBebida(tipoBebida);

          lista.Add("Bebida: " + bebi.getTipoBebida());
        }

        p.GravarPedido(lista, id);

        }

        System.Console.WriteLine("1 - Iniciar outro pedido");
        System.Console.WriteLine("2 - Sair");
        System.Console.Write("Opções [ 1 - 2 ]: ");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
          iniciar = true;
        }
        else
        {
          iniciar = false;
          System.Console.WriteLine("Sistema finalizado!");
        }
      }
    }
}

                System.Console.WriteLine("2 - Carne ao ponto");
                System.Console.WriteLine("2 - Carne bem passada");

                System.Console.Write("Escolha o ponto da carne: Opções [ 1 - 2 - 3 ] ");
                int tipoPonto = int.Parse(Console.ReadLine());

                if(tipoPonto == 1 || tipoPonto == 2 || tipoPonto == 3){
                  burguer.setPonto(tipoPonto);
                }

                string complemento1, complemento2, complemento3, complemento4, complemento5;

                
                complemento1 = "Batata Palha";
                complemento2 = "Tomate";
                complemento3 = "Alface";
                complemento4 = "Bacon";
                complemento5 = "Bacon";

                System.Console.WriteLine("Tomate");
                System.Console.WriteLine("Alface");
                System.Console.WriteLine("Bacon");
                System.Console.WriteLine("Queijo");

                System.Console.WriteLine("Adicionar Batata Palha");
                string opçao1 = Console.ReadLine();
                if(opçao1 == "s"){

                  burguer.getComplemento().Add(complemento1);

                }
                System.Console.WriteLine("Adicionar Batata Palha");
                string opçao2 = Console.ReadLine();
                if(opçao2 == "s"){
                  burguer.getComplemento().Add(complemento2);
                }

                System.Console.WriteLine("Adicionar Batata Palha");
                string opçao3 = Console.ReadLine();
                if(opçao3 == "s"){
                  burguer.getComplemento().Add(complemento3);
                }

                System.Console.WriteLine("Adicionar Batata Palha");
                string opçao4 = Console.ReadLine();
                if(opçao4 == "s"){
                  burguer.getComplemento().Add(complemento4);
                }

                System.Console.WriteLine("Adicionar Batata Palha");
                string opçao5 = Console.ReadLine();
                if(opçao2 == "s"){
                  burguer.getComplemento().Add(complemento5);
                }

            }
            else if (tipoItem == 2)
            {
                Item dog = new Hotdog();

                System.Console.Write("Quantidade de salsichas (1, 2 ou 3): ");
                int qtdSalsichas = int.Parse(Console.ReadLine());

            }
            else if (tipoItem == 3)
            {
                Item bebi = new Bebida();

                System.Console.Write("Tipo de bebida: ");
                int tipoBebida = int.Parse(Console.ReadLine());

            }

            System.Console.WriteLine("1 - Iniciar outro pedido");
            System.Console.WriteLine("2 - Sair");
            System.Console.Write("Digite o número desejado: ");
            int outroPedido = int.Parse(Console.ReadLine());

            if (outroPedido == 1)
            {
                iniciar = true;
                System.Console.WriteLine("- Novo Pedido -");
            }
            else if (outroPedido == 2)
            {
                iniciar = false;
                System.Console.WriteLine("Sistema finalizado!");
            }
        }

    }
};

class MainClass
{
    public static void Main(string[] args)
    {
        Atendente atend = new Atendente();

        bool iniciar = true;

        System.Console.WriteLine("- Novo Pedido -");

        while (iniciar == true)
        {
            System.Console.Write("Nº do pedido: ");
            int numero = int.Parse(Console.ReadLine());

            System.Console.Write("Nome do cliente: ");
            string nome = Console.ReadLine();

            System.Console.WriteLine("1 - Hambúrguer");
            System.Console.WriteLine("2 - Hotdog");
            System.Console.WriteLine("3 - Bebida");

            System.Console.Write("Tipo de item: ");
            int tipoItem = int.Parse(Console.ReadLine());

            if (tipoItem == 1)
            {
                Hamburguer burguer = new Hamburguer();
                
                System.Console.WriteLine("1 - Blend clássico americano");
                System.Console.WriteLine("2 -Blend clássico americano");
                System.Console.WriteLine("2 - Blend com carne de sol");

                System.Console.Write("Escolha a opção de carne: Opções [ 1 - 2 - 3 ] ");
                int tipoCarne = int.Parse(Console.ReadLine());


                
                if(tipoCarne == 1 || tipoCarne == 2 || tipoCarne == 3){

                  burguer.setTipoCarne(tipoCarne);

                }

                System.Console.WriteLine("1 - Carne mal passada");
                System.Console.WriteLine("2 - Carne ao ponto");
                System.Console.WriteLine("2 - Carne bem passada");

                System.Console.Write("Escolha o ponto da carne: Opções [ 1 - 2 - 3 ] ");
                int tipoPonto = int.Parse(Console.ReadLine());


                if(tipoPonto == 1 || tipoPonto == 2 || tipoPonto == 3){

                  burguer.setPonto(tipoPonto);


                }

            }
            else if (tipoItem == 2)
            {
                Item dog = new Hotdog();

                System.Console.Write("Quantidade de salsichas (1, 2 ou 3): ");
                int qtdSalsichas = int.Parse(Console.ReadLine());

            }
            else if (tipoItem == 3)
            {
                Item bebi = new Bebida();

                System.Console.Write("Tipo de bebida: ");
                int tipoBebida = int.Parse(Console.ReadLine());

            }

            System.Console.WriteLine("1 - Iniciar outro pedido");
            System.Console.WriteLine("2 - Sair");
            System.Console.Write("Digite o número desejado: ");
            int outroPedido = int.Parse(Console.ReadLine());

            if (outroPedido == 1)
            {
                iniciar = true;
                System.Console.WriteLine("- Novo Pedido -");
            }
            else if (outroPedido == 2)
            {
                iniciar = false;

                System.Console.WriteLine("Sistema finalizado!");
            }
        }

    }
}
