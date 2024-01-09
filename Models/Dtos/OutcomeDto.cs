using Models.Battle;
using Models.Creatures;

namespace Models.Dtos;

public class OutcomeDto
{
    public List<Log> Logs { get; set; }
    public Player Player { get; set; }
    public Monster Monster { get; set; }
    public char WinnerLetter { get; set; }
    
    public OutcomeDto() {}
}