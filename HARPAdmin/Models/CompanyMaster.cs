using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HARPAdmin.Models
{
    public class CompanyMaster
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]

        public int CompanyId { get; set; }

        public string? CompanyName { get; set; }

        [Required]
        [EmailAddress]
        public string? EmailId { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? City { get; set;}

        public string? State { get; set; }

        public string? Country { get; set; }

        public int ZipCode { get; set;}

        public int ACHRouting { get; set; }

        public int ACHAccount { get; set; }

        public string? ACHBank1 { get; set; }

        public string? ACHBank2 { get; set; }

        public string? ACHBank3 { get;set; }

        public string? ACHCity { get; set; }

        public string? ACHState { get; set; }

        public string? WITo { get; set; }

        public string? WIRouting { get;set; }

        public string? WIAccount { get; set; }

        public string? WIAccountName { get; set; }

        public string? CPOBtc { get; set; }

        public string? CPOEth { get; set; }

        public string? CPOUsdt { get; set; }

        public string? FFCACCOUNT { get; set; }

        public string? FFCACCOUNTNAME { get; set; }

    }
}
