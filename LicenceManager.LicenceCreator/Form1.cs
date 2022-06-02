using LicenceManager.LicenceInformations.Enums;
using LicenceManager.LicenceInformations.Tables;
using LicenceManager.LicenceInformations.Tools;
using LicenceManager.SystemInformations.Tables;
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

namespace LicenceManager.LicenceCreator
{
    public partial class TxtUserName : Form
    {
        public TxtUserName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LicenceManager.LicenceInformations.Tables.Licence lisans = new LicenceInformations.Tables.Licence();
            SystemInformations.Manager.SystemInformations info = new SystemInformations.Manager.SystemInformations();
            DiskDrive drive = info.GetDiskList().FirstOrDefault(c => c.PartitionName == Application.StartupPath.Substring(0,2));
            lisans.Id = Guid.NewGuid();
            lisans.UserName = TxtUsernamee.Text;
            lisans.Company = TxtCompany.Text;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {

                if (checkedListBox1.GetItemChecked(i))
                {

                    lisans.Modules.Add(new Module
                    {

                        ModuleTypeEnum = (ModuleTypeEnum) i
                    });





                }
            }

            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.BaseBoard,
                Info =JsonConvert.SerializeObject(info.GetBaseBoardInfo()) 
            });



            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Bios,
                Info = JsonConvert.SerializeObject(info.GetBaseBoardInfo())
            });



            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Cpu,
                Info = JsonConvert.SerializeObject(info.GetCpuInfo())
            });


            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Network,
                Info = JsonConvert.SerializeObject(info.GetNetworkList().FirstOrDefault())
            });


            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.DiskDrive,
                Info = JsonConvert.SerializeObject(drive)
            });

            lisans.SystemInfos.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.OperatingSystem,
                Info = JsonConvert.SerializeObject(info.GetOsInfo())
            });

            var json =JsonConvert.SerializeObject(lisans);

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName,EncrpytionTool.Encrypt(json));
            }
        }

      
    }
}
