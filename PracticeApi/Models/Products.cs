using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticeApi.Models
{
    public class Products : BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public short QuantityInPackage { get; set; }

        public UnitOfMeasurement Type { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}