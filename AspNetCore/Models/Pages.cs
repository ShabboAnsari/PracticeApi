using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeApi.Models
{
    public class Pages
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Text { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
