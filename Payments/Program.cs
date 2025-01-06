using System;

namespace Payments 
{
  class Program
  {
    static void Main (string[] args)
    {
      var pagamentoBoleto = new PagamentoBoleto();
      Console.WriteLine("Hello Word!");
    }
  }

  class Pagamento 
  {
    //Propriedades
    public DateTime Vencimento;

    //Métodos 
    public void Pagar() {}
  }

  class PagamentoBoleto : Pagamento () 
  {
    public DateTime Vencimento;

    public void Pagar () 
    {
        
    }
  }
}