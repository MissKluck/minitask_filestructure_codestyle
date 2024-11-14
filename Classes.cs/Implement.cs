public class Implement<Gen1, Gen2> : Generic<Gen1, Gen2>, IGeneric
{
    private readonly Generic<string, int> pokemon = new Generic<string, int>();

    public void WriteMethod()
    {
        pokemon.Type = "Fire";
        pokemon.Generation = 1;
    }

    public void Display()
    {
        Console.WriteLine(ToString());
    }

    //public void DisplayMessage(string message)
    //{
    //    Console.WriteLine($"{message}");
    //}

}