using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoresandTest.Business_Logic;
using MoresandTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoresandTest.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;
        private readonly IImage _image;
        public ImageController(ILogger<ImageController> logger,IImage image)
        {
            _logger = logger;
            _image = image;
        }


        [Route("CreateImages")]
        [HttpPost]
        public IActionResult CreateImages(List<ImageDetails> imageDetails)
        {
            if (imageDetails.Count > 0)
            {
                _image.CreateImages(imageDetails);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


    }
}
