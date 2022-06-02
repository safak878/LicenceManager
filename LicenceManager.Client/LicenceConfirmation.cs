using LicenceManager.LicenceInformations.Enums;
using LicenceManager.LicenceInformations.Tables;
using LicenceManager.LicenceInformations.Tools;
using LicenceManager.SystemInformations.Tables;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace LicenceManager.Client
{
    public class LicenceConfirmation
    {

        private readonly Licence license;
         List<SystemInfo> systemInfo = new List<SystemInfo>();
        private bool confirmLicense = false;
        public LicenceConfirmation()
        {
            if (File.Exists(Application.StartupPath +"\\licence.lic"))
            {
                string json = EncrpytionTool.Decypt(File.ReadAllText(Application.StartupPath + "\\licence.lic"));

                license = JsonConvert.DeserializeObject<Licence>(json);
                LoadSystemInfo();
                int confirmedInfo = 0;
                for (int i = 0; i < 6; i++)
                {
                    var infoType =license.SystemInfos[i].InfoType;
                    if (license.SystemInfos[i].Info == systemInfo.Where(c => c.InfoType == infoType).FirstOrDefault().Info)
                    {
                        confirmedInfo += 1;

                    }
                }
                if (confirmedInfo > 3)
                {
                    confirmLicense = true;
                }
            }

        }
        private void LoadSystemInfo()
        {
            SystemInformations.Manager.SystemInformations info = new SystemInformations.Manager.SystemInformations();
            DiskDrive drive = info.GetDiskList().FirstOrDefault(c => c.PartitionName == Application.StartupPath.Substring(0, 2));

            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.BaseBoard,
                Info = JsonConvert.SerializeObject(info.GetBaseBoardInfo())
            });



            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Bios,
                Info = JsonConvert.SerializeObject(info.GetBaseBoardInfo())
            });



            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Cpu,
                Info = JsonConvert.SerializeObject(info.GetCpuInfo())
            });

            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.Network,
                Info = JsonConvert.SerializeObject(info.GetNetworkList().FirstOrDefault())
            });


            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.DiskDrive,
                Info = JsonConvert.SerializeObject(drive)
            });

            systemInfo.Add(new SystemInfo
            {

                InfoType = SystemInfoEnum.OperatingSystem,
                Info = JsonConvert.SerializeObject(info.GetOsInfo())
            });

        }
        public bool ModuleConfirm(ModuleTypeEnum module)
        {
            if (!confirmLicense || license == null)
            {
                return false;

            }

            return license.Modules.Any(c => c.ModuleTypeEnum == module);

        }

    }
}

