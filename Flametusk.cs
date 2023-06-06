namespace PokemonInterface;

public class Flametusk : IPokemon
{
    public int Health { get; set; }

    public Flametusk(int health)
    {
        Health = health;
    }

    public void Flamethrower(IPokemon target)
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