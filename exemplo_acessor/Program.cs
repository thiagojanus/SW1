namespace exemplo_acessor;
class Program
{
    static void Main(string[]args)
    {
    Produto p1 = new Produto ();
    p1.AlteraPreco (5);
    p1.AlteraNome ("parafuso");
     p1.MostrarDados();
     }
}
