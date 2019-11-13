using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeApi.ViewModels
{
    public class BlogResource
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; }

   
        [Required]
        [StringLength(1040)]
        public string Text { get; set; }

        public string Image { get; set; }

        public bool IsFeatured { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; }

    }
}