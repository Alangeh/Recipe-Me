using Microsoft.AspNetCore.Mvc;
using RecipeBook.ServiceLibrary.Domains;
using RecipeBook.ServiceLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeMe.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet("{recipeId}")]
        public async Task<IActionResult> GetOnceAsync([FromRoute]Guid recipeId)
        {
            return Ok(recipeId);
        }


        [HttpGet] // add recipe
        public async Task<IActionResult> GetListAsync([FromQuery]int pageSize, [FromQuery] int pageNumber)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] RecipeEntity recipe)
        {
            return Ok(recipe);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync([FromBody] RecipeEntity recipe)
        {
            return Ok(recipe);
        }

        [HttpDelete("{recipeId}")]
        public async Task<IActionResult> DeleteAsync(Guid recipeId)
        {
            return Ok(recipeId);
        }
    }
}
