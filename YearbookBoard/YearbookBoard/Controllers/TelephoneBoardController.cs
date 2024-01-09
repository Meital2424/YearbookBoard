using YearbookBoard.Core.Entities;
using YearbookBoard.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace YearbookBoard.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelephoneBoardController : ControllerBase
    {

        private readonly ITelephoneBoardServices _telephoneBoard;

        //public int NumClass { get; private set; }

        public TelephoneBoardController(ITelephoneBoardServices telephoneBoard)
        {
            _telephoneBoard = telephoneBoard;
        }
        // GET: api/<TelephoneBoardController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_telephoneBoard.GetAllTelephoneBoard());
        }

        // GET api/<TelephoneBoardController>/5
        [HttpGet("{id}")]
        public TelephoneBoard Get(int id)
        {
            return _telephoneBoard.GetTelephoneBoard(id);
            //var telephone = _context.yearbookBoards.Find(t => t.NumClass == id);
            //if (telephone == null)
            //    return NotFound();
            //return Ok(telephone);
        }

        // POST api/<TelephoneBoardController>
        [HttpPost]
        public ActionResult Post([FromBody] TelephoneBoard t)
        {
            return Ok( _telephoneBoard.AddTelephneBoard(t));
            //_context.AddOne();
            //_context.yearbookBoards.Add(new TelephoneBoard
            //{
            //    Name = t.Name,
            //    FamilyN=t.FamilyN,
            //    AdditionalTelephone=t.AdditionalTelephone,
            //   TelephoneNumber=t.TelephoneNumber 
            //});
        }

        // PUT api/<TelephoneBoardController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TelephoneBoard t)
        {
            return Ok( _telephoneBoard.PutTelephneBoard(id, t));
            //var telephone = _context.yearbookBoards.Find(t => t.NumClass == id);
            //if (telephone == null)
            //    return NotFound();
            //telephone.Name = t.Name;
            //telephone.FamilyN = t.FamilyN;
            //telephone.AdditionalTelephone = t.AdditionalTelephone;
            //telephone.TelephoneNumber = t.TelephoneNumber;
            
            //return Ok(telephone);
        }

        // DELETE api/<TelephoneBoardController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _telephoneBoard.RemoveTelephoneBoard(Get(id));
            //var telephone = _context.yearbookBoards.Find(t => t.NumClass == id);
            //if (telephone == null)
            //    return NotFound();
            //_context.yearbookBoards.Remove(telephone);
            //return Ok();
        }
    }
}
