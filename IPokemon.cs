namespace PokemonInterface;

public interface IPokemon
{
    int Health { get; }
    void Attack(IPokemon target);
    void LooseHealth();
}