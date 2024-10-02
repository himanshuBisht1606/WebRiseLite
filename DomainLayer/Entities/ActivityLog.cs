using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    /// <summary>
    /// The activity log.
    /// </summary>
    [Table("ACTIVITY_LOG", Schema = "SYSADM")]
    public class ActivityLog
    {
        /// <summary>
        /// Gets or sets the exchange.
        /// </summary>
        [Column("EXCHANGE")]
        [MaxLength(10)]
        public string Exchange { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        [Column("CODE")]
        [MaxLength(10)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [Column("STATUS")]
        [MaxLength(10)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the chng date.
        /// </summary>
        [Column("CHNGDATE")]
        public DateTime? ChngDate { get; set; }

        /// <summary>
        /// Gets or sets the chng time.
        /// </summary>
        [Column("CHNGTIME")]
        [MaxLength(15)]
        public string ChngTime { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        [Column("USERID")]
        [MaxLength(15)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the machine ip.
        /// </summary>
        [Column("MACHINEIP")]
        [MaxLength(20)]
        public string MachineIp { get; set; }

        /// <summary>
        /// Gets or sets the remark.
        /// </summary>
        [Column("REMARK")]
        [MaxLength(25)]
        public string Remark { get; set; }

        /// <summary>
        /// Gets or sets the date from.
        /// </summary>
        [Column("DATEFROM")]
        [MaxLength(10)]
        public string DateFrom { get; set; }

        /// <summary>
        /// Gets or sets the date converts to.
        /// </summary>
        [Column("DATETO")]
        [MaxLength(10)]
        public string DateTo { get; set; }

        /// <summary>
        /// Gets or sets the sett no.
        /// </summary>
        [Column("SETTNO")]
        [MaxLength(10)]
        public string SettNo { get; set; }
    }
}
