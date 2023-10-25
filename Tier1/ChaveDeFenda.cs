public class ChaveDeFenda : Machine
{
    public ChaveDeFenda()
    {
        this.Ataque = 2;
        this.Vida = 3;
        this.Tier = 1;
        this.Nome = "Chave de Fenda";
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