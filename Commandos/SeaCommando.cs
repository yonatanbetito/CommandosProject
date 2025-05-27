namespace Commandos;

public class SeaCommando:Commando
{
    //public bool isMarine;

    public SeaCommando(string name, string codename) : base(name, codename)
    {
    }
    
    public void Swim()
    {
        Console.WriteLine("swim");
    }
    
    public override void attack()
    {
        Console.WriteLine($"{CodeName} from Sea Commando he attacks.");
    }
}