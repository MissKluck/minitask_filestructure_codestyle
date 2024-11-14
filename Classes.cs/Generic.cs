public class Generic<T1, T2>
{
    public T1? Type { get; set; }
    public T2? Generation { get; set; }
    public int PokedexNumber { get; set; }
    public string PokemonName { get; set; }

    public override string ToString()
    {
        return $"Your pokemon is {PokemonName} from generation {Generation}. It is a {Type} type pokemon, and it's Pokedex Number is {PokedexNumber}.";
    }

}