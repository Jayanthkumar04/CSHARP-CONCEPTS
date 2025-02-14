using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Product
    {
        public int PId { get; set; }

        public string PName { get; set; }

        public double PPrice { get; set; }

        public DateTime MfgDate { get; set; }

        public static double GST { get; set; }

    }
}
