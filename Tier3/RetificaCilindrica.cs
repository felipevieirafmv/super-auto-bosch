public class RetificaCilindrica : Machine
{
    public RetificaCilindrica()
    {
        this.Ataque = 2;
        this.Vida = 6;
        this.Tier = 3;
        this.Nome = "Retífica Cilindrica";
    }

    public override Machine Clone()
    {
        RetificaCilindrica retCilindro = new RetificaCilindrica();

        retCilindro.Ataque = this.Ataque;
        retCilindro.Vida = this.Vida;
        retCilindro.Experiencia = this.Experiencia;

        return retCilindro;
    }
}