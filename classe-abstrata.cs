using System;

public abstract class Jogador
{
    private string nome; 
    private int nivel;
    private int gol;
    private double forca;
    private double agilidade;
    private double inteligencia;

    public Jogador(string nome, int nivel, int gol, double forca, double agilidade, double inteligencia)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.gol = gol;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
    }

    public string GetNome() { return nome; }
    public void SetNome(string nome) { this.nome = nome; }
    public int GetNivel() { return nivel; }
    public void SetNivel(int nivel) { this.nivel = nivel; }
    public int GetGol() { return gol; }
    public void SetGol(int gol) { this.gol = gol; }
    public double GetForca() { return forca; }
    public void SetForca(double forca) { this.forca = forca; }
    public double GetAgilidade() { return agilidade; }
    public void SetAgilidade(double agilidade) { this.agilidade = agilidade; }
    public double GetInteligencia() { return inteligencia; }
    public void SetInteligencia(double inteligencia) { this.inteligencia = inteligencia; }

    public abstract void Mover(string direcao);
    public abstract void Atacar(Jogador alvo);
    public abstract void UsarHabilidade(string habilidade, Jogador alvo);
    public abstract void ReceberDano(double dano);
}

class JogadorBase : Jogador
{
    private string time;

    public JogadorBase(string nome, int nivel, int gol, string time, double forca, double agilidade, double inteligencia) 
        : base(nome, nivel, gol, forca, agilidade, inteligencia)
    {
        this.time = time;
    }

    public string GetTime() { return time; }

    public override void Mover(string direcao)
    {
        Console.WriteLine($"{GetNome()} está se movendo na direção {direcao}.");
    }
    public override void Atacar(Jogador alvo)
    {
        Console.WriteLine($"{GetNome()} está atacando {alvo.GetNome()}.");
    }
    public override void UsarHabilidade(string habilidade, Jogador alvo)
    {
        Console.WriteLine($"{GetNome()} está usando a habilidade {habilidade} em {alvo.GetNome()}.");
    }
    public override void ReceberDano(double dano)
    {
        Console.WriteLine($"{GetNome()} recebeu {dano} pontos de dano.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        JogadorBase Neymar = new JogadorBase("Neymar", 99, 454, "Santos", 90, 95, 99);
        JogadorBase Messi = new JogadorBase("Messi", 99, 817, "Barcelona", 99, 99, 99);

        Console.WriteLine("Personagem Herói");
        Console.WriteLine($"Nome: {Neymar.GetNome()}");
        Console.WriteLine($"Nível: {Neymar.GetNivel()}");
        Console.WriteLine($"Pontuação do Neymar: {Neymar.GetGol()}");
        Console.WriteLine($"Time: {Neymar.GetTime()}");
        Console.WriteLine($"Força: {Neymar.GetForca()}");
        Console.WriteLine($"Agilidade: {Neymar.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {Neymar.GetInteligencia()}");
        Console.WriteLine();

        Console.WriteLine("----------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Personagem Inimigo");
        Console.WriteLine($"Nome: {Messi.GetNome()}");
        Console.WriteLine($"Nível: {Messi.GetNivel()}");
        Console.WriteLine($"Pontuação do Messi: {Messi.GetGol()}");
        Console.WriteLine($"Time: {Messi.GetTime()}");
        Console.WriteLine($"Força: {Messi.GetForca()}");
        Console.WriteLine($"Agilidade: {Messi.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {Messi.GetInteligencia()}");
        Console.WriteLine();

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();

        Neymar.Mover("angulo esquerdo");
        Messi.Mover("angulo direito");
        Neymar.Atacar(Messi);
        Neymar.UsarHabilidade("Chute Colocado", Messi); 
        Neymar.SetGol(Neymar.GetGol() + 30);
        Console.WriteLine($"Pontuação do Neymar: {Neymar.GetGol()}");
        Messi.UsarHabilidade("Canetinha", Neymar);
        Messi.SetGol(Messi.GetGol() + 30);
        Console.WriteLine($"Pontuação do Messi: {Messi.GetGol()}");
        Neymar.UsarHabilidade("Drible", Messi);
        Neymar.SetGol(Neymar.GetGol() + 100);
        Console.WriteLine($"Pontuação do Neymar: {Neymar.GetGol()}");

        Console.ReadLine();
    }
}
