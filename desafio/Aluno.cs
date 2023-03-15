namespace exercicioAlunoMedia;
class Aluno
{
    public string nome = "";
    public double nota1,nota2 ;

    // MEDIA -> retorna um double (po exemplo um número como 8.3)
    public double obterMedia(){
        double media=(nota1+nota2)/2;
        return media ;
    }
    // SITUAÇÃO -> retorna um string ("aprovado" ou "reprovado")
    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="aprovado";
        }else{
            situacao="reprovado";
        } 
        return situacao;
    }
    // MENSAGEM -> não retorna nada, só mostra os detalhes (nome,media e situação)
    public void mensagem(){
        double mediaCalculada = obterMedia ();
        string resultadoSituacao = obterSituacao (mediaCalculada);
        Console.WriteLine(nome + " está "+ resultadoSituacao+  " com media "+ mediaCalculada);
    }


}
