public class Jogo
{
    public Player1 player1 { get; set; }
    public Enemy enemy { get; set; }
    private State State = null;

    public Jogo(State state)
    {
        this.TransitionTo(state);
    }
    public void TransitionTo(State state)
    {
        this.State = state;
        this.State.SetJogo(this);
    }

    public void Act()
    {
        this.State.Act();
    }
}
