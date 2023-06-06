namespace PokemonInterface;

public class Sparklechu : IPokemon
{
    public int Health { get; set; }

    public Sparklechu(int health)
    {
        Health = health;
    }

    public void ThunderShock(IPokemon target)
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