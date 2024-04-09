using System;

public class Veiculo
{
    private string marca;
    private string modelo;

    public Veiculo(string marca, string modelo)
    {
        this.marca = marca;
        this.modelo = modelo;
    }

    public string Marca
    {
        get { return marca; }
    }

    public string Modelo
    {
        get { return modelo; }
    }

    public void Ligar()
    {
        Console.WriteLine("Veículo ligado.");
    }

    public void Desligar()
    {
        Console.WriteLine("Veículo desligado.");
    }
}

public class Carro : Veiculo
{
    private string cor;

    public Carro(string marca, string modelo, string cor) : base(marca, modelo)
    {
        this.cor = cor;
    }

    public string Cor
    {
        get { return cor; }
    }

    public void Acelerar()
    {
        Console.WriteLine("Carro acelerando.");
    }

    public void Frear()
    {
        Console.WriteLine("Carro freando.");
    }
}

public class Moto : Veiculo
{
    private string cilindrada;

    public Moto(string marca, string modelo, string cilindrada) : base(marca, modelo)
    {
        this.cilindrada = cilindrada;
    }

    public string Cilindrada
    {
        get { return cilindrada; }
    }

    public void Empinar()
    {
        Console.WriteLine("Moto empinando.");
    }

    public void Buzinar()
    {
        Console.WriteLine("Moto buzinando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando objetos
        Carro meuCarro = new Carro("Toyota", "Corolla", "Preto");
        Moto minhaMoto = new Moto("Honda", "CBR600RR", "600cc");

        // Usando métodos dos objetos
        Console.WriteLine("Marca do Carro: " + meuCarro.Marca);
        Console.WriteLine("Modelo do Carro: " + meuCarro.Modelo);
        Console.WriteLine("Cor do Carro: " + meuCarro.Cor);
        meuCarro.Ligar();
        meuCarro.Acelerar();
        meuCarro.Frear();
        meuCarro.Desligar();

        Console.WriteLine("\nMarca da Moto: " + minhaMoto.Marca);
        Console.WriteLine("Modelo da Moto: " + minhaMoto.Modelo);
        Console.WriteLine("Cilindrada da Moto: " + minhaMoto.Cilindrada);
        minhaMoto.Ligar();
        minhaMoto.Empinar();
        minhaMoto.Buzinar();
        minhaMoto.Desligar();
    }
}
