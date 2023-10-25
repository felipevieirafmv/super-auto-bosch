public class Fresa : Machine
{
    public Fresa()
    {
        this.Ataque = 4;
        this.Vida = 5;
        this.Tier = 4;
        this.Nome = "Fresa";
    }

    public override Machine Clone()
    {
        Fresa fresa = new Fresa();

        fresa.Ataque = this.Ataque;
        fresa.Vida = this.Vida;
        fresa.Experiencia = this.Experiencia;

        return fresa;
    }
}