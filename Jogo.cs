public class Jogo
{
    public Player player1 = new Player1();
    public Enemy enemy { get; set; }
    public State State = null;
    public int turno = 0;
    public Jogo(State state)
    {
        this.TransitionTo(state);
    }
    public void TransitionTo(State state)
    {
        this.State = state;
        this.State.SetJogo(this);
    }

    public void Start()
    {
        machines.Add(new ChaveDeFenda());
        machines.Add(new Esteira());
        machines.Add(new Martelo());
        machines.Add(new FornoIndustrialAGas());
        machines.Add(new FuradeiraColuna());
        machines.Add(new RetificaPlana());
        machines.Add(new FornoIndustrialEletrico());
        machines.Add(new FuradeiraCoordenada());
        machines.Add(new RetificaCilindrica());
        machines.Add(new Fresa());
        machines.Add(new Torno());
        machines.Add(new TornoCNC());

        player1.Construtor();

        player1.baseMachines = machines;
        enemy.lojaEnemy = machines;

        

    }
}
