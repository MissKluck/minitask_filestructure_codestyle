public class Implement
{
    private readonly Generic<string, int> pokemon = new Generic<string, int>();

    public void WriteMethod()
    {
        pokemon.Type = "Fire";
        pokemon.Generation = 1;
    }

}