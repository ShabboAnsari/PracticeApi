using System;
using System.ComponentModel.DataAnnotations;

namespace PracticeApi.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            CreatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }

        public DateTime DeletedOn { get; set; }

        [StringLength(60)]
        public string CreatedBy { get; set; }

        [StringLength(60)]
        public string UpdatedBy { get; set; }

        [StringLength(60)]
        public string DeletedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}