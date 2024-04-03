using GestioneFerramenta.Models;
using GestioneFerramenta.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GestioneFerramenta.Controllers
{

    [ApiController]
    [Route("api/ferramenta")]
    public class FerramentaController : Controller     //https://localhost:7071/api/ferramenta
    {
        [HttpGet]
        public IActionResult ElencoFerramenta()
        {
            return Ok(FerraRepo.getIstance().GetAll());
        }

        [HttpGet("{valoreCodice}")]
        public IActionResult DettaglioFerramenta(string valoreCodice)
        {
            Ferramentum? fer = FerraRepo.getIstance().GetByCodice(valoreCodice);
            if (fer is not null)
                return Ok(fer);
            return NotFound();

        }

        [HttpPost]
        public IActionResult InserisciFerramenta(Ferramentum objFer)
        {
            if (FerraRepo.getIstance().insert(objFer))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("{varId}")]                           
        private IActionResult EliminaFerramenta(int varId)
        {
            if (FerraRepo.getIstance().delete(varId))
                return Ok();

            return BadRequest();
        }

        [HttpDelete("codice/{valoreCodice}"), HttpPost("codice/{valoreCodice}")]
        public IActionResult EliminaFerramentaPerCodice (string valoreCodice)
        {
            Ferramentum? fer = FerraRepo.getIstance().GetByCodice(valoreCodice);
            if (fer is null)
                return BadRequest();

            return EliminaFerramenta(fer.FerramentaId);
        }

        [HttpPut]
        public IActionResult ModificaFerramenta(Ferramentum objFer)
        {
            if (FerraRepo.getIstance().update(objFer))
                return Ok();

            return BadRequest();
        }
    }
 }
