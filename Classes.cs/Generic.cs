public class Generic<T1, T2>
{
    public T1? Type { get; set; }
    public T2? Generation { get; set; }
    public int PokedexNumber { get; set; }
    public string? PokemonName { get; set; }

    public override string ToString()
    {
        return $"Your Pokemon is {PokemonName} from generation {Generation}. It is a Pokemon of type {Type}, and it's Pokedex number is {PokedexNumber}.";
    }

}