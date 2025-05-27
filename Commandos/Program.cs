namespace Commandos;
using Commandos;

class Program
{
    static void Main(string[] args)
    {
        
        Commando commando = new Commando("yonatan", "Stockholm");
        AirCommando aircommando = new AirCommando("amir", "Lisbon");
        SeaCommando seacommando = new SeaCommando("roni", "Tokyo");
        Commando[] ListOfSoldiers = { commando, aircommando, seacommando };

        foreach (var soldier in ListOfSoldiers)
        {
            soldier.attack();
        }
        
        
        Weapons weapon = new Weapons("AK-47", "Kalashnikov", 30);
        commando.Hide();
        weapon.Shoot();
    }
}