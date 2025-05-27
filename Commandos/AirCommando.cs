namespace Commandos;

public class AirCommando : Commando
{
    //private bool isAirborn;

    public AirCommando(string name, string codename) : base(name, codename)
    {
    }

    public void Parachuting()
    {
        Console.WriteLine("Wow");
    }

    public override void attack()
    {
        Console.WriteLine($"{CodeName} from Air Commando he attacks.");
    }
}