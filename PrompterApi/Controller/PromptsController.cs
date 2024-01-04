using PrompterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace PrompterApi.AddControllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PromptsController: ControllerBase
  {
    private readonly PrompterApiContext _db;
    public PromptsController(PrompterApiContext db)
    {
      _db = db;
    }

    [HttpGet("latest")]
    public async Task<string> Get()
    {
      Prompt prompt = await _db.Prompts.OrderByDescending(p => p.PromptId).FirstOrDefaultAsync();
      string text = prompt.PromptText;
      return text;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Prompt prompt)
    {
      _db.Prompts.Add(prompt);
      await _db.SaveChangesAsync();
      return NoContent();
    }
  }
}