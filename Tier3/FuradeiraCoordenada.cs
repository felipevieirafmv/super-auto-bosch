using System;

public class FuradeiraCoordenada : Machine
{
    public FuradeiraCoordenada()
    {
        this.Ataque = 3;
        this.Vida = 5;
        this.Tier = 3;
        this.EffectNumber = 1;
        this.Nome = "Furadeira Coordenada";
    }

    public override void HurtEffect(Enemy inimigo, Player player)
    {
        var enemyTeam = inimigo.EnemyTeam;
        var enemyTemaSize = enemyTeam.Count();
        Random rnd = new Random();
        int randomNumber = rnd.Next(0, enemyTemaSize);

        enemyTeam[randomNumber].ReceiveDamage(EffectNumber);
    }

    public override Machine Clone()
    {
        FuradeiraCoordenada furadeira = new FuradeiraCoordenada();

        furadeira.Ataque = this.Ataque;
        furadeira.Vida = this.Vida;
        furadeira.Experiencia = this.Experiencia;

        return furadeira;
    }
}