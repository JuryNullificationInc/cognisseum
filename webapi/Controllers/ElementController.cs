using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using webapi.DTOs;
using webapi.Services;

namespace webapi.Controllers
{
    [Route("api/element")]
    public class ElementController : Controller
    {

        public ElementController(ElementService srvc) => Srvc = srvc;

        [HttpGet("element-by-atomic-number")]
        public ActionResult<ElementDto?> ElementByAtomicNumber([Required] long number)
        {
            return Ok(Srvc.GetElementDtoByAtomicNumber(number));
        }

        private ElementService Srvc { get; set; }
    }
}
