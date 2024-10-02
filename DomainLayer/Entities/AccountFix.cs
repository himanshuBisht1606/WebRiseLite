using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Entities
{

    /// <summary>
    /// The account fix.
    /// </summary>
    [Table("ACCOUNTFIX", Schema = "SYSADM")]
    public class AccountFix
    {
        /// <summary>
        /// Gets or sets the cap brok.
        /// </summary>
        [Column("CAPBROK")]
        [MaxLength(1)]
        public string CapBrok { get; set; }

        /// <summary>
        /// Gets or sets the cap brok upto dec.
        /// </summary>
        [Column("CAPBROKUPTODEC")]
        public int? CapBrokUptoDec { get; set; }

        /// <summary>
        /// Gets or sets the cap stax.
        /// </summary>
        [Column("CAPSTAX")]
        [MaxLength(1)]
        public string CapStax { get; set; }

        /// <summary>
        /// Gets or sets the cap stt.
        /// </summary>
        [Column("CAPSTT")]
        [MaxLength(1)]
        public string CapStt { get; set; }

        /// <summary>
        /// Gets or sets the cap cont.
        /// </summary>
        [Column("CAPCONT")]
        [MaxLength(1)]
        public string CapCont { get; set; }

        /// <summary>
        /// Gets or sets the cap stamp.
        /// </summary>
        [Column("CAPSTAMP")]
        [MaxLength(1)]
        public string CapStamp { get; set; }

        /// <summary>
        /// Gets or sets the cap demat.
        /// </summary>
        [Column("CAPDEMAT")]
        [MaxLength(1)]
        public string CapDemat { get; set; }

        /// <summary>
        /// Gets or sets the cap turn tax.
        /// </summary>
        [Column("CAPTURNTAX")]
        [MaxLength(1)]
        public string CapTurnTax { get; set; }

        /// <summary>
        /// Gets or sets the fo brok.
        /// </summary>
        [Column("FOBROK")]
        [MaxLength(1)]
        public string FoBrok { get; set; }

        /// <summary>
        /// Gets or sets the fo brok upto dec.
        /// </summary>
        [Column("FOBROKUPTODEC")]
        public int? FoBrokUptoDec { get; set; }

        /// <summary>
        /// Gets or sets the fo stax.
        /// </summary>
        [Column("FOSTAX")]
        [MaxLength(1)]
        public string FoStax { get; set; }

        /// <summary>
        /// Gets or sets the fo stt.
        /// </summary>
        [Column("FOSTT")]
        [MaxLength(1)]
        public string FoStt { get; set; }

        /// <summary>
        /// Gets or sets the fo cont.
        /// </summary>
        [Column("FOCONT")]
        [MaxLength(1)]
        public string FoCont { get; set; }

        /// <summary>
        /// Gets or sets the fo stamp.
        /// </summary>
        [Column("FOSTAMP")]
        [MaxLength(1)]
        public string FoStamp { get; set; }

        /// <summary>
        /// Gets or sets the fo turn tax.
        /// </summary>
        [Column("FOTURNTAX")]
        [MaxLength(1)]
        public string FoTurnTax { get; set; }

        /// <summary>
        /// Gets or sets the margin applied.
        /// </summary>
        [Column("MARGINAPPLIED")]
        [MaxLength(1)]
        public string MarginApplied { get; set; }

        /// <summary>
        /// Gets or sets the poa flag.
        /// </summary>
        [Column("POAFLAG")]
        [MaxLength(1)]
        public string PoaFlag { get; set; }

        /// <summary>
        /// Gets or sets the cap tax1.
        /// </summary>
        [Column("CAP_TAX1", TypeName = "varchar2(1)")]
        public string CapTax1 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the cap tax2.
        /// </summary>
        [Column("CAP_TAX2", TypeName = "varchar2(1)")]
        public string CapTax2 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo tax1.
        /// </summary>
        [Column("FO_TAX1", TypeName = "varchar2(1)")]
        public string FoTax1 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo tax2.
        /// </summary>
        [Column("FO_TAX2", TypeName = "varchar2(1)")]
        public string FoTax2 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the rs tax capnsetax.
        /// </summary>
        [Column("RSTAX_CAPNSETAX")]
        [MaxLength(1)]
        public string RsTaxCapnsetax { get; set; }

        /// <summary>
        /// Gets or sets the rs tax fonsetax.
        /// </summary>
        [Column("RSTAX_FONSETAX")]
        [MaxLength(1)]
        public string RsTaxFonsetax { get; set; }

        /// <summary>
        /// Gets or sets the stax cap stamp.
        /// </summary>
        [Column("STAX_CAPSTAMP")]
        [MaxLength(1)]
        public string StaxCapStamp { get; set; }

        /// <summary>
        /// Gets or sets the min delv brok.
        /// </summary>
        [Column("MINDELVBROK", TypeName = "varchar2(1)")]
        public string MinDelvBrok { get; set; } = "N";

        /// <summary>
        /// Gets or sets the cap tot min brok.
        /// </summary>
        [Column("CAPTOTMINBROK", TypeName = "varchar2(1)")]
        public string CapTotMinBrok { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo tot min brok.
        /// </summary>
        [Column("FOTOTMINBROK", TypeName = "varchar2(1)")]
        public string FoTotMinBrok { get; set; } = "N";

        /// <summary>
        /// Gets or sets the stax fo stamp.
        /// </summary>
        [Column("STAX_FOSTAMP")]
        [MaxLength(1)]
        public string StaxFoStamp { get; set; }

        /// <summary>
        /// Gets or sets the active flag.
        /// </summary>
        [Column("ACTIVEFLAG", TypeName = "varchar2(5)")]
        public string ActiveFlag { get; set; } = "111";

        /// <summary>
        /// Gets or sets the pen required.
        /// </summary>
        [Column("PENREQUIRED", TypeName = "varchar2(3)")]
        public string PenRequired { get; set; } = "N";

        /// <summary>
        /// Gets or sets the cap tax3.
        /// </summary>
        [Column("CAP_TAX3", TypeName = "varchar2(1)")]
        public string CapTax3 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo stax tax1.
        /// </summary>
        [Column("FO_STAX_TAX1", TypeName = "varchar2(1)")]
        public string FoStaxTax1 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo stax tax2.
        /// </summary>
        [Column("FO_STAX_TAX2", TypeName = "varchar2(1)")]
        public string FoStaxTax2 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the fo tax3.
        /// </summary>
        [Column("FO_TAX3", TypeName = "varchar2(1)")]
        public string FoTax3 { get; set; } = "N";

        /// <summary>
        /// Gets or sets the stk var per.
        /// </summary>
        [Column("STKVARPER")]
        public decimal? StkVarPer { get; set; }

        /// <summary>
        /// Gets or sets the poa fund.
        /// </summary>
        [Column("POA_FUND")]
        [MaxLength(1)]
        public string PoaFund { get; set; }

        /// <summary>
        /// Gets or sets the call trade chrg.
        /// </summary>
        [Column("CALL_TRADE_CHRG")]
        [MaxLength(1)]
        public string CallTradeChrg { get; set; }
    }
}

