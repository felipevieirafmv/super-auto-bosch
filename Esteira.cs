public class Esteira : Machine
{
    public Esteira()
    {
        this.Ataque = 2;
        this.Vida = 3;
        this.Tier = 1;
    }

    public override Machine Clone()
    {
        Esteira esteira = new Esteira();

        esteira.Ataque = this.Ataque;
        esteira.Vida = this.Vida;
        esteira.Experiencia = this.Experiencia;

        return esteira;
    }
}