using System;

public abstract class State
{
    public App app;
    public Loja loja;
    public Team time;
    public State NextState { get; set; }
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
        foreach (Machine M in time.machines)
            M.TurnBegin();
        //Desenhar a loja

    }
}

public class FimLojaState : State
{
    public override void Act()
    {
        foreach(Machine M in time.machines)
            M.TurnEnd();
    }
}
public class InicioBatalhaState : State
{
    public override void Act()
    {
        //Desenhar campo de batalha
        foreach (Machine M in time.machines)
            M.StartBattleEffect();
    }
}
public class BatalhaState : State
{
    public override void Act()
    {
        //Porradaria franca
    }
}

public class FimBatalha : State
{
    public override void Act()
    {
        //Vitoria, derrota ou empate
    }
}
