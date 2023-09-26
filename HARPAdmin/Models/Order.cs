using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class Order:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }

        public string? WarrantyTicketNo { get; set; }

        public int OrderType { get; set; }

        public int BINNumber { get; set; }

        public int IsApplyWTN { get; set; }
    }
}
