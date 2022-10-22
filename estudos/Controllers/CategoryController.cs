using estudos.Models;
using Microsoft.AspNetCore.Mvc;

namespace estudos.Controllers
{
    public  class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return new List<Category>();
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Post([FromBody] Category category)
        {
            return Ok(category);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            return new Category();
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Put(int id, [FromBody] Category category)
        {
            if(category.Id == id)
                return Ok(category);

            return NotFound();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Category>>> Delete(int id)
        {
            return Ok();
        }
    }
}
