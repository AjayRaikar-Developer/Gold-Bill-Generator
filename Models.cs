using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillGenerator
{
    class Models
    {

        public partial class Gold
        {
            public int SlNo { get; set; }
            public decimal PerGramRate { get; set; }
            public string Description { get; set; }
            public decimal GrossWeight { get; set; }
            public decimal LessWeight { get; set; }
            public decimal Purity { get; set; }
            public decimal StoneAmount { get; set; }
        }

        public partial class GoldCalculation
        {
            public int SlNo { get; set; }
            public string TxnDescription { get; set; }
            public string Hsn { get; set; }
            public decimal GrossWeight { get; set; }
            public decimal LessWeight { get; set; }
            public decimal Purity { get; set; }
            public decimal PureWeight { get; set; }
            public decimal Rate { get; set; }
            public decimal StoneAmount { get; set; }
            public decimal TxnAmount { get; set; }
            public decimal ChargeableAmount { get; set; }

        }

        public partial class DocumentSave
        {
            public string ResponseMessage { get; set; }
            public bool TxnStatus { get; set; }
        }

    }
}
