using System;
using System.Drawing.Imaging;

public class Loja
{
    public int Gold {get; set;} = 10;

<<<<<<< HEAD
    protected List<Machine> machines = new List<Machine>();
    protected List<Machine> baseMachines { get; set; }
=======
    public List<Machine> machines = new List<Machine>();
    protected List<Machine> baseMachines = new List<Machine>();
>>>>>>> d53135f31ce342de4bfa473ee7d2cff21c317d46

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
    public Machine getRandomMaquina()
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
