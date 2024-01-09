using Models.Battle;
using Models.Creatures;
using Models.Dtos;

namespace BLDB.Services;

public class SimpleFighter : IFighter
{
    private Random _rnd { get; set; }
    private List<Log> FightLog { get; set; }
    public ICreature[] Creatures { get; private set; }
    public int MovingIndex { get; private set; }

    public OutcomeDto GetResult(ICreature first, ICreature second)
    {
        _rnd = new Random();
        FightLog = new List<Log>();
        Creatures = new[] {first, second};
        
        while (Creatures[0].HitPoints > 0 && Creatures[1].HitPoints > 0)
        {
            MakeMove();
        }

        return new OutcomeDto
        {
            Logs = FightLog,
            Player = (Player)Creatures[0],
            Monster = (Monster)Creatures[1],
            WinnerLetter = Creatures[0].HitPoints > 0 ? 'P' : 'M'
        };
    }
    
    private void MakeMove()
    {
        var currentMoving = Creatures[MovingIndex];
        var waiting = Creatures[1 - MovingIndex];
        var values = currentMoving.Damage.Split("d").Select(int.Parse).ToList();
        var chance = _rnd.Next(1, 21);
        var log = new Log
        {
            CharacterName = currentMoving.Name,
            EnemyName = waiting.Name,
            AttackModifier = currentMoving.AttackModifier
        };
        switch (chance)
        {
            case 1:
                log.Damage = 0;
                log.EnemyHp = waiting.HitPoints;
                FightLog.Add(log);
                break;
            default:
                var damage = 0;
                for (var i = 0; i < currentMoving.AttackPerRound; i++)
                    damage += _rnd.Next(1, values[1]) + currentMoving.DamageModifier;
                waiting.HitPoints -= damage * (chance == 20 ? 2 : 1);
                log.Damage = damage;
                log.EnemyHp = waiting.HitPoints - damage;
                FightLog.Add(log);
                break;
        }
        MovingIndex = 1 - MovingIndex;
    }
}