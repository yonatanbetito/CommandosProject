namespace Commandos;

public class SeaCommando:Commando
{
    public bool isMarine;

    public SeaCommando(string name, string codename, bool ismarine) : base(name, codename)
    {
        isMarine = ismarine;
    }
    
    public void Swim()
    {
        Console.WriteLine("swim");
    }
}