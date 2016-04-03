using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Model
{
    public class StaffsTable
    {
        private static StaffsTable INSTANCE = null;
        public static StaffsTable getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new StaffsTable();
            }
            return INSTANCE;
        }

        public string CreateStaffsTableString = @"CREATE TABLE Staffs (
                                                staff_id varchar(6) NOT NULL,
                                                staff_name varchar(20) NOT NULL,
                                                staff_surname varchar(20) NOT NULL,
                                                staff_priority int(2) NOT NULL,
                                                staff_password varchar(20) NOT NULL,
                                                PRIMARY KEY (`staff_id`)
                                                )";
    }
}
