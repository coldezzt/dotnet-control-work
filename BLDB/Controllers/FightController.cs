using BLDB.Services;
using Microsoft.AspNetCore.Mvc;
using Models.Battle;
using Models.Creatures;
using Models.Dtos;

namespace BLDB.Controllers;

[Route("[controller]")]
public class FightController : Controller
{
    public readonly string RndMonsterUrl = "http://localhost:5000/monster/random";
    public IFighter Fighter { get; set; }

    public FightController(IFighter fighter)
    {
        Fighter = fighter;
    }
    
    [HttpPost]
    [Route("result")]
    public async Task<JsonResult> Result([FromBody] Player player)
    {
        var client = new HttpClient();
        var monster = await client.GetFromJsonAsync<Monster>(RndMonsterUrl);
        var outcomeDto = Fighter.GetResult(player, monster);
        return new JsonResult(outcomeDto);
    }
}