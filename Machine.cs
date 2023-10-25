public abstract class Machine
{
    public int Ataque       { get; set; }
    public int Vida         { get; set; }
    public int Experiencia  { get; set; }
    public bool Desmaiou    { get; private set; }
    public int Tier         { get; set; }
    public string Nome      { get; set; }
    public int EffectNumber { get; set; }

    public int Level =>
        Experiencia switch
        {
            < 3 => 1,
            < 6 => 2,
            _ => 3,
        };

    public void AttackPet(Machine machine)
    {
        this.ReceiveDamage(machine.Ataque);
        machine.ReceiveDamage(this.Ataque);
    }

    public void ReceiveDamage(int damage)
    {
        this.Vida -= damage;
        if (this.Vida <= 0)
            this.Desmaiou = true;
    }

    public void Union(Machine machine)
    {
        if (this.GetType() != machine.GetType())
            throw new InvalidOperationException(
                "Você não pode juntar peças diferentes"
            );

        int oldLevel = this.Level;

        
        this.Ataque = this.Ataque > machine.Ataque ?
            this.Ataque : machine.Ataque;

        this.Vida = this.Vida > machine.Vida ?
            this.Vida : machine.Vida;

        int levelUp = this.Experiencia > machine.Experiencia ?
            machine.Experiencia : this.Experiencia;

        this.Ataque += levelUp;
        this.Vida += levelUp;

        this.Experiencia += machine.Experiencia;
        if (this.Experiencia > 6)
            this.Experiencia = 6;
        
        if (this.Level > oldLevel)
            LevelUpEffect();
        
    }

    public virtual void FaintEffect( ) { }
    public virtual void SellEffect(Loja loja ) { }
    public virtual void BuyEffect( ) { }
    public virtual void LevelUpEffect( ) { }
    public virtual void StartBattleEffect( ) { }
    public virtual void HurtEffect(Enemy inimigo, Player player ) { }
    public virtual void TurnBegin(Loja loja) { }
    public virtual void TurnEnd(Player player ) { }
    public virtual void AllySummonedEffect( ) { }
    public abstract Machine Clone( );

}
