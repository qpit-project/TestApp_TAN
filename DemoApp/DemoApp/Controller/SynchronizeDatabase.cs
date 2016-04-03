using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Controller
{
    class SynchronizeDatabase
    {
        //using (var cmd = new SQLiteCommand(conn))
        //{
        //    using (var transaction = conn.BeginTransaction())
        //    {
        //        for (int y = 0; y < castarraylist.Count; y++)
        //        {
        //            //Add your query here.
        //            cmd.CommandText = "INSERT INTO TABLE (Field1,Field2) VALUES ('A', 'B');";
        //            cmd.ExecuteNonQuery();
        //        }
        //        transaction.Commit();
        //    }
        //}

        private void Transaction()
        {
            //using (var tra = cn.BeginTransaction())
            //{
            //    try
            //    {
            //        foreach (var myQuery in myQueries)
            //        {
            //            using (var cd = new SQLiteCommand(myQuery, cn, tra))
            //            {
            //                cd.ExecuteNonQuery();
            //            }
            //        }

            //        tra.Commit();
            //    }
            //    catch (Exception ex)
            //    {
            //        tra.Rollback();
            //        Console.Error.Writeline("I did nothing, because something wrong happened: {0}", ex);
            //        throw;
            //    }
            //}
        }

    }
}
