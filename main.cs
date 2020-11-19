using System;

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
