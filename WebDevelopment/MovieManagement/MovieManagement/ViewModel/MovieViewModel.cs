using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
namespace MovieManagement.ViewModel
{
    public class MovieViewModel
    {

        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Name must be of at least 3 chars")]
        public string Name { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public string Code { get; set; } = String.Empty;

        public string? GenreName { get; set; } = String.Empty;
        public int? GenreId { get; set; }


        public List<SelectListItem>? Genres { get; set; }


        [Required]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Required]

        public float LengthInMin { get; set; }

        public IFormFile? Banner { get; set; }
        public string? BannerDataUrl { get; set; } = string.Empty;
        public List<String> PagingUrls { get; set; } = new List<string>();
    }
}