namespace Commandos;

public class Weapons
{
    public string NameWeapon;
    public string ManufacturerName;
    public int NumOfBullets;

    public Weapons(string nameweapon,string manufacturername,int numofbullets)
    {
        NameWeapon = nameweapon;
        ManufacturerName = manufacturername;
        NumOfBullets = numofbullets;
    }
    
    public int Shoot()
    {
        if (NumOfBullets > 0)
        {
            NumOfBullets--;
            Console.WriteLine($"{NameWeapon} is shooting. Bullets left: {NumOfBullets}");
            return NumOfBullets;
        }
        else
        {
            Console.WriteLine($"{NameWeapon} has no bullets left.");
            return 0;
        }
    }
}