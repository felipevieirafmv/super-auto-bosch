public class Martelo : Machine
{
    public Martelo()
    {
        this.Ataque = 2;
        this.Vida = 3;
        this.Tier = 1;
    }

    public override void SellEffect(Player player)
    {
        foreach (Machine m in player.lojaPlayer.machines)
            m.Vida +=1;
    }

    public override Machine Clone()
    {
        Martelo martelo = new Martelo();

        martelo.Ataque = this.Ataque;
        martelo.Vida = this.Vida;
        martelo.Experiencia = this.Experiencia;

        return martelo;
    }
}