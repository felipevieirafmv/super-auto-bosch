// using System;

// public abstract class Shop
// {
//     public int Gold {get; set;} = 10;

//     private List<Pet> pets = new List<Pet>();
//     private List<Pet> basePets = new List<Pet>();

//     public void Buy(int index, Team team)
//     {
//         if (Gold < 3)
//             return;

//         Gold -=3;
//         var bought = pets[index];
//         pets.Remove(bought);
//         team.Add(bought);
//         bought.BuyEffect();
//     }

//     public void Add(Pet basePet)
//         => this.basePets.Add(basePet);

//     public void Refill()
//     {
//         if (Gold<1)
//             return;

//         Gold--;
//         pets.Clear();
//         pets.Add(getRandomPet());
//         pets.Add(getRandomPet());
//         pets.Add(getRandomPet());
//     }

//     private Pet getRandomPet()
//     {
//         int index = Random.Shared.Next(basePets.Count);
//         var basePet = this.basePets[index];
//         return basePet.Clone();
//     }

//     public void FreeRefill()
//     {
//         pets.Clear();
//         pets.Add(getRandomPet());
//         pets.Add(getRandomPet());
//         pets.Add(getRandomPet());
//     }
// }
