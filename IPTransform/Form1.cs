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
using System.Text.RegularExpressions;
using DevExpress.XtraEditors;
using System.Net.NetworkInformation;

namespace IPTransform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkAddressChangedCallback);
            UpdateNetworkList();
        }


        //NetworkChange.NetworkAddressChanged += new NetworkAddressChangedEventHandler(NetworkAddressChangedCallback);
        //UpdateNetworkList();

        private void NetworkAddressChangedCallback(object sender, EventArgs e)
        {
            UpdateNetworkList();
        }

        private void UpdateNetworkList()
        {
            Cbox_NetworkList.Items.Clear();

            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            Txt_Ip.Text = " ";
            Txt_Mask.Text = " ";

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    var a = objMO["Caption"].ToString();
                    a = a.Substring(a.IndexOf("]") + 2);
                    Cbox_NetworkList.Items.Add(a);
                }
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            //SetIP("Ethernet", "192.168.1.101", "255.255.255.0");

            #region Network donanımlarını cbox a ekler

            //ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            //ManagementObjectCollection objMOC = objMC.GetInstances();

            //foreach (ManagementObject objMO in objMOC)
            //{
            //    if ((bool)objMO["IPEnabled"])
            //    {
            //        var a = objMO["Caption"].ToString();
            //        a = a.Substring(a.IndexOf("]")+2);
            //        Cbox_NetworkList.Items.Add(a);
            //    }
            //}
            
            #endregion
        }



        public static (bool isDhcpEnabled, string[] ipAddresses, string[] subnetMasks) Network_Find(string networkInterface)
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"] && objMO["Caption"].ToString().Contains(networkInterface))
                {
                    bool isDhcpEnabled = false;
                    if (objMO["DHCPEnabled"] != null)
                        isDhcpEnabled = (bool)objMO["DHCPEnabled"];

                    string[] ipAddresses = (string[])objMO["IPAddress"];
                    string[] subnetMasks = (string[])objMO["IPSubnet"];

                    return (isDhcpEnabled, ipAddresses, subnetMasks);
                }
            }

            return (false, null, null);
        }


        public static void SetIP(string networkInterface, string ipAddress, string subnetMask) // manuel ip almayı sağlıyor
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(networkInterface))
                    {
                        ManagementBaseObject objNewIP = null;
                        ManagementBaseObject objSetIP = null;
                        ManagementBaseObject objNewGate = null;

                        try
                        {
                            objNewIP = objMO.GetMethodParameters("EnableStatic");
                            objNewIP["IPAddress"] = new string[] { ipAddress };
                            objNewIP["SubnetMask"] = new string[] { subnetMask };

                            objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }


        public static void SetDHCP(string networkInterface) // otomatik ip almayı sağlıyor
        {
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();

            foreach (ManagementObject objMO in objMOC)
            {
                if ((bool)objMO["IPEnabled"])
                {
                    if (objMO["Caption"].ToString().Contains(networkInterface))
                    {
                        try
                        {
                            ManagementBaseObject objNewIP = null;
                            objNewIP = objMO.InvokeMethod("EnableDHCP", null, null);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
            }
        }

        private void RBtn_Oto_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_Oto.Checked)
            {
                Txt_Ip.Enabled = false;
                Txt_Mask.Enabled = false;
            }
        }

        private void RBtn_Man_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtn_Man.Checked)
            {
                Txt_Ip.Enabled = true;
                Txt_Mask.Enabled = true;
            }
        }

        private void Txt_Mask_Click(object sender, EventArgs e)
        {
            Txt_Mask.Text = "255.255.255.0";
        }

        private void Txt_Ip_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                Txt_Mask.Text = "255.255.255.0";
            }
        }

        private void Btn_Set_Ip_Click(object sender, EventArgs e)
        {
            if (RBtn_Oto.Checked) // Otomatik ıp
            {
                if (Cbox_NetworkList.Text != "")
                {
                    SetDHCP(Cbox_NetworkList.Text);
                }
                else
                {
                    MessageBox.Show("Eksik parametre !", "Uyarı");
                }
            }

            if (RBtn_Man.Checked) // Manuel ıp
            {
                if (Txt_Ip.Text != "" && Txt_Mask.Text != "")
                {
                    SetIP(Cbox_NetworkList.Text,Txt_Ip.Text, Txt_Mask.Text);
                }
                else
                {
                    MessageBox.Show("Eksik parametre !", "Uyarı");
                }

            }
        }

        private void Cbox_NetworkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result_dhcp = Network_Find(Cbox_NetworkList.Text).isDhcpEnabled;
            var result_ip = Network_Find(Cbox_NetworkList.Text).ipAddresses[0];
            var result_mask = Network_Find(Cbox_NetworkList.Text).subnetMasks[0];
            if (result_dhcp) 
            {
                RBtn_Oto.Checked = true;
            }
            else
            {
                RBtn_Man.Checked = true;
            }
            Txt_Ip.Text = result_ip;
            Txt_Mask.Text = result_mask;


        }

    }
}
