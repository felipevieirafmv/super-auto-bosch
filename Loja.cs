using System;
using System.Drawing.Imaging;

public class Loja
{
    public int Gold {get; set;} = 10;

    protected List<Machine> machines = new List<Machine>();
    protected List<Machine> baseMachines = new List<Machine>();

    public void Buy(int index, Player player)
    {
        if (Gold < 3)
            return;

        this.Gold -= 3;
        var comprado = baseMachines[index];
        baseMachines.Remove(comprado);
        player.Time.Add(comprado);
        comprado.BuyEffect();
    }

    public void Add(Machine baseMachine)
        => this.baseMachines.Add(baseMachine);

    public void AddBaseMachines(){
    }
    public void Refill()
    {
                if (Gold<1)
            return;

        Gold--;
        machines.Clear();
        machines.Add(getRandomMaquina());
        machines.Add(getRandomMaquina());
        machines.Add(getRandomMaquina());

    }
    private Machine getRandomMaquina()
    {

        int index = Random.Shared.Next(baseMachines.Count);
        var baseMachine = this.baseMachines[index];
        return baseMachine.Clone();
    }

    public void FreeRefill(int index)
    {
        machines.Clear();

        for (int i = 0; i < index;i++)
            machines.Add(getRandomMaquina());

    }


}
