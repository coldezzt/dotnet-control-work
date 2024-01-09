using Models.Creatures;

namespace Models.Battle;

public class Attack
{
    public ICreature From { get; set; }
    public ICreature To { get; set; }
    public int Value { get; set; }

    public Attack(ICreature from, ICreature to, int value)
    {
        From = from;
        To = to;
        Value = value;
    }
}