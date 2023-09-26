using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class Product : BaseEntity
      {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public String? ProductName { get; set; }
    }
}
