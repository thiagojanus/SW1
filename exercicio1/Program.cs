namespace exercicio1;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
       // Console.ReadKey();

       //criar uma instância (objeto) a partir de uma classe
       Exemplo exe01 = new Exemplo();

       exe01.mostramsg();

       exe01.pegaNome("thiago");
        
        Console.WriteLine(exe01.mensagem());

        Console.WriteLine("O resultado da soma é:" + exe01.somar(2,4));

    }
}
