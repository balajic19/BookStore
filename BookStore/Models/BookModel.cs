using BookStore.Helper;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BookStore.Models
{
    public class BookModel
    {
        public string MyField { get; set; }
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage = "Please Enter the title of your book")]
        public string Title { get; set; }

        [StringLength(500)]
        [Required(ErrorMessage = "Please enter the author name")]
        public string Author { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public string Category { get; set; }
        public int LanguageId { get; set; }
        public string Language { get; set; }

        [Required(ErrorMessage = "Please enter the total pages")]
        [Display(Name = "Total Pages of the Book")]
        public int? TotalPages { get; set; }

        [Display(Name = "Please choose the cover pic")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the gallery images of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }
        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload your book in pdf format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }
    }
}
