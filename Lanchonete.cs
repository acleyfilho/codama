using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Lanchonete : IVerPedidos
{
    private Pedido _pedido;
    private List<Pedido> _pedidos = new List<Pedido>();

    public Lanchonete() { }

    public Lanchonete(Pedido pedido)
    {
        _pedido = pedido;
    }

    public List<Pedido> getPedidos()
    {
        return _pedidos;
    }

    public void setPedidos(List<Pedido> pedidos)
    {
        _pedidos = pedidos;
    }

    public void CadastrarPedido()
    {
        Pedido pedido = new Pedido();
        List<Item> itens = new List<Item>();
        List<Pedido> pedidosEmPreparo = new List<Pedido>();
        int somaValorItens = 0;

        Console.WriteLine("CADASTRAR PEDIDO");
        Console.WriteLine();

        Console.Write("> Digite o ID: ");
        string idPedido = Console.ReadLine();

        while (true)
        {
            try
            {
                pedido.VerificarIdPedido(idPedido);
                break;
            }
            catch (IdInvalido)
            {
                Console.WriteLine("ID inválido!");
                Console.Write("> Por favor, tente novamente: ");
                idPedido = Console.ReadLine();
            }
        }

        pedido.setIdPedido(idPedido);

        Console.Write("> Digite o Nome do Cliente: ");
        string nomeCliente = Console.ReadLine();

        while (true)
        {
            try
            {
                pedido.setNomeCliente(nomeCliente);
                break;
            }
            catch (NomeInvalido)
            {
                Console.WriteLine("Nome inválido!");
                Console.Write("> Por favor, tente novamente: ");
                nomeCliente = Console.ReadLine();
            }
        }

        Console.WriteLine("1 - Hambúrguer");
        Console.WriteLine("2 - Hotdog");

        Console.Write("> Digite o Número do Item | Opções [ 1 - 2 ]: ");
        string tipoItem = Console.ReadLine();

        if (tipoItem == "1")
        {
            Item hamburguer = new Hamburguer();
            hamburguer.setIdItem(tipoItem);

            Console.WriteLine("1 - Blend Clássico Americano");
            Console.WriteLine("2 - Blend com Carne de Sol");

            Console.Write("> Digite a opção de carne | Opções [ 1 - 2 ]: ");
            int carne = int.Parse(Console.ReadLine());
            string tipoCarne = "";

            if (carne == 1)
            {
                tipoCarne = "Blend Clássico Americano";
                hamburguer.setPreco(10);
            }
            else if (carne == 2)
            {
                tipoCarne = "Blend com Carne de Sol";
                hamburguer.setPreco(9);
            }

            hamburguer.setTipoCarne(tipoCarne);
            itens.Add(hamburguer);

            Console.Write("> Inserir Bebida? | Opções [ s / n ]: ");
            char opcaoBebida = char.Parse(Console.ReadLine());

            if (opcaoBebida == 's' || opcaoBebida == 'S')
            {
                Item bebida = new Bebida();

                Console.WriteLine("1 - Refrigerante");
                Console.WriteLine("2 - Suco");
                Console.WriteLine("3 - Milkshake");

                Console.Write("> Escolha a bebida | Opções [ 1 - 2 - 3 ]: ");
                int bebi = int.Parse(Console.ReadLine());
                string tipoBebida = "";

                if (bebi == 1)
                {
                    tipoBebida = "Refrigerante";
                    bebida.setPreco(7);
                }
                else if (bebi == 2)
                {
                    tipoBebida = "Suco";
                    bebida.setPreco(6);
                }
                else if (bebi == 3)
                {
                    tipoBebida = "Milkshake";
                    bebida.setPreco(8);
                }

                bebida.setTipoBebida(tipoBebida);
                bebida.setIdItem("3");
                itens.Add(bebida);

                somaValorItens = hamburguer + bebida;

                // float soma = 0.0f;

                // soma = hamburguer + bebida;
                // pedido.setValorTotal(soma);
            }
        }
        if (tipoItem == "2")
        {
            Item hotdog = new Hotdog();
            hotdog.setIdItem(tipoItem);

            Console.Write("> Digite a quantidade salsichas | Opções [ 1 - 2 ]: ");
            int salsichas = int.Parse(Console.ReadLine());
            string qtdSalsichas = "";

            if (salsichas == 1)
            {
                qtdSalsichas = "1";
                hotdog.setPreco(9);
            }
            else if (salsichas == 2)
            {
                qtdSalsichas = "2";
                hotdog.setPreco(8);
            }

            hotdog.setQtdSalsichas(qtdSalsichas);
            itens.Add(hotdog);

            Console.Write("> Inserir Bebida? | Opções [ s / n ]: ");
            char opcaoBebida = char.Parse(Console.ReadLine());

            if (opcaoBebida == 's' || opcaoBebida == 'S')
            {
                Item bebida = new Bebida();

                System.Console.WriteLine("1 - Refrigerante");
                System.Console.WriteLine("2 - Suco");
                System.Console.WriteLine("3 - Milkshake");

                System.Console.Write("> Escolha a bebida | Opções [ 1 - 2 ]: ");
                int bebi = int.Parse(Console.ReadLine());
                string tipoBebida = "";

                if (bebi == 1)
                {
                    tipoBebida = "Refrigerante";
                    bebida.setPreco(7);
                }
                else if (bebi == 2)
                {
                    tipoBebida = "Suco";
                    bebida.setPreco(6);
                }
                else if (bebi == 3)
                {
                    tipoBebida = "Milkshake";
                    bebida.setPreco(8);
                }

                bebida.setTipoBebida(tipoBebida);
                bebida.setIdItem("3");
                itens.Add(bebida);

                somaValorItens = hotdog + bebida;

                // float soma = 0.0f;

                // soma = hotdog + bebida;
                // pedido.setValorTotal(soma);
            }
        }

        pedido.setValorTotal(somaValorItens);

        FileStream arq1 = new FileStream("PedidosEmPreparo.txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw1 = new StreamWriter(arq1, Encoding.UTF8);

        FileStream arq2 = new FileStream("PedidoId" + idPedido + ".txt", FileMode.Append, FileAccess.Write);
        StreamWriter sw2 = new StreamWriter(arq2, Encoding.UTF8);

        sw1.WriteLine(pedido);

        foreach (Item i in itens)
        {
            sw2.WriteLine(i);
        }

        Console.WriteLine();
        Console.WriteLine("Pedido enviado ao preparo!");

        sw1.Close();
        sw2.Close();
        arq1.Close();
        arq2.Close();
    }

    public void EntregarPedido()
    {
        List<Pedido> pedidosEmPreparo = new List<Pedido>();
        List<Pedido> pedidosEntregues = new List<Pedido>();

        string[] listaPedidosEmPreparo = File.ReadAllLines("PedidosEmPreparo.txt");
        for (int i = 0; i < listaPedidosEmPreparo.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidosEmPreparo[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEmPreparo.Add(pedido);
        }

        string[] listaPedidosEntregues = File.ReadAllLines("PedidosEntregues.txt");
        for (int i = 0; i < listaPedidosEntregues.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidosEntregues[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEntregues.Add(pedido);
        }

        Console.WriteLine("PEDIDOS EM PREPARO");
        Console.WriteLine();
        foreach (var list in pedidosEmPreparo)
        {
            Console.WriteLine(list.ToString());
        }

        Console.WriteLine();
        Console.Write("> Digite o ID do Pedido a ser entregue: ");
        string idPedido = Console.ReadLine();

        Pedido p;
        p = pedidosEmPreparo.Find(y => y.getIdPedido().Contains(idPedido));

        pedidosEmPreparo.Remove(p);
        AtualizarPedidosEmPreparo(pedidosEmPreparo);

        pedidosEntregues.Add(p);
        AtualizarPedidosEntregues(pedidosEntregues);
        
        Console.WriteLine();
        Console.WriteLine("Pedido entregue!");
    }

    public static void AtualizarPedidosEmPreparo(List<Pedido> pedido)
    {
        FileStream arq1 = new FileStream("PedidosEmPreparo.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw1 = new StreamWriter(arq1, Encoding.UTF8);

        foreach (Pedido lista in pedido)
        {
            sw1.WriteLine(lista);
        }

        sw1.Close();
        arq1.Close();
    }

    public static void AtualizarPedidosEntregues(List<Pedido> pedido)
    {
        FileStream arq1 = new FileStream("PedidosEntregues.txt", FileMode.Create, FileAccess.Write);
        StreamWriter sw1 = new StreamWriter(arq1, Encoding.UTF8);

        foreach (Pedido lista in pedido)
        {
            sw1.WriteLine(lista);
        }

        sw1.Close();
        arq1.Close();
    }

    public virtual void VerPedidosEmPreparo()
    {
        List<Pedido> pedidosEmPreparo = new List<Pedido>();

        string[] listaPedidos = File.ReadAllLines("PedidosEmPreparo.txt");
        for (int i = 0; i < listaPedidos.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidos[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEmPreparo.Add(pedido);
        }

        Console.WriteLine("PEDIDOS EM PREPARO");
        Console.WriteLine();
        foreach (var list in pedidosEmPreparo)
        {
            Console.WriteLine(list.ToString());
        }

    }

    public virtual void VerPedidosEntregues()
    {
        List<Pedido> pedidosEntregues = new List<Pedido>();

        string[] listaPedidos = File.ReadAllLines("PedidosEntregues.txt");
        for (int i = 0; i < listaPedidos.Length; i++)
        {
            Pedido pedido = new Pedido();
            string[] aux = listaPedidos[i].Split('|');
            pedido.setIdPedido(aux[0]);
            pedido.setNomeCliente(aux[1]);
            pedido.setValorTotal(Convert.ToInt32(aux[2]));
            pedidosEntregues.Add(pedido);
        }

        Console.WriteLine("PEDIDOS ENTREGUES");
        Console.WriteLine();
        foreach (var list in pedidosEntregues)
        {
            Console.WriteLine(list.ToString());
        }
    }

}
