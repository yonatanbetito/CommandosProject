using Microsoft.VisualBasic;

namespace Commandos;

public enum CommandoStatus
{
    Standing,
    Walking,
    Hiding
}

public class Commando
{
    public string SolderName;
    public string CodeName;
    public string[] Tools = new[] { "Hammer", "Chisel", "Rope", "Bag", "WaterBottle" };
    public CommandoStatus Status;

    public Commando(string soldername, string codeName)
    {
        SolderName = soldername;
        CodeName = codeName;
        Status = CommandoStatus.Standing;
    }

    public void  Walk()
    {
        Status = CommandoStatus.Walking;
        Console.WriteLine(Status);
    }

    public void Hide()
    {
        Status = CommandoStatus.Hiding;
        Console.WriteLine(Status);
    }

    public void attack()
    {
        Console.WriteLine($"{SolderName} He attacks.");
    }
}