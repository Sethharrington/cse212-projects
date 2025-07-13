public class Person
{
    public readonly string Name;
    public int Turns { get; set; }

    public bool InfiniteTurns { get; set; }

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
        InfiniteTurns = turns <= 0 ? true : false;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";
    }
}