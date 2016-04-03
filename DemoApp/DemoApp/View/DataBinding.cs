using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoApp.Controller;

namespace DemoApp.View
{
    public partial class DataBinding : Form
    {
        private ConnectDatabase _ConnectDatabase = ConnectDatabase.getInstance();

        public DataBinding()
        {
            InitializeComponent();
            _ConnectDatabase.ToConnectDatabase();

        }
    }
}
