using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    /// <summary>
    /// The ac group.
    /// </summary>
    [Table("ACGROUP", Schema = "SYSADM")]
    public class AcGroup
    {
        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        [Key]
        [Column("GROUPID")]
        [MaxLength(40)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the client cd.
        /// </summary>
        [Column("CLIENTCD")]
        [MaxLength(10)]
        public string ClientCd { get; set; }
    }
}
