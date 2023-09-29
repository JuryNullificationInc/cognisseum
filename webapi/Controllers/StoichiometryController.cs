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
        public float GetMolecularMass([Required] string smiles)
        {
            Console.WriteLine("Calling stoich...");
            return Srvc.MolecularMass(smiles);
        }

        public StoichiometryService Srvc { get; set; }
    }
}
