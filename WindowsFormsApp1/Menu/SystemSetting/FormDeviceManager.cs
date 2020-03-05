using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using TransferControl.Management;
using log4net;
using TransferControl.Controller;
using GUI;
using TransferControl.Config;
using TransferControl.Comm;

namespace Adam.Menu.SystemSetting
{
    public partial class FormDeviceManager : Form
    {
        public FormDeviceManager()
        {
            InitializeComponent();
        }

        //private SANWA.Utility.config_equipment_model equipment_Model = new SANWA.Utility.config_equipment_model();
       
        private static readonly ILog logger = LogManager.GetLogger(typeof(FormDeviceManager));

        private void FormDeviceManager_Load(object sender, EventArgs e)
        {
            string strSql = string.Empty;
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
     

            DataTable dtTemp = new DataTable();

            try
            {
                UpdateNodeList();



            }
            catch (Exception ex)
            {
                //throw new Exception(ex.ToString());
                logger.Error(ex.StackTrace);
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNodeList()
        {
            string strSql = string.Empty;
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
        

            try
            {
                
                    lstNodeList.DataSource = NodeManagement.GetList();
                    lstNodeList.DisplayMember = "Name";
                    lstNodeList.ValueMember = "Name";
                    lstNodeList.SelectedIndex = -1;
              

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void lstNodeList_Click(object sender, EventArgs e)
        {
          
            string ControllerName = "";
            try
            {
              
                Node targetNode = NodeManagement.Get(lstNodeList.SelectedValue.ToString());
               
                   

                    Setting_NodeName_lb.Text = targetNode.Name;

                    Setting_NodeType_lb.Text = targetNode.Type;

                    ControllerName = targetNode.Controller;

                    if (targetNode.Enable)
                    {
                        Setting_NodeEnable_rb.Checked = true;
                    }
                    else
                    {
                        Setting_NodeDisable_rb.Checked = true;
                    }

                    Setting_CarrierType_cb.Text = targetNode.CarrierType;
                    Setting_Mode_cb.Text = targetNode.Mode;
                    if (Setting_NodeType_lb.Text.ToUpper().Equals("LOADPORT"))
                    {
                        Setting_CarrierType_cb.Visible = true;
                        Setting_CarrierType_lb.Visible = true;
                        Setting_Mode_cb.Visible = true;
                        Setting_Mode_lb.Visible = true;
                    }
                    else
                    {
                        Setting_CarrierType_cb.Visible = false;
                        Setting_CarrierType_lb.Visible = false;
                        Setting_Mode_cb.Visible = false;
                        Setting_Mode_lb.Visible = false;
                    }
                
               
                  
                    Setting_ControllerName_lb.Text = targetNode.GetController().GetDeviceName();
                    Setting_connectType_cb.Text = targetNode.GetController().GetConnectionType();
                    Setting_Address_tb.Text = targetNode.GetController().GetIPAdress();
                    Setting_Port_tb.Text = targetNode.GetController().GetPort().ToString();
                    if (Setting_connectType_cb.Text.ToUpper().Equals("SOCKET"))
                    {
                        setting_Address_lb.Text = "Address:";
                        Setting_Port_lb.Text = "Port:";
                    }
                    else
                    {
                        setting_Address_lb.Text = "Comport:";
                        Setting_Port_lb.Text = "Baud Rate:";
                    }

                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            string strSql = string.Empty;
            StringBuilder sbErrorMessage = new StringBuilder();
            Dictionary<string, object> keyValues = new Dictionary<string, object>();
  
            DataTable dtTemp = new DataTable();
      

            try
            {
                Node currentNode = NodeManagement.Get(Setting_NodeName_lb.Text);

                if (currentNode == null)
                {
                    MessageBox.Show("Node "+Setting_NodeName_lb.Text + " is not exist!");
                    return;
                }
                IController currentController = ControllerManagement.Get(currentNode.Controller);
                if (currentController == null)
                {
                    MessageBox.Show("Controller "+currentNode.Controller + " is not exist!");
                    return;
                }
                //權限檢查
                using (var form = new FormConfirm("是否儲存變更?"))
                {
                    var result = form.ShowDialog();
                    if (result != DialogResult.OK)
                    {
                        MessageBox.Show("Cancel.", "Notice");
                        return;
                    }
                }
                currentNode.Enable = Setting_NodeEnable_rb.Checked;
                currentNode.CarrierType = Setting_CarrierType_cb.Text;
                currentNode.Mode = Setting_Mode_cb.Text;


                NodeManagement.Save();

                MessageBox.Show("連線相關設定值，將於重啟程式後生效.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);




            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void Setting_connectType_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Setting_connectType_cb.Text.ToUpper())
            {
                case "COMPORT":
                    setting_Address_lb.Text = "Comport:";
                    Setting_Port_lb.Text = "Baud Rate:";
                    break;
                case "SOCKET":
                    setting_Address_lb.Text = "Address:";
                    Setting_Port_lb.Text = "Port:";
                    break;
            }
        }
    }
}
