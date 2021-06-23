using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winformmvp.Model
{
public     class Payment
    {
        public int PaymentId { get; set; }

        public string Oil { get; set; }
        public int Liter { get; set; }
        public double TotalPayment { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return $"{Oil}-{Liter}";
        }
    }
}
