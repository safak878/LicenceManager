using LicenceManager.LicenceInformations.Enums;
using LicenceManager.LicenceInformations.Tables;
using LicenceManager.LicenceInformations.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenceManager.Client
{
    public partial class Form1 : Form
    {
        LicenceConfirmation confirm = new LicenceConfirmation();
            public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirm.ModuleConfirm(ModuleTypeEnum.Stok))
            {
                MessageBox.Show("Modül Kullanılabilir");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (confirm.ModuleConfirm(ModuleTypeEnum.Cari))
            {
                MessageBox.Show("Modül Kullanılabilir");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (confirm.ModuleConfirm(ModuleTypeEnum.Fatura))
            {
                MessageBox.Show("Modül Kullanılabilir");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (confirm.ModuleConfirm(ModuleTypeEnum.İrsaliye))
            {
                MessageBox.Show("Modül Kullanılabilir");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (confirm.ModuleConfirm(ModuleTypeEnum.Kasa))
            {
                MessageBox.Show("Modül Kullanılabilir");
            }
            else
            {
                MessageBox.Show("Modül Kullanılamaz");
            }

        }
    }
}
