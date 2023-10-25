using System;

public class FornoIndustrialEletrico : Machine
{
    public FornoIndustrialEletrico()
    {
        this.Ataque = 4;
        this.Vida = 3;
        this.Tier = 3;
        this.EffectNumber = 1;
        this.Nome = "Furadeira Coordenada";
    }

    public override Machine Clone()
    {
        FornoIndustrialEletrico forno = new FornoIndustrialEletrico();

        forno.Ataque = this.Ataque;
        forno.Vida = this.Vida;
        forno.Experiencia = this.Experiencia;

        return forno;
    }
}
