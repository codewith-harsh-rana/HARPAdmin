using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class OrderReceivedDetail:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int OrderReceivedDetailId { get; set; }

        public int OrderId { get; set; }

        public int OrderDetailId { get; set; }

        public string SerialNumber { get; set; }

        public int? PSUOrderRepairResultId { get; set; }

        public string? PSUOrderRepairResultNotes { get; set; }

        public int? PSUOrderRepairResultCreatedBy { get; set; }

        public DateTime? PSUOrderRepairResultCreatedDate { get; set; }

        public int? PSUOrderInventoryProductId { get; set; }

        public int? PSUOrderInventoryProductQty { get; set; }
        
        public int?  PSUProductStatusId { get; set; }

        public int? NewSerialNumber { get; set; }
    }
}
