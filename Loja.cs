using System;

public abstract class Loja
{
    public int Moeda {get; set;} = 10;

    private List<Pet> pets = new List<Pet>();

    private List<Pet> basePets = new List<Pet>();

    public void Buy(int index, Team team);

    public void Add(Pet basePet);

    public void Refill();

    private Pet getRandomPet();

    public void FreeRefill();
}
