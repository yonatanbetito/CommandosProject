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
    private string SolderName;
    public string CodeName { get; private set;}
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

    public virtual void attack()
    {
        Console.WriteLine($"{CodeName} He attacks.");
    }

    public void SayName(string commanderRank)
    {
        switch (commanderRank.ToLower())
        {
            case "general":
                Console.WriteLine(SolderName);
                break;
            case "colonel":
                Console.WriteLine(CodeName);
                break;
            default:
                Console.WriteLine("not authorized");
                break;
        }
    }
    
}