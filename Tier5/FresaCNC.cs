public class FresaCNC : Machine
{
    public FresaCNC()
    {
        this.Ataque = 8;
        this.Vida = 4;
        this.Tier = 5;
        this.Nome = "Fresa CNC";
    }

    public override Machine Clone()
    {
        FresaCNC fresa = new FresaCNC();

        fresa.Ataque = this.Ataque;
        fresa.Vida = this.Vida;
        fresa.Experiencia = this.Experiencia;

        return fresa;
    }
}