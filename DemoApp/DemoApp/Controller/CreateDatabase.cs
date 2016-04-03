using DemoApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoApp.Utility;
using System.Data.SQLite;

namespace DemoApp.Controller
{
    public class CreateDatabase
    {
        private ProductsTable _ProductsTable = ProductsTable.getInstance();
        private StaffsTable _StaffsTable = StaffsTable.getInstance();

        private SQLiteConnection conn = null;

        private static CreateDatabase INSTANCE = null;
        public static CreateDatabase getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new CreateDatabase();
            }
            return INSTANCE;
        }

        public void ToCreateDatabase()
        {

            if (!File.Exists(Constants.Database_Path))
            {
                try
                {
                    Directory.CreateDirectory(Constants.Database_Directory);
                    SQLiteConnection.CreateFile(Constants.Database_Path);
                    conn = new SQLiteConnection("Data Source=" + Constants.Database_Path + ";");
                    conn.Open();

                    ToCreateProductsTable();
                    ToCreateStaffsTable();

                    conn.Close();
                }
                catch (Exception ex)
                {
                    //Directory.Delete(Database_Path); not sure to Remove All Path Folder or Single Folder
                    Globalfuntions.Log(ex.Message);
                }

            }
            else
            {
                Globalfuntions.Log("File Exist");
            }
            
        }

        public void ToCreateProductsTable()
        {
            SQLiteCommand CreateProductsTable_Command = new SQLiteCommand(_ProductsTable.CreateProductsTableString, conn);
            CreateProductsTable_Command.ExecuteNonQuery();

        }

        public void ToCreateStaffsTable()
        {
            SQLiteCommand CreateStaffsTable_Command = new SQLiteCommand(_StaffsTable.CreateStaffsTableString, conn);
            CreateStaffsTable_Command.ExecuteNonQuery();
        }
    }
}
