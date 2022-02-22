using Microsoft.AspNetCore.Mvc;
using GlassesApi.Models;

namespace GlassesApi.Controllers;

[ApiController]
[Route("/api/[controller]")]

    public class GlassesController : ControllerBase
    {

private static List<Glasses> GlassesList = new List<Glasses>();
       // GET /glasses
  [HttpGet]
public ActionResult<List<Glasses>> Get()
    {
        return GlassesList;
    }

[HttpPost]
public IActionResult Post(Glasses newGlasses)
{            
// newGlasses =req.body
    GlassesList.Add(newGlasses);

    return CreatedAtAction(nameof(Post), new { id = 7 }, newGlasses);
}



    }
    
