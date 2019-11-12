using System.ComponentModel.DataAnnotations;

namespace PracticeApi.ViewModels
{
    public class CategoryResource
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]

        public string Name { get; set; }
    }
}