namespace PokemonInterface;

public class Magikarp : IPokemon
{
    private bool isUseless;

    public int Health { get; set; }

    public Magikarp(int health)
    {
        Health = health;
    }
    
    public void Splash(IPokemon target)
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