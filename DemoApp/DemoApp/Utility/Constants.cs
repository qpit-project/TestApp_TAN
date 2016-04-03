using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp.Utility
{
    public class Constants
    {
        public static readonly string Database_Name = "DemoAppDatabase.sqlite";
        public static readonly string Current_Path = Path.GetDirectoryName(Application.ExecutablePath);
        public static readonly string Database_Directory = Current_Path + @"\DatabaseFile";
        public static readonly string Database_Path = Path.Combine(Database_Directory, Database_Name);
    }
}
