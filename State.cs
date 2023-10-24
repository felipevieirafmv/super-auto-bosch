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
        loja.Moeda = 10;
        loja.FreeRefill();
        foreach (machine M in time)
        {
            M.StartTurn();
        }
    }
}

public class LojaState : State
{
    
}
public class FimLojaState : State
{

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
