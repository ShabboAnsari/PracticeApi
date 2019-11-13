using System.Collections.Generic;

namespace PracticeApi.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public IList<Products> Products { get; set; } = new List<Products>();
    }
}