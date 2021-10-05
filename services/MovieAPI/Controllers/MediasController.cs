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
    public class MediasController : ControllerBase
    {
        private readonly IMediaService _mediaService;

        public MediasController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        // GET: api/Movies
        [HttpGet]
        public async Task<ActionResult> GetMedias([FromQuery] string search, [FromQuery] int num, [FromQuery] int mediaType)
        {
            var response = await _mediaService.GetMedias(search, num, mediaType);
            if (response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
