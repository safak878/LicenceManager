using LicenceManager.SystemInformations.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LicenceManager.Test
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            
            SystemInformations.Manager.SystemInformations manager = new SystemInformations.Manager.SystemInformations();
            //List<SystemInformations.Tables.OperatingSystem> list = new List<SystemInformations.Tables.OperatingSystem>();
            //list.Add(manager.GetOsInfo());
            gridControl1.DataSource = manager.GetDiskList();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
