public abstract class Machine
{
    public int Attack {get; set;}
    public int Life {get; set;}
    public int Experience {get; set;}
    public bool Fainted {get; private set;}

    public int Level =>
        Experience switch
        {
            < 3 => 1,
            < 6 => 2,
            _ => 1,
        };

    public void AttackPet(Machine machine)
    {
        this.ReceiveDamage(machine.Attack);
        machine.ReceiveDamage(this.Attack);
    }

    public void ReceiveDamage(int damage)
    {
        this.Life -= damage;
        if (this.Life <=0)
            this.Fainted = true;
    }

    public void Union(Machine pet)
    {
        if (this.GetType() != pet.GetType())
            throw new InvalidOperationException(
                "Você não pode juntar peças diferentes"
            );

        int oldLevel = this.Level;

        
        this.Attack = this.Attack > pet.Attack ?
            this.Attack : pet.Attack;

        this.Life = this.Life > pet.Life ?
            this.Life : pet.Life;

        int levelUp = this.Experience > pet.Experience ?
            pet.Experience : this.Experience;

        this.Attack += levelUp;
        this.Life += levelUp;

        this.Experience += pet.Experience;
        if (this.Experience > 6)
            this.Experience = 6;
        
        if (this.Level > oldLevel)
            LevelUpEffect();
        
    }

    public virtual void FaintEffect()
        => null;
    public virtual void SellEffect(Shop shop)
        => null;
    public virtual void BuyEffect()
        => null;
    public virtual void LevelUpEffect()
        => null;
    public virtual void StartBattleEffect()
        => null;
    public virtual void AllySummonedEffect()
        => null;
    public abstract Machine Clone();

}
