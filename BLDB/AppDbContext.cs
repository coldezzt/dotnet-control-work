using Microsoft.EntityFrameworkCore;
using Models.Creatures;

namespace BLDB;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Monster> Monsters { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var planetar = new Monster
        {
            Id = -1,
            Name = "Planetar",
            HitPoints = 200,
            AttackModifier = 5,
            AttackPerRound = 2,
            Damage = "4d6",
            DamageModifier = 7,
            ArmorClass = 19
        };
        var relentlessJuggernaut = new Monster
        {
            Id = -2,
            Name = "Relentless juggernaut",
            HitPoints = 160,
            AttackModifier = 4,
            AttackPerRound = 3,
            Damage = "1d10",
            DamageModifier = 6,
            ArmorClass = 17
        };
        var cloudGiant = new Monster
        {
            Id = -3,
            Name = "Cloud giant",
            HitPoints = 200,
            AttackModifier = 4,
            AttackPerRound = 1,
            Damage = "3d8",
            DamageModifier = 8,
            ArmorClass = 14
        };

        modelBuilder.Entity<Monster>().HasData(planetar, relentlessJuggernaut, cloudGiant);
    }
}