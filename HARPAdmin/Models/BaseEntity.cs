namespace HARPAdmin.Models
{
    public class BaseEntity
    {
        public int  Createdby{ get; set; }

        public DateTime CreateDate { get; set; }

        public int?  UpdatedBy { get; set;}

        public DateTime? UpdateDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
