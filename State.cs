using System;

public abstract class State
{
    public App app { get; set; }
    public Loja loja { get; set; }
    public Player1 player1 { get; set; }
    protected Jogo jogo;

    public void SetJogo(Jogo jogo)
    {
        this.jogo = jogo;
    }
    public abstract void Act();
}
public class InicioLojaState : State
{
    public override void Act()
    {
        var quant = 0;
        loja.Gold = 10;
        if (app.Turno < 5)
        {
            quant = 3;
        }
        else if (app.Turno > 8)
        {
            quant = 5;
        }
        else
            quant = 4;
        loja.FreeRefill(quant);
        foreach (Machine M in player1.Time)
            M.TurnBegin(loja);

        //Desenhar a loja

        this.jogo.TransitionTo(new FimLojaState());
    }
}

public class FimLojaState : State
{
    public override void Act()
    {
        foreach(Machine M in player1.Time)
            M.TurnEnd(player1);

        this.jogo.TransitionTo(new InicioBatalhaState());
    }
}
public class InicioBatalhaState : State
{
    public override void Act()
    {
        //Desenhar campo de batalha
        foreach (Machine M in player1.Time)
            M.StartBattleEffect();
        this.jogo.TransitionTo(new BatalhaState());
    }
}
public class BatalhaState : State
{
    public override void Act()
    {
        //Porradaria franca
        this.jogo.TransitionTo(new FimBatalhaState());
    }
}

public class FimBatalhaState : State
{
    public override void Act()
    {
        //Vitoria, derrota ou empate
        this.jogo.TransitionTo(new InicioLojaState());

    }
}
