namespace exercicioAlunoMedia;
class Program
{
    static void Main(string[] args)
    {
        /*Aluno aluno1 = new Aluno();
        aluno1.nome = "Thiago";
        aluno1.nota1 = 9.2;
        aluno1.nota2 = 6.8;

        aluno1.mensagem();
        */

        Console.WriteLine(" qual o nome do aluno: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("O seu nome é: " + nome);
        Console.WriteLine("qual é sua primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("A sua primeira nota é: " + nota1);
        Console.WriteLine("qual é a sua segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(" a sua segunda nota é: " + nota2);


        

    }
}
