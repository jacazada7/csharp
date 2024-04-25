using System;

interface IAtaque {
    void Atacar();
}

class Guerreiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Guerreiro ataca com espada!");
    }
}

class Mago : IAtaque {
    public void Atacar() {
        Console.WriteLine("Mago lança bola de fogo!");
    }
}

class Arqueiro : IAtaque {
    public void Atacar() {
        Console.WriteLine("Arqueiro dispara flechas!");
    }
}
class Program{
    static void Main (string[] args) {

    IAtaque guerreiro = new Guerreiro();
    IAtaque mago = new Mago();
    IAtaque arqueiro = new Arqueiro();
    
    guerreiro.Atacar();
    mago.Atacar();
    arqueiro.Atacar();
    }
}
