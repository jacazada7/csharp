public class Produto {
    private String nome;
    private decimal preco;
    private string descricao;
    private string categoria;

    public Produto(string nome, decimal preco,string descricao,string categoria) {
       Nome = nome;
       Preco = preco;
       Descricao = descricao;
       Categoria = categoria;
    }

    public string Nome {
        get { return nome;}
        set { nome = value;}
    }
    public decimal Preco{
        get{ return preco ; } 
        set { preco = value ; }
    } 
    public string Descricao  {
        get { return descricao ; }
        set { descricao = value ; }
    } 
     public string Categoria  {
        get { return categoria ; }
        set { categoria = value ; }
     }
}
public class ConsoleGame : Produto {
    private int capacidade;

    public ConsoleGame(string nome, string preco, string descricao, string categoria,int capacidade): base (nome, idade, cpf){
        Capacidade = capacidade
    } 


    public string Capacidade{
        get { return capacidade;}
        set { capacidade = value;}
    } 
}
public class ConsoleGame : Produto {
    private int capacidade;

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria,int capacidade): base (nome, preco, descricao,categoria){
        Capacidade = capacidade
    } 


    public int Capacidade{
        get { return capacidade;}
        set { capacidade = value;}
    } 
}

public class Jogo : Produto {
    private string genero;

    public Jogo(string nome, decimal preco, string descricao, string categoria,string genero): base (nome, preco, descricao,categoria){
        genero = genero
    } 


    public string Genero{
        get { return genero;}
        set { genero = value;}
    } 
}

public class Acessorio : Produto {
    private string acessorio;

    public Acessorio(string nome, decimal preco, string descricao, string categoria,string tipo): base (nome, preco, descricao,categoria){
        Tipo = tipo
    } 


    public string Tipo{
        get { return tipo;}
        set { tipo = value;}
    } 
}

public class Colecionavel : Produto {
    private bool limitado;

    public Colecionavel(string nome, decimal preco, string descricao, string categoria,bool limitado): base (nome, preco, descricao,categoria){
        genero = genero
    } 


    public bool Limitado{
        get { return limitado;}
        set { limitado = value;}
    } 
}


  public class Program{

public static void main (String[] args) 
 Produto produto;
produto = new ConsoleGame(“PlayStation 5”, 5.900, “Console de Vídeo Game PlayStation 5 SLim com 1 Tera de armazenamento”, “Console”, 1024000);

Jogo jogo = new Jogo(“Marvel’s Spiden-Man 2 PREMIUM”, 299.2, “Jogo completo Marvel’s Spider-Man 2 para PS5.”, “Jogo PS5”, “Ação e Aventura”) ;

Acessorio acessorio = new Acessorio("Controle",499.9,"Controle para PlayStation 5","Console", "5 botões");


Colecionavel colecionavel = new Colecionavel("jogo do Homem Aranha",250,"jogo para PlayStation 5", "console",true);
}







