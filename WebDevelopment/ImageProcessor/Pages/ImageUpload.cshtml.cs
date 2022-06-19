using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Drawing;

namespace ImageProcessor.Pages
{
    public class ImageUploadModel : PageModel
    {
        public IFormFile File { get; set; }
        public void OnGet()
        {

        }
        public async Task OnPost()
        {
            await RotateImage();
        }
        public async Task RotateImage()
        {
            //rotate image
            Stream imageStream = new MemoryStream();
            File.CopyTo(imageStream);
            Bitmap bitmap = new(imageStream);

            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);

            var filePath = Path.Combine(Directory.GetCurrentDirectory(), @$"wwwroot\image\{File.FileName}Rotated.jpg");

            bitmap.Save(filePath);
            //bitmap.Save("d:\\image.jpg");
        }
    }
}
