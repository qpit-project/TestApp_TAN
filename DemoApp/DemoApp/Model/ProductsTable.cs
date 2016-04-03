using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Generic;
using System.Data.SQLite.Linq;

namespace DemoApp.Model
{

    public class ProductsTable
    {

        private static ProductsTable INSTANCE = null;
        public static ProductsTable getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ProductsTable();
            }
            return INSTANCE;
        }

        public string CreateProductsTableString = @"CREATE TABLE Products (
                                                    products_id varchar(6) NOT NULL,
                                                    products_name varchar(20) NOT NULL,
                                                    products_balance int(5) NOT NULL,
                                                    products_arrive_count int(5) NOT NULL,
                                                    products_depart_count int(5) NOT NULL,
                                                    products_arrive_date date NOT NULL,
                                                    products_depart_date date NOT NULL,
                                                    products_type varchar(6) NOT NULL,
                                                    products_vender_name varchar(20) NOT NULL,
                                                    PRIMARY KEY (`products_id`)
                                                    )";

    }
}
