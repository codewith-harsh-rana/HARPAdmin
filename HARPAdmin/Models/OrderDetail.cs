using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class OrderDetail : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int OrderDetailId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
    }
}
