using System;
using System.Drawing.Imaging;

public abstract class Loja
{
    public int Gold {get; set;} = 10;

    protected List<Machine> machines = new List<Machine>();
    protected List<Machine> baseMachines = new List<Machine>();

    public void Buy(int index, Time time)
    {
        if (Gold < 3)
            return;

        this.Gold -= 3;
        var comprado = baseMachines[index];
        baseMachines.Remove(comprado);
        time.Add(comprado);
        comprado.BuyEffect();
    }

    public void Add(Machine baseMachine)
        => this.baseMachines.Add(baseMachine);

    public void AddBaseMachines(){
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
