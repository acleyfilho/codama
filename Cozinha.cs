class Cozinha{
  private int _tempoPreparo;

  public Cozinha(){

  }

  public Cozinha(int tempo){
      this._tempoPreparo = tempo;
  }

  public int getTempoPreparo(){
    return this._tempoPreparo;
  }

  public void setTempoPreparo(int tempo){
    this._tempoPreparo = tempo;
  }

using System;
using System.IO;
namespace Operacoes_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string arquivo = @"C:\dados\macoratti.txt";
            if (File.Exists(arquivo))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(arquivo))
                    {
                        String linha;
                        // Lê linha por linha até o final do arquivo
                        while ((linha = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine(" O arquivo " + arquivo + "não foi localizado !");
            }
            Console.ReadKey();
        }
    }
}

}
