public class FuradeiraColuna : Machine
{
    public FuradeiraColuna()
    {
        this.Ataque = 3;
        this.Vida = 5;
        this.Tier = 2;
        this.Nome = "Furadeira de Coluna";
    }

    public override Machine Clone()
    {
        FuradeiraColuna furadeira = new FuradeiraColuna();

        furadeira.Ataque = this.Ataque;
        furadeira.Vida = this.Vida;
        furadeira.Experiencia = this.Experiencia;

        return furadeira;
    }
}