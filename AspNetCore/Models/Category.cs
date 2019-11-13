using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticeApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public IList<Products> Products { get; set; } = new List<Products>();
    }
}