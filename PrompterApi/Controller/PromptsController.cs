using PrompterApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace PrompterApi.AddControllers
{
  [ApiController]
  public class PromptsController: ControllerBase
  {
    private readonly PrompterApiContext _db;
    public PromptsController(PrompterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<string> Get()
    {
      Prompt prompt = await _db.Prompts.OrderByDescending(p => p.PromptId).FirstOrDefaultAsync();
      return prompt.PromptText;
    }

    [HttpPost]
    public async Task<ActionResult> Post(Prompt prompt)
    {
      _db.Prompts.Add(prompt);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(Get), new { id = prompt.PromptId }, prompt);
    }
  }
}