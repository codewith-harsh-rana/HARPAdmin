using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class Shipped:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int ShippedId {  get; set; }
        
        public int CustomerId { get; set; }

        public string TrackingNumber { get; set; }

        public string Address {  get; set; }
        
        public string City { get; set; }

        public string State {  get; set; }  

        public string Country { get; set; }

        public int ShipStatusId { get; set; }

        public DateTime TrackingAddedDate { get; set; }

        public int TrackingAddedBy { get; set; }

    }
}
