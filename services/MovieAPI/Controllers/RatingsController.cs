using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movieAPI.Data;
using movieAPI.Models;
using MovieAPI.Services;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        // GET: api/Ratings
        [HttpPost]
        public async Task<ActionResult> PostRating([FromQuery] int rating, [FromQuery] int mediaId)
        {
            var response = await _ratingService.PostRating(rating, mediaId);

            if (!response)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
