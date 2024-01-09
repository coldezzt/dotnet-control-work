using Models.Creatures;

namespace BLDB.Services;

public class DatabaseMonsterGetter : IMonsterGetter
{
    private readonly AppDbContext _db;
    
    public DatabaseMonsterGetter(AppDbContext appDbContext)
    {
        _db = appDbContext;
    }
    
    public Monster Get()
    {
        var count = _db.Monsters.Count();
        var index = new Random().Next(count - 1);
        var monster = _db.Monsters.ElementAt(index);
        return monster;
    }
}