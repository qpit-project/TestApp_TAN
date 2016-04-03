using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Model
{
    public class ProductsModel
    {
        private string products_id { get; set; }
        private string products_name { get; set; }
        private int products_balance { get; set; }
        private int products_arrive_count { get; set; }
        private int products_depart_count { get; set; }
        private DateTime products_arrive_date { get; set; }
        private DateTime products_depart_date { get; set; }
        private string products_type { get; set; }
        private string products_vender_name { get; set; }

    }
}
