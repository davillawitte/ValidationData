using Microsoft.AspNetCore.Mvc;
using ValidationData.Model;

namespace ValidationData.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
   [HttpPost]

   public IActionResult Post(PessoaRequest request)
   {
        return Ok(request);
   }
}
