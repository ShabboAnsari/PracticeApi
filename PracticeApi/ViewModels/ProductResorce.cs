using PracticeApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PracticeApi.ViewModels
{
    public class ProductResorce
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public short QuantityInPackage { get; set; }

        public UnitOfMeasurement Type { get; set; }
    }
}