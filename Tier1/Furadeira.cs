public class Furadeira : Machine
{
    public Furadeira()
    {
        this.Ataque = 2;
        this.Vida = 1;
        this.Tier = 1;
        this.EffectNumber = 1;
    }

    public override void FaintEffect(Player player ) 
    { 
        var playerTeam = player.Time;
        if (playerTeam == null)
            return;
        var playerTeamSize = playerTeam.Count();
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, playerTeamSize);

        playerTeam[randomNumber].Ataque += 2 * EffectNumber;
        playerTeam[randomNumber].Vida   += EffectNumber;
    }

    public override Machine Clone()
    {
        Furadeira furadeira = new Furadeira();

        furadeira.Ataque = this.Ataque;
        furadeira.Vida = this.Vida;
        furadeira.Experiencia = this.Experiencia;

        return furadeira;
    }
}
