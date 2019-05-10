using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderWebAPI.Models;

namespace OrderWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Models.Context ctx;
        public ValuesController(Models.Context context)
        {
            this.ctx = context;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Item>> GetAll()
        {
            return ctx.Items.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            var item = ctx.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Item> PostNew(long id,Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            ctx.Items.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }
 

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<Item> Put_Modify(long id)
        {
            var item = ctx.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            ctx.Items.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<Item> Delete(long id)
        {
            var item = ctx.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            ctx.Items.Remove(item);
            ctx.SaveChanges();
            return NoContent();
        }
    }
}
