public class Personagem { 
    private string nome;
    private decimal poder;
    private string pontoVida;
    private string pontoAtaque;

    public Personagem(string nome, decimal poder, string pontoVida ,string pontoAtaque){
       Nome = nome;
       Poder = poder;
     PontoVida = pontoVida
     PontoAtaque =pontoAtaque
    }
    public string Nome {
        get{ return nome;}
        set {nome=value}
    }
    public int poder {
        get {return poder ; }
        set{ poder= value}
    }
    public int PontoVida {
        get {return pontoVida ; }
        set{ pontoVida= value}
    }
    public int PontoAtaque {
        get {return pontoAtaque ; }
        set{ pontoAtaque= value}
    }

    public void Atacar(){
        Console.WriteLine("ataque rapido");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("ataque rapido"+habilidade);
    }
}

public class Hulk: Personagem { 
  public Hulk (string nome, decimal poder, string pontoVida ,string pontoAtaque){
       Nome = nome;
       Poder = poder;
     PontoVida = pontoVida
     PontoAtaque =pontoataque;
  }
    }
    public void Atacar(){
        Console.WriteLine("correr");
    }
    public void Atacar(string habilidade ){
        Console.WriteLine("soco forte"+ habilidade);
    }
    public class Program {

            public static void Main(string[] args) {
            Hulk hulk = new Hulk();
                //Sobrecarga
                hulk.Atacar();//Chama o método Atacar() da classe derivada
                hulk.Atacar("Investida!");//Chama o método Atacar(string) da classe base
                //Sobrecarga
            }
        }
    

