using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models.Creatures;
using Models.Dtos;

namespace UI.Pages;

public class Game : PageModel
{
    private const string BlDbUrl = "http://localhost:5000/fight/result";
    [BindProperty] public Player Player { get; set; } = new();
    public Monster Monster { get; set; }
    public OutcomeDto? Outcome;
    
    public void OnGet() { }

    public async Task OnPostAsync()
    {
        if (!ModelState.IsValid) return;
        var client = new HttpClient();
        var response = await client.PostAsJsonAsync(BlDbUrl, Player);
        Outcome = await response.Content.ReadFromJsonAsync<OutcomeDto>();
        Monster = Outcome.Monster;
    }
}