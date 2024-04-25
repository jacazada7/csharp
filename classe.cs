using System;

public class Personagem
{
    private string nome;
    private int nivel;
    private double pontuacao;
    private double vida;
    private double forca;
    private double agilidade;
    private double inteligencia;
    private string[] armasEquipamentos;

    public Personagem(string nome, int nivel, double pontuacao, double vida, double forca, double agilidade, double inteligencia, string[] armasEquipamentos)
    {
        this.nome = nome;
        this.nivel = nivel;
        this.pontuacao = pontuacao;
        this.vida = vida;
        this.forca = forca;
        this.agilidade = agilidade;
        this.inteligencia = inteligencia;
        this.armasEquipamentos = armasEquipamentos;
    }

    public string GetNome() { 
        return nome; 
    }
    public void SetNome(string nome) { 
        this.nome = nome; 
    }
    public int GetNivel() { return nivel; }
    public void SetNivel(int nivel) { this.nivel = nivel; }
    public double GetPontuacao() { return pontuacao; }
    public void SetPontuacao(double pontuacao) { this.pontuacao = pontuacao; }
    public double GetVida() { return vida; }
    public void SetVida(double vida) { this.vida = vida; }
    public double GetForca() { return forca; }
    public void SetForca(double forca) { this.forca = forca; }
    public double GetAgilidade() { return agilidade; }
    public void SetAgilidade(double agilidade) { this.agilidade = agilidade; }
    public double GetInteligencia() { return inteligencia; }
    public void SetInteligencia(double inteligencia) { this.inteligencia = inteligencia; }
    public string[] GetArmasEquipamentos() { return armasEquipamentos; }
    public void SetArmasEquipamentos(string[] armasEquipamentos) { this.armasEquipamentos = armasEquipamentos; }

    public void Mover(string direcao, double distancia)
    {
        Console.WriteLine($"{GetNome()} está se movendo na direção {direcao} por {distancia} passos.");
    }

    public void Atacar(Personagem alvo)
    {
        Console.WriteLine($"{GetNome()} está atacando {alvo.GetNome()}.");
    }

    public void ReceberDano(double dano)
    {
        vida -= dano;

        if (vida <= 0)
        {
            Morrer();
        }
        else
        {
            Console.WriteLine($"{GetNome()} recebeu {dano} de dano. Vida restante: {GetVida()}");
        }
    }

    public void UsarHabilidade(string habilidade, Personagem alvo)
    {
        Console.WriteLine($"{GetNome()} usou a habilidade {habilidade} em {alvo.GetNome()}.");
    }

    public void Morrer()
    {
        Console.WriteLine($"{GetNome()} morreu.");
    }

    public void SubirNivel()
    {
        nivel++;
        Console.WriteLine($"{GetNome()} subiu para o nível {GetNivel()}!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personagem batman = new Personagem("Batman", 1, 0, 100, 90, 80, 100, new string[] {
            "Multi-Batarangue", "Lançador de Gel", "Bomba de Fumaça", "Ultra Bat-Garra", "Sintetizador de Voz"
        });

        Personagem coringa = new Personagem("Coringa", 1, 0, 100, 70, 65, 85, new string[] {
            "Gás do Riso", "Flores que Esguicham Ácido", "Baralhas de Cartas", "Luva de Choque"
        });

        Console.WriteLine("Personagem Herói");
        Console.WriteLine($"Nome: {batman.GetNome()}");
        Console.WriteLine($"Nível: {batman.GetNivel()}");
        Console.WriteLine($"Pontuação do Batman: {batman.GetPontuacao()}");
        Console.WriteLine($"Vida: {batman.GetVida()}");
        Console.WriteLine($"Força: {batman.GetForca()}");
        Console.WriteLine($"Agilidade: {batman.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {batman.GetInteligencia()}");
        Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", batman.GetArmasEquipamentos())}");
        Console.WriteLine("");

        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");

        Console.WriteLine("Personagem Inimigo");
        Console.WriteLine($"Nome: {coringa.GetNome()}");
        Console.WriteLine($"Nível: {coringa.GetNivel()}");
        Console.WriteLine($"Pontuação do Coringa: {coringa.GetPontuacao()}");
        Console.WriteLine($"Vida: {coringa.GetVida()}");
        Console.WriteLine($"Força: {coringa.GetForca()}");
        Console.WriteLine($"Agilidade: {coringa.GetAgilidade()}");
        Console.WriteLine($"Inteligência: {coringa.GetInteligencia()}");
        Console.WriteLine($"Armas e Equipamentos: {string.Join(", ", coringa.GetArmasEquipamentos())}");
        Console.WriteLine("");

        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("");

        batman.Mover("norte", 10);
        coringa.Mover("sul", 10);
        batman.Atacar(coringa);
        batman.UsarHabilidade("Multi-Batarangue", coringa);
        coringa.ReceberDano(50);
        batman.SetPontuacao(batman.GetPontuacao() + 30);
        Console.WriteLine($"Pontuação do Batman: {batman.GetPontuacao()}");
        coringa.UsarHabilidade("Gás do Riso", batman);
        coringa.SetPontuacao(coringa.GetPontuacao() + 30);
        Console.WriteLine($"Pontuação do Coringa: {coringa.GetPontuacao()}");
        batman.UsarHabilidade("Ultra Bat-Garra", coringa);
        coringa.ReceberDano(999); // Para simular a morte
        batman.SetPontuacao(batman.GetPontuacao() + 100);
        Console.WriteLine($"Pontuação do Batman: {batman.GetPontuacao()}");
        batman.SubirNivel();

        Console.ReadLine();
    }
}
