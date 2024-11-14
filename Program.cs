namespace minitask_filestructure_codestyle;

class Program
{
    static void Main(string[] args)
    {
        Implement<string, int> pokemon = new Implement<string, int>();
        pokemon.PokemonName = "Pikachu";
        pokemon.Type = "Electric";
        pokemon.Generation = 1;
        pokemon.PokedexNumber = 25;

        pokemon.Display();

        Console.ReadLine();
    }
}
