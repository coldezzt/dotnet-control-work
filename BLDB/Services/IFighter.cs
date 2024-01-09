using Models.Creatures;
using Models.Dtos;

namespace BLDB.Services;

public interface IFighter
{
    public OutcomeDto GetResult(ICreature first, ICreature second);
}