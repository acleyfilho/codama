using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

public class Pedido
{
  // Atributos
  private string _idPedido;
  private string _nomeCliente;
  private int _valorTotal;
  private List<Item> _itens;

  // Construtor
  public Pedido() { }

  // Gets e sets
  public string getIdPedido()
  {
    return _idPedido;
  }

  public string getNomeCliente()
  {
    return _nomeCliente;
  }

  public int getValorTotal()
  {
    return _valorTotal;
  }

  public List<Item> getItens()
  {
    return _itens;
  }

  public void setIdPedido(string idPedido)
  {
    _idPedido = idPedido;
  }

  // Verificando se o ID do pedido é válido
  public void VerificarIdPedido(string idPedido)
  {
    if (idPedido.Length != 2)
    {
      throw new IdInvalido();
    }

    for (int i = 0; i < idPedido.Length; i++)
    {
      if(char.IsLetter(idPedido, i))
      {
        throw new IdInvalido();
      }
    }

    List<string> id = new List<string>();

    string[] listaId = File.ReadAllLines("ListaIdPedidos.txt");

    for (int i = 0; i < listaId.Length; i++)
    {
      id.Add(listaId[i]);
    }

    if (!id.Contains(idPedido))
    {
      FileStream fs = new FileStream("ListaIdPedidos.txt", FileMode.Append, FileAccess.Write);
      StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

      sw.WriteLine(idPedido);

      sw.Close();
      fs.Close();

      setIdPedido(idPedido);
               
      }
      else
      {
        throw new IdInvalido();
      }
    }

  public void setNomeCliente(string nomeCliente)
  {
    _nomeCliente = nomeCliente;
  }

  public void VerificarNomeCliente(string nomeCliente)
  {
    if (nomeCliente.Length < 3)
    {
      throw new NomeInvalido();
    }

    for (int i = 0; i < nomeCliente.Length; i++)
    {
      if (char.IsNumber(nomeCliente, i))
      {
        throw new NomeInvalido();
      }
    }
  }

  public void setValorTotal(int valorTotal)
  {
    _valorTotal = valorTotal;
  }

  public void setItens(List<Item> itens)
  {
    _itens = itens;
  }        

  public override string ToString()
  {
    return getIdPedido() + "|" + getNomeCliente() + "|" + getValorTotal();
  }

}

[Serializable]
internal class IdInvalido : Exception
{
  public IdInvalido()
  {
  }

  public IdInvalido(string message) : base(message)
  {
  }

  public IdInvalido(string message, Exception innerException) : base(message, innerException)
  {
  }

  protected IdInvalido(SerializationInfo info, StreamingContext context) : base(info, context)
  {
  }
}

[Serializable]
internal class NomeInvalido : Exception
{
  public NomeInvalido()
  {
  }

  public NomeInvalido(string message) : base(message)
  {
  }

  public NomeInvalido(string message, Exception innerException) : base(message, innerException)
  {
  }

  protected NomeInvalido(SerializationInfo info, StreamingContext context) : base(info, context)
  {
  }
  
}
