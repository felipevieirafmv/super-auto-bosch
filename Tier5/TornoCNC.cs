public class TornoCNC : Machine
{
    public TornoCNC()
    {
        this.Ataque = 5;
        this.Vida = 8;
        this.Tier = 5;
        this.EffectNumber = 1;
        this.Nome = "Fresa";
    }

    public override Machine Clone()
    {
        TornoCNC torno = new TornoCNC();

        torno.Ataque = this.Ataque;
        torno.Vida = this.Vida;
        torno.Experiencia = this.Experiencia;

        return torno;
    }
}