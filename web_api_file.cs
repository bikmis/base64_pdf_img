using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpamleWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        [Route("{dealId}")]
        [HttpGet]
        public List<Image> GetImages(int dealId)
        {
            List<Image> images = new List<Image>();

            var pathName = "C:\\Users\\MishraB\\source\\repos\\ExpamleWebApplication\\ExpamleWebApplication\\images\\";

            foreach (var fileName in Directory.GetFiles(pathName + dealId))
            {
                var image = System.IO.File.ReadAllBytes(fileName);
                images.Add(new Image()
                {
                    FileName = fileName.Substring((pathName + dealId + "\\").Length),
                    Data = image
                });
            }

            return images;
        }

    }

    public class Image
    {
        public string? FileName { get; set; }
        public byte[]? Data { get; set; }
    }
}
