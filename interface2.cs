using System;
interface IAtacante {
    void Atacar() ;
}
public abstract class Heroi{

    private string nome;
    private int forca;
    private string poder;

    public Heroi(string nome,int forca,string poder){

        this.nome = nome;
        this.forca = forca;
        this.poder = poder;

    }
      
    public string GetNome(){
        return nome;
    }

    public void SetNome(string nome){
        this.nome = nome;
    }

    public int GetForca(){
        return forca;
    }

    public void SetForca(int forca){
        this.forca = forca;
    }
   public string GetPoder(){
        return poder;
    }

    public void SetPoder(string  Poder){
        this.poder = poder;
   }
    public abstract void Especial();
}
class Thanos: Heroi,IAtacante{
     public Thanos(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar() {
        Console.WriteLine("Thanos ataca com murro !");
    }
    public override void Especial()
    {
        Console.WriteLine("Thanos atacar com chute!");
    }
}
class Thor : Heroi,IAtacante{
     public Thor(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar(){
        Console.WriteLine("Thor lança raios de fogo!");
    } 
    public override void Especial()
    {
        Console.WriteLine("Thor lança raios de água!");
    }

}
class Hulk: Heroi,IAtacante{
    public Hulk(string nome,int forca,string poder ) :base(nome,forca,poder) {
     }
    public void Atacar(){
        Console.WriteLine("Hulk dispara diversos socos !");
    }
     public override void Especial()
    {
        Console.WriteLine("Hulk dispara um super murro!");
    }
}
class Program{
    static void Main(string[]args) {
        Thanos Thanos = new Thanos("Thanos",8000,"super soco");
        Thor Thor= new Thor("Thor",6000,"teia de fogo");
     Hulk Hulk = new Hulk("Hulk",7000,"muito forte");

        Thanos.Atacar();
        Thor.Atacar();
        Hulk.Atacar();
    }
}    