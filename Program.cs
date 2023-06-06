namespace PokemonInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Creates a list with "IPokemon" interface types, and adds three pokemons*/
            var wildPokemon = new List<IPokemon>();
            wildPokemon.Add(new Squirtle(100));
            wildPokemon.Add(new Flametusk(100));
            wildPokemon.Add(new Sparklechu(100));

            /* Passes the wildPokemon list through a method that returns a random pokemon from the list */
            var selectedPokemon = GetWildPokemon(wildPokemon);
            string pokemonName = selectedPokemon.GetType().Name;

            var magikarp = new Magikarp(90);

            while (magikarp.Health > -1)
            {

                selectedPokemon.Attack(selectedPokemon);

                if (magikarp.Health == 0)
                {
                    Console.WriteLine($"Magicarp was attacked! and has {magikarp.Health} health left. And lost the fight.... again...");
                    break;
                }
                Console.WriteLine($"{pokemonName} attacked Magikarp, Magikarp has {magikarp.Health} health left.");

                magikarp.Splash(magikarp);
                Console.WriteLine($"Magikarp attacked {pokemonName}, {pokemonName} has {selectedPokemon.Health} health left.");
            }
        }

        private static IPokemon GetWildPokemon(List<IPokemon> wildPokemon)
        {
            var random = new Random();
            int index = random.Next(wildPokemon.Count);
            return wildPokemon[index];
        }
    }
}