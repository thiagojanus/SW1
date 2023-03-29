namespace exemplo_acessor;
class Produto
{
    private string? Nome {get;set;}
    private double Preco {get;set;}

    public void MostrarDados(){
        Console.WriteLine("nome:" + this.Nome);
        Console.WriteLine("preço:" + this.Preco);
    }

    public void AlteraPreco(double preco){
        if(preco >=0) {
             this.Preco = preco;

        } else {
            Console.WriteLine("VALOR ÍNVALIDO!!!!");
        }
       
    }
    public void AlteraNome(string nome){
        this.Nome = nome;
    }
}