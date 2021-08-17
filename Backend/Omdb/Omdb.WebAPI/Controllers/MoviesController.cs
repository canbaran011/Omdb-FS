using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omdb.BL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Omdb.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public IActionResult SearchMovie(string searchString) 
        {
            MovieManager movieManager = new MovieManager();
            var result = movieManager.SearchMovies(searchString);
            return default;
        }

    }
}
