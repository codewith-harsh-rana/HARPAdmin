using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class ShippedDetail:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int ShippedDetailId { get; set;}

        public int ShippedId { get; set;}

        public int OrderId { get; set;}

        public int OrderDetailId { get; set;}

        public int OrderReceivedDetailId { get; set;}

        public int WUPreTestId { get; set;}
    }
}
