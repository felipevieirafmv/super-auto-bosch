public class FornoIndustrialAGas : Machine
{
    public FornoIndustrialAGas()
    {
        this.Ataque = 1;
        this.Vida = 3;
        this.Tier = 2;
        this.Nome = "Forno Industrial A Gas";
    }

    public override void TurnBegin(Loja loja)
    {
        loja.Gold += 1;
    }

    public override Machine Clone()
    {
        FornoIndustrialAGas forno = new FornoIndustrialAGas();

        forno.Ataque = this.Ataque;
        forno.Vida = this.Vida;
        forno.Experiencia = this.Experiencia;

        return forno;
    }
}