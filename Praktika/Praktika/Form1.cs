using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Management.Instrumentation;


namespace Praktika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem"); 

        private void button1_Click(object sender, EventArgs e)
        { 
            richTextBox_battery.Text = @" Процент заряда:" + SystemInformation.PowerStatus.BatteryLifePercent + "\n"
                + "Состояние питания системы:" + SystemInformation.PowerStatus.PowerLineStatus;
            foreach (ManagementObject queryObj in searcher.Get())
            {
                richTextBox_os.Text = @"BuildNumber:" + queryObj["BuildNumber"] + "\n" +
                    "Caption:" + queryObj["Caption"] + "\n"
                    + "FreePhysicalMemory:" + queryObj["FreePhysicalMemory"] + "\n"
                    + "FreeVirtualMemory:" + queryObj["FreeVirtualMemory"] + "\n" +
                    "Name:" + queryObj["Name"] +
                    "\nOSType:" + queryObj["OSType"] +
                    "\nRegisteredUser:" + queryObj["RegisteredUser"] + "\n" +
                "SerialNumber:" + queryObj["SerialNumber"] + "\n" +
                 "ServicePackMajorVersion:" + queryObj["ServicePackMajorVersion"] + "\n" +
                "ServicePackMinorVersion:" + queryObj["ServicePackMinorVersion"] + "\n" +
                "Status:" + queryObj["Status"] + "\n" +
                "SystemDevice:" + queryObj["SystemDevice"] + "\n"
                + "SystemDirectory:" + queryObj["SystemDirectory"] + "\n" +
                "SystemDrive:" + queryObj["SystemDrive"] + "\n" +
                 "Version:" + queryObj["Version"] + "\n" +
                "WindowsDirectory:" + queryObj["WindowsDirectory"]; 
            }
            searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_VideoController");
            
            foreach (ManagementObject queryObj in searcher.Get())
            {
                richTextBox2_video.Text = @"AdapterRAM:" + queryObj["AdapterRAM"] + "\nCaption:" + queryObj["Caption"] +
                    "\nDescription:" + queryObj["Description"] + "\nVideoProcessor:" + queryObj["VideoProcessor"];
            }

            searcher = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Processor");
            foreach (ManagementObject queryObj in searcher.Get())
            {
                richTextBox_CPU.Text = @"Name:" + queryObj["Name"] + "\nNumberOfCores:" + queryObj["NumberOfCores"] +
               "\nProcessorId:" + queryObj["ProcessorId"];
            }
            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
             
            foreach (ManagementObject queryObj in searcher.Get())
            {
                richTextBox_RAM.Text = @"BankLabel:" + queryObj["BankLabel"] + "\nCapacity:" + Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024, 2) + " Gb \nSpeed:" + queryObj["Speed"];
            }
            searcher  = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive"); 

            foreach (ManagementObject queryObj in searcher.Get())
            {
                richTextBox_disc.Text = @"DeviceID:" + queryObj["DeviceID"] + "\nInterfaceType:" + queryObj["InterfaceType"] +
                    "\nManufacturer:" + queryObj["Manufacturer"] + "\nModel:" + queryObj["Model"] + "\nSerialNumber:" + queryObj["SerialNumber"] + "\nSize:" + Math.Round(Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2) + " Gb";
            }
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "Привет " + SystemInformation.ComputerName;
        }
    }
}
