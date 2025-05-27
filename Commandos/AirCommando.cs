namespace Commandos;

public class AirCommando : Commando
{
    private bool isAirborn;

    public AirCommando(string name, string codename ,bool isairborn) : base(name, codename)
    {
        isAirborn = isairborn;
    }

    public void Parachuting()
    {
        Console.WriteLine("Wow");
    }
    
}