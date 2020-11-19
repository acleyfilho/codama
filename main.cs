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
                Item burguer = new Hamburguer();
                
                System.Console.WriteLine("1 - Blend clássico americano");
                System.Console.WriteLine("2 -Blend clássico americano");
                System.Console.WriteLine("2 - Blend com carne de sol");

                System.Console.Write("Escolha a opção de carne: Opções [ 1 - 2 - 3 ] ");
                string tipoCarne = Console.ReadLine();



                System.Console.WriteLine("1 - Carne mal passada");
                System.Console.WriteLine("2 - Carne ao ponto");
                System.Console.WriteLine("2 - Carne bem passada");

                System.Console.Write("Escolha o ponto da carne: Opções [ 1 - 2 - 3 ] ");
                string tipoCarne = Console.ReadLine();


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
