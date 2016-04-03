using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoApp.Utility;
using System.Data;

namespace DemoApp.Controller
{
    public class AccessDatabase
    {
        private SQLiteConnection conn = null;


        private static AccessDatabase INSTANCE = null;
        public static AccessDatabase getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new AccessDatabase();
            }
            return INSTANCE;
        }

        public void ToAccessDatabase()
        {
            conn = new SQLiteConnection("Data Source=" + Constants.Database_Path + ";");
            conn.Open();
            //Globalfuntions.Log(SELECT());
            //TransactionDatabase();

            string QueryText = @"SELECT * FROM products WHERE products_id = '000001'";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(QueryText, conn);
            DataSet mydataset = new DataSet();
            //adapter.Fill(mydataset, "products");
            conn.Close();
        }

        //private string SELECT()
        //{
        //    //string QueryText = @"SELECT * FROM products WHERE products_id = '000001'";
        //    //SQLiteCommand command = new SQLiteCommand(QueryText, conn);
        //    //SQLiteDataReader reader = command.ExecuteReader();
            
        //    //reader.Read();
        //    //return reader.GetString(0);
        //}

        private void TransactionDatabase()
        {
            using (var cmd = new SQLiteCommand(conn))
            {
                using (var transaction = conn.BeginTransaction())
                {
                    //for (int y = 0; y < castarraylist.Count; y++)
                    //{
                    //    //Add your query here.
                    //    cmd.CommandText = "INSERT INTO TABLE (Field1,Field2) VALUES ('A', 'B');";
                    //    cmd.ExecuteNonQuery();
                    //}
                    transaction.Commit();
                }
            }
        }
    }
}
