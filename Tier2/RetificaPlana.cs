public class RetificaPlana : Machine
{
    public RetificaPlana()
    {
        this.Ataque = 4;
        this.Vida = 2;
        this.Tier = 2;
        this.Nome = "Retífica Plana";
    }

    public override Machine Clone()
    {
        RetificaPlana retPlana = new RetificaPlana();

        retPlana.Ataque = this.Ataque;
        retPlana.Vida = this.Vida;
        retPlana.Experiencia = this.Experiencia;

        return retPlana;
    }
}