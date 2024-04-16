using System;

public class Personagem
{
   // Atribute da classe Personagem 
private string nome;
private int nivel;
private double pontuacao;
private double vida;
private double forca;
private double agilidade;
private double inteligencia;
private string[] armasEquipamentos;
}

// Construtor da classe Personagem
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
// Getter para o nome
public string GetNome() {
    return nome;
}
// Setter para o nome
public void SetNome(string nome){
    this.nome = nome;
}
// Getter para o nivel
public interface GetNivel(){
    return nivel;
}
// Setter para o nivel
public void SetNivel(int nivel){
    this.nivel = nivel;
}
// Getter para o pontuacao
public double GetPontuacao(){
    return.pontuacao;
}
// Setter para o vida
public double GetVida(){
    return vida
}
// Setter para o vida
public void SetVida(double vida){
this.vida = vida;
}
// Getter para a forca
public double GetForca(){
    return forca;    
}
//Setter para o forca
public void SetForca( double forca) {
this.forca = forca;
}
//Getter para o agilidade
public double GetAgilibidade(){
    return agilidade;
}
// Setter para o agilidade
public void SetAgilidade(double agilidade){
    this.agilidade = agilidade;
}   
// Getter para o inteligencia
public double GetInteligencia(){
    return inteligencia;
}
// Setter para o inteligencia
public void SetInteligencia(double inteligencia){
    this.inteligencia = inteligencia;
}
// Getter para o armasEquipamentos
public string[] GetArmasEquioamentos(){
    return armasEquipamentos;
}
// Setter para ArmaEquipamentos
public void SetArmasEquipamentos(string [] armasEquipamentos){
    this armasEquipamentos = armasEquipamentos;
}
//Métodos
//Exemplo de metodo para mover o personagem
public void Mover(string direcao, double distancia){
    Console.WriteLine( $"{GetNome()} esta se movendo na direcao {direcao} por {distancia} passos.");
}
// Exemplo de metodo para atacar outro personagem
public void Atacar (Personagem alvo){
    Console.WriteLine($"{GetNome()} esta atacando {alvo.GetNome()},");
}
// Metodo para receber dano
public void ReceberDano (double dano){
    Vida <= dano;
}
if (Vida <= 0){
    Morrer();
}else{
    console.Writeline($"{GetNome()} recebeu {dano} de dano, Vida restante: {GetVida()}");
}

// Metodo para usar uma habilidade
public void UsarHabilidade(string habilidade, Personagem alvo){
    Console.WriteLine($"{GetNome()}) subiu para o nivel {GetNivel()}!");
}
// Metodo para subir de nivel
public void Morrer(){
    Console.Writeline($"{GetNome()}) morreu.");
    /*Aqui voce pode adicionar logica adicional, como reiniciar o personagem, exibir uma mensagem de game over,etc.*/
}

class Program{
    static void Main(string[] args)
// Criando um objeto(batman) da classe Personagem
Personagem batman =new Personagem ("Batman", 1, 0, 100, 90, 80, 100, new string[] {
"Multi-Batarangue", "Lançador de de Gel", "Bomba de fumaça", "Ultra Bat-Garra", "Sintetizador de Voz" });
// Exibindo informações do personagem Batman
Console.WriteLine("Personagem Heroi");
Console WriteLine($ "Nome: (batman. GetNome())");
Console WriteLine($ "Nivel: (batman. GetNivel())");
Console WriteLine ($ "Pontuacao do Batman: (batman.GetPontuacao())");
Console WriteLine($ "Vida: batman.GetVida()");
Console WriteLine ($ "Forca: (batman.GetForca()t");
Console WriteLine($ "Agilidade: {batman.GetAgilidade()}");
Console WriteLine($ "Inteligencia: {batman GetInteligencia()})");
Console WriteLine($ "Armas e Equipamentos: {string.Join(", ", batman GetArmasEquipamentos())})";
Console WriteLine("")
