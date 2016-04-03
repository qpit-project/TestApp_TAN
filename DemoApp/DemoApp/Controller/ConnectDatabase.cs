using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoApp.Utility;

namespace DemoApp.Controller
{
    public class ConnectDatabase
    {
        private CreateDatabase _CreateDatabase = CreateDatabase.getInstance();
        private AccessDatabase _AccessDatabase = AccessDatabase.getInstance();

        private SQLiteConnection conn = null;

        private static ConnectDatabase INSTANCE = null;
        public static ConnectDatabase getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ConnectDatabase();
            }
            return INSTANCE;
        }


        public void ToConnectDatabase()
        {
            if (File.Exists(Constants.Database_Path))
            {
                _AccessDatabase.ToAccessDatabase();
            }
            else
            {
                _CreateDatabase.ToCreateDatabase();

                _AccessDatabase.ToAccessDatabase();
            }
        }

    }




}
