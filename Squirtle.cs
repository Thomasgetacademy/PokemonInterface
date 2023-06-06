namespace PokemonInterface;

public class Squirtle : IPokemon
{
    public int Health { get; set; }

    public Squirtle(int health)
    {
        Health = health;
    }

    public void WaterGun(IPokemon target)
    {
        Attack(target);
    }

    public void Attack(IPokemon target)
    {
        target.LooseHealth();
    }

    public void LooseHealth()
    {
        Health -= 10;
    }
}