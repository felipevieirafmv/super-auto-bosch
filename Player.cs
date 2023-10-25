using System.CodeDom;

public abstract class Player
{
    public int Vida { get; set; }
    public int Trofeus { get; set; }
    public List<Machine> Time = new();
    public abstract void Construtor();
}

public abstract class Player1 : Player
{
    public override void Construtor()
    {
        this.Vida = 5;
        this.Trofeus = 0;
    }
}