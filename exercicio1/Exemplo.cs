namespace exercicio1;
class Exemplo
{
  //ATRIBUTOS
  public string nome="nada";
  public int idade=0;
  public bool vacinado=false;

  //MÉTODOS
  public void mostramsg(){
    Console.WriteLine("oi 2f");
  }

  public void pegaNome(string texto){
    Console.WriteLine("oi "+ texto);
  }

  public string mensagem(){
    return "devolvendo o texto";
  }

  public int somar(int a, int b){
    return a+b;
  }
}

