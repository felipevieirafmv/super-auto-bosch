public class Jogo
{
    public Player player1 = new Player1();
    public Enemy enemy { get; set; }
    public Loja loja { get; set; }
    public State State = null;

    public Jogo(State state)
    {
        this.TransitionTo(state);
        this.Start(loja);
    }
    public void TransitionTo(State state)
    {
        this.State = state;
        this.State.SetJogo(this);
    }

    public void Start(Loja loja)
    {
        loja.Add(new ChaveDeFenda());
        loja.Add(new Esteira());
        loja.Add(new Martelo());
        loja.Add(new FornoIndustrialAGas());
        loja.Add(new FuradeiraColuna());
        loja.Add(new RetificaPlana());
        loja.Add(new FornoIndustrialEletrico());
        loja.Add(new FuradeiraCoordenada());
        loja.Add(new RetificaCilindrica());
        loja.Add(new Fresa());
        loja.Add(new Torno());
        loja.Add(new TornoCNC());

        player1.Construtor();

        player1.lojaPlayer = loja;
        enemy.lojaEnemy = loja;


    }
}
