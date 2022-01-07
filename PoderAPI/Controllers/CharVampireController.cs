using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoderAPI.Data.Interfaces;
using PoderAPI.Model;
using PoderAPI.Model.InputModels;
using System.Collections.Generic;

namespace PoderAPI.Controllers
{
    public class CharVampireController : Controller
    {
        private ICharVampireRepository _charVampireRepository;

        public CharVampireController(ICharVampireRepository charVampireRepository)
        {
            _charVampireRepository = charVampireRepository;
        }


        //GET: api/<CharVampireController>
        [HttpGet("api/CharVampireController")]
        public IActionResult Get()
        {
            var vampires = _charVampireRepository.GetCharVampire();
            return Ok(vampires);
        }

        // GET: api/<CharVampireController>/5
        [HttpGet("api/CharVampireController/{id}")]
        public ActionResult Get(string id)
        {
            var vampire = _charVampireRepository.GetCharVampireByID(id);
            if (vampire == null) return NotFound();
            return Ok(vampire);
        }

        // POST: api/<CharVampireController>
        [HttpPost("api/CharVampireController")]
        public IActionResult Post([FromBody] CharVampireInputModel newVampire )
        {
            var vampire = new CharVampire(newVampire.Clan, newVampire.Generation, newVampire.Filiation,
                newVampire.Name, newVampire.Player, newVampire.Resume, newVampire.SymbolLink,
                newVampire.ImgLink);

            try
            {
                _charVampireRepository.AddCharVampire(vampire);
                return Created("", newVampire);
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT: api/<CharVampireController>/5
        [HttpPut("api/CharVampireController/{id}")]
        public IActionResult Put(string id, [FromBody] CharVampireInputModel updateVampire)
        {
            var vampire = _charVampireRepository.GetCharVampireByID(id);

            if (vampire == null) return NotFound();

            try
            {
                vampire.UpdatingCharVampire(updateVampire.Clan, updateVampire.Name, updateVampire.Player, 
                updateVampire.Resume, updateVampire.SymbolLink, updateVampire.ImgLink,updateVampire.Filiation, 
                updateVampire.Generation);

                _charVampireRepository.UpdateCharVampire(id, vampire);

                return Ok(vampire);
            }
            catch
            {
                return BadRequest();
            }

        }



        // GET: CharVampireController/Delete/5
        public IActionResult Delete(string id)
        {
            var vampire = _charVampireRepository.GetCharVampireByID(id);

            if (vampire == null) return NotFound();

            _charVampireRepository.DeleteCharVampire(vampire.Id);

            return NoContent();
        }


    }
}
