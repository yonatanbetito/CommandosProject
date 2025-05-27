namespace Commandos;
using Commandos;

class Program
{
    static void Main(string[] args)
    {
        Commando commando = new Commando("yonatan", "Stockholm");
        Weapons weapon = new Weapons("AK-47", "Kalashnikov", 30);
        commando.Hide();
        weapon.Shoot();
        weapon.Shoot();
        weapon.Shoot();
    }
}