public class CortePlasma : Machine
{
    public CortePlasma()
    {
        this.Ataque = 6;
        this.Vida = 8;
        this.Tier = 5;
        this.EffectNumber = 1;
        this.Nome = "Corte a Plasmas";
    }

    public override Machine Clone()
    {
        CortePlasma cortePlasma = new CortePlasma();

        cortePlasma.Ataque = this.Ataque;
        cortePlasma.Vida = this.Vida;
        cortePlasma.Experiencia = this.Experiencia;

        return cortePlasma;
    }
}