using System;

namespace Treinojunior
{
  public class MenuPrincipal
  {
    public MenuPrincipal()
    {
      //Tamanho da tela
      Console.SetWindowSize(100, 20);
      //Nome de cima da tela
      Console.Title = "Menu Principal";
      Console.ForegroundColor = ConsoleColor.White;
    }
    public int Criar()
    {
      Console.Clear();
      Centralizar("==== Bem Vindo ao Portfólio de Sistemas Queiroz ====\n");
      Centralizar("Hoje é " + DateTime.Now.ToLongDateString());
      Console.BackgroundColor = ConsoleColor.DarkGray;
      Linha();
      Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "  =================================================="));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| Projetos e Testes de Pequena Complexidade         ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 0. Próxima página >>                              ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 1. Teste Contador Sequencial                      ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 2. Teste Pular Números                            ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 3. Teste Contínuo                                 ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 4. Teste Tabuada                                  ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 5. Teste Fatorial                                 ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 6. Teste Fibonacci                                ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 7. Teste If Complexo                              ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 8. Teste Switch Complexo                          ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 9. Teste Validade                                 ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "|| 10. Fechar diário                                 ||"));
      Console.WriteLine("|{0}|", AlinhaTexto(35, "  =================================================="));
      Console.WriteLine("|{0}|", AlinhaTexto(0, ""));
      Linha();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.Write("\n{0}", AlinhaTexto(36, "Escolha uma das opções de estudos realizados : ", "L"));
      try
      {
        return (int.Parse(Console.ReadLine()));
      }
      catch (FormatException)
      {
        return 0;
      }
    }
    //Configurações gráficas
    public static string AlinhaTexto(int EspacosParaAdicionar, string Msg, string Alinhamento = "R")
    {
      if (Alinhamento == "L")
        Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
      else
      {
        Msg = Msg.PadLeft(EspacosParaAdicionar + Msg.Length);
        Msg = Msg.PadRight((98 - Msg.Length) + Msg.Length);
      }
      return Msg;
    }
    public static void Linha()
    {
      Console.WriteLine("+--------------------------------------------------------------------------------------------------+");
    }
    public static int Centralizar(string centre)
    {
      int espacos = 50 + (centre.Length / 2);
      Console.WriteLine(centre.PadLeft(espacos));
      return espacos;
    }
  }

  public class MenuAcesso
  {
    
    switch (true)
    {
        
        case 0:
        
        break;

        default:
    }
  }
}