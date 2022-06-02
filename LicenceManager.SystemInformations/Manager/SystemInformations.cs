using LicenceManager.SystemInformations.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace LicenceManager.SystemInformations.Manager
{
    public class SystemInformations
    {
        public List<Network> GetNetworkList()
        {

            List<Network> list = new List<Network>();
            foreach (var network in NetworkInterface.GetAllNetworkInterfaces().Where(c => c.OperationalStatus == OperationalStatus.Up && !string.IsNullOrEmpty(c.GetPhysicalAddress().ToString())))
            {
                list.Add(new Network
                {

                    Caption = network.Name,
                    Description = network.Description,
                    MacAdress = network.GetPhysicalAddress().ToString()

                });
            }

            return list;
        }
        public Bıos GetBıosInfo()
        {

            ManagementObjectSearcher managament = new ManagementObjectSearcher("Select Name,Caption,Manufacturer,SerialNumber,ReleaseDate From Win32_BIOS");
            ManagementObjectCollection collection = managament.Get();
            Bıos bios = new Bıos();
            foreach (var prop in collection)
            {
                bios.Name = prop["Name"].ToString();
                bios.Caption = prop["Caption"].ToString();
                bios.Manufacturer = prop["Manufacturer"].ToString();
                bios.ReleaseDate = ManagementDateTimeConverter.ToDateTime(prop["ReleaseDate"].ToString());
                bios.SerialNumber = prop["SerialNumber"].ToString();
            }
            return bios;
        }
        public BaseBoard GetBaseBoardInfo()
        {
            ManagementObjectSearcher managament = new ManagementObjectSearcher("Select Name,Product,Manufacturer,SerialNumber From Win32_BaseBoard");
            ManagementObjectCollection collection = managament.Get();
            BaseBoard baseboard = new BaseBoard();
            foreach (ManagementObject prop in collection)
            {
                baseboard.Name = prop["Name"].ToString();

                baseboard.Model = prop["Product"].ToString();
                baseboard.Manufacturer = prop["Manufacturer"].ToString();
                baseboard.SerialNumber = prop["SerialNumber"].ToString();

            }
            return baseboard;
        }
        public Cpu GetCpuInfo()
        {


            ManagementObjectSearcher managament = new ManagementObjectSearcher("Select Name,Caption,DeviceId,ProcessorId,NumberOfCores From Win32_Processor");
            ManagementObjectCollection collection = managament.Get();
            Cpu cpu = new Cpu();
            foreach (ManagementObject prop in collection)
            {

                cpu.Name = prop["Name"].ToString();
                cpu.Caption = prop["Caption"].ToString();
                cpu.ProcessorId = prop["ProcessorId"].ToString();
                cpu.SerialNumber = prop["DeviceId"].ToString();
                cpu.NumberOfCores = prop["NumberOfCores"].ToString();

            }
            return cpu;
        }
        public Tables.OperatingSystem GetOsInfo()
        {


            ManagementObjectSearcher managament = new ManagementObjectSearcher("Select Name,Caption,SerialNumber,RegisteredUser From Win32_OperatingSystem");
            ManagementObjectCollection collection = managament.Get();
            Tables.OperatingSystem os = new Tables.OperatingSystem();
            foreach (var prop in collection)
            {

                os.Name = prop["Name"].ToString();
                os.Caption = prop["Caption"].ToString();
                os.SerialNumber = prop["SerialNumber"].ToString();
                os.RegisteredUser = prop["RegisteredUser"].ToString();

            }
            return os;
        }
        public List<DiskDrive> GetDiskList()
        {

            List<DiskDrive> list = new List<DiskDrive>();
            ManagementObjectSearcher diskManagament = new ManagementObjectSearcher("Select Name,Caption,DeviceID,SerialNumber,Model From Win32_DiskDrive");
            foreach (ManagementObject drive in diskManagament.Get())
            {
                ManagementObjectSearcher partitionManagement = new ManagementObjectSearcher(String.Format("associators of {{{0}}} where AssocClass=Win32_DiskDriveToDiskPartition", drive.Path.RelativePath));
                foreach (ManagementObject partition in partitionManagement.Get())
                {
                    ManagementObjectSearcher logicalManagement = new ManagementObjectSearcher(String.Format("associators of {{{0}}} where AssocClass=Win32_LogicalDiskToPartition", partition.Path.RelativePath));

                    foreach (ManagementObject logicalDisk in logicalManagement.Get())
                    {
                        list.Add(new DiskDrive
                        {

                            Name = drive["Name"].ToString(),
                            SerialNumber = drive["SerialNumber"].ToString(),
                            Caption = drive["Caption"].ToString(),
                            DeviceID = drive["DeviceID"].ToString(),
                            Model = drive["Model"].ToString(),
                            FileSystem = logicalDisk["FileSystem"].ToString(),
                            MediaType = logicalDisk["MediaType"].ToString(),
                            PartitionName = logicalDisk["Name"].ToString(),
                            VolumeSerialNumber = logicalDisk["VolumeSerialNumber"].ToString()

                        });

                    }

                }

            }
            return list;

        }
    }
}


