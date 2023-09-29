using cognisseum.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace webapi.Controllers
{
    [Route("/api/stoichiometry")]
    public class StoichiometryController : Controller
    {

        public StoichiometryController(StoichiometryService srvc)
        {
            Srvc = srvc;
        }

        [HttpGet("molar-mass")]
        public ActionResult<float?> GetMolecularMass([Required] string smiles)
            => Ok(Srvc.MolecularMass(smiles));

        public StoichiometryService Srvc { get; set; }
    }
}
