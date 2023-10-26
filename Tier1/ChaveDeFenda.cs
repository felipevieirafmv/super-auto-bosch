public class ChaveDeFenda : Machine
{
    public ChaveDeFenda()
    {
        this.Ataque = 2;
        this.Vida = 3;
        this.Tier = 1;
        this.EffectNumber = 1;
        this.Nome = "Chave de Fenda";
    }

    public override void SellEffect(Player player)
    {
        var playerTeam = player.Time;
        if (playerTeam == null)
            return;
        var playerTeamSize = playerTeam.Count();
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, playerTeamSize);

        playerTeam[randomNumber].Vida += EffectNumber;
    }

    public override Machine Clone()
    {
        ChaveDeFenda chave = new ChaveDeFenda();

        chave.Ataque = this.Ataque;
        chave.Vida = this.Vida;
        chave.Experiencia = this.Experiencia;

        return chave;
    }
}

public class FChaveDeFenda : FoodMachine
{
    public FChaveDeFenda()
    {
        this.Ataque = 2;
        this.Vida = 3;
        this.Tier = 1;
        this.Nome = "Chave de Fenda";
    }

    public override FoodMachine Clone()
    {
        FChaveDeFenda chave = new FChaveDeFenda();

        chave.Ataque = this.Ataque;
        chave.Vida = this.Vida;
        chave.Experiencia = this.Experiencia;

        return chave;
    }
}