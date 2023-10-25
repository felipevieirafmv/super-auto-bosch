public class Torno : Machine
{
    public Torno()
    {
        this.Ataque = 5;
        this.Vida = 3;
        this.Tier = 4;
        this.EffectNumber = 2;
        this.Nome = "Fresa";
    }

    public override void TurnEnd(Player player)
    {
        foreach (Machine machine in player.Time)
        {
            if (machine.Level == 3)
            {
                this.Ataque += EffectNumber;
                this.Vida += EffectNumber;
            }
        }
    }

    public override Machine Clone()
    {
        Torno torno = new Torno();

        torno.Ataque = this.Ataque;
        torno.Vida = this.Vida;
        torno.Experiencia = this.Experiencia;

        return torno;
    }
}