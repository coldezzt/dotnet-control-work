using BLDB.Services;
using Microsoft.AspNetCore.Mvc;
using Models.Creatures;

namespace BLDB.Controllers;

[Route("[controller]")]
public class MonsterController : Controller
{
    private readonly IMonsterGetter _monsterGetter;

    public MonsterController(IMonsterGetter monsterGetter)
    {
        _monsterGetter = monsterGetter;
    }
    
    [HttpGet]
    [Route("random")]
    public JsonResult Random()
    {
        var monster = _monsterGetter.Get();
        return new JsonResult(monster);
    }
}