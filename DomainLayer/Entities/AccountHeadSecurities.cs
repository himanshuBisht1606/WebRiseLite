using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Entities
{
    /// <summary>
    /// The account head securities.
    /// </summary>
    [Table("ACCOUNT_HEAD_SECURITIES", Schema = "SYSADM")]
    public class AccountHeadSecurities
    {
        /// <summary>
        /// Gets or sets the br code.
        /// </summary>
        [Column("BRCODE")]
        [MaxLength(10)]
        public string BrCode { get; set; }

        /// <summary>
        /// Gets or sets the capital.
        /// </summary>
        [Column("CAPITAL", TypeName = "varchar2(1)")]
        public string Capital { get; set; } = "N";

        /// <summary>
        /// Gets or sets the current assets.
        /// </summary>
        [Column("CURRENT_ASSETS", TypeName = "varchar2(1)")]
        public string CurrentAssets { get; set; } = "N";

        /// <summary>
        /// Gets or sets the current liabilities.
        /// </summary>
        [Column("CURRENT_LIABILITIES", TypeName = "varchar2(1)")]
        public string CurrentLiabilities { get; set; } = "N";

        /// <summary>
        /// Gets or sets the expenditure.
        /// </summary>
        [Column("EXPENDITURE", TypeName = "varchar2(1)")]
        public string Expenditure { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fixed assets.
        /// </summary>
        [Column("FIXED_ASSETS", TypeName = "varchar2(1)")]
        public string FixedAssets { get; set; } = "N";

        /// <summary>
        /// Gets or sets the loan advances.
        /// </summary>
        [Column("LOAN_ADVANCES", TypeName = "varchar2(1)")]
        public string LoanAdvances { get; set; } = "N";

        /// <summary>
        /// Gets or sets the loans.
        /// </summary>
        [Column("LOANS", TypeName = "varchar2(1)")]
        public string Loans { get; set; } = "N";

        /// <summary>
        /// Gets or sets the miscellaneous exp asset.
        /// </summary>
        [Column("MISCELLANEOUS_EXP_ASSET", TypeName = "varchar2(1)")]
        public string MiscellaneousExpAsset { get; set; } = "N";

        /// <summary>
        /// Gets or sets the reserve surplus.
        /// </summary>
        [Column("RESERVE_SURPLUS", TypeName = "varchar2(1)")]
        public string ReserveSurplus { get; set; } = "N";

        /// <summary>
        /// Gets or sets the revenue.
        /// </summary>
        [Column("REVENUE", TypeName = "varchar2(1)")]
        public string Revenue { get; set; } = "N";

        /// <summary>
        /// Gets or sets the sundry debtors creditors.
        /// </summary>
        [Column("SUNDRY_DEBTORS_CREDITORS", TypeName = "varchar2(1)")]
        public string SundryDebtorsCreditors { get; set; } = "N";
    }
}

