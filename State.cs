using System;

public abstract class State
{
    public Loja loja;
    public Time time;
    public State NextState { get; set; }
    public abstract void Act();
}
public class InicioLojaState : State
{
    public override void Act()
    {
        var quant = 0;
        loja.Moeda = 10;
        if (App.Turno < 5)
        {
            quant = 3;
        }
        else if (App.Turno > 8)
        {
            quant = 5;
        }
        else
            quant = 4;
        loja.FreeRefill(quant);
        foreach (machine M in time)
            M.TurnBegin();
    }
}

public class LojaState : State
{
    //libera a compra
}
public class FimLojaState : State
{
    foreach(machine M in time)
        M.TurnEnd();
}
public class InicioBatalhaState : State
{

}
public class BatalhaState : State
{

}

public class RotateState : State
{
    public float AngleTarget { get; set; }
    public override void Act()
    {
        var dTheta = AngleTarget - enemy.Angle;

        if (MathF.Abs(dTheta) < 0.05)
        {
            this.enemy.State = NextState;
            return;
        }

        enemy.Angle += 0.1f * MathF.Sign(dTheta);
    }
}
