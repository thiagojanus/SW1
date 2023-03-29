namespace exemplo_construtor;
class Produto
{

    public Produto (){
        this.Nome = "corsa";
        this.Preco = 10;
    }

public Produto(string nome){
    this.Nome = nome;
}

public Produto (string nome, int desconto){
    this.Nome = nome;
    this.Preco = 10 - 10*desconto/100;
}
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