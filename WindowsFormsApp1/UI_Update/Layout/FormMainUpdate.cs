using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferControl.Comm;
using TransferControl.Config;
using TransferControl.Management;

namespace Adam.UI_Update.Layout
{
    class FormMainUpdate
    {
        static ILog logger = LogManager.GetLogger(typeof(FormMainUpdate));
        delegate void UpdateValue(string Value);

        public static void UpdateRecipe(string Value)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];
                if (form == null)
                    return;
                Label lblRecipe = form.Controls.Find("CurrentRecipe_lb", true).FirstOrDefault() as Label;

                if (lblRecipe == null)
                    return;
                if (lblRecipe.InvokeRequired)
                {
                    UpdateValue ph = new UpdateValue(UpdateRecipe);
                    lblRecipe.BeginInvoke(ph, Value);
                }
                else
                {
                    lblRecipe.Text = Value;
                    updateLoadPortConfig(Recipe.Get(Value));
                    Recipe.updateDBConfig(Value);//更新DB資料
                }
            }
            catch (Exception e)
            {
                logger.Error("UpdateRecipe: Update fail. err:" + e.StackTrace);
            }
        }
        private void UpdateNode(Recipe rcp)
        {
            
        }
        private static string getPortType(string port_type)
        {
            string result = "";
            switch (port_type)
            {
                case "L":
                    result = "LD";
                    break;
                case "U":
                    result = "ULD";
                    break;
                case "N":
                    result = "";
                    break;
            }
            return result;
        }
        private static int getEnable(string port_type)
        {
            int result = 0;
            switch (port_type)
            {
                case "L":
                case "U":
                    result = 1;
                    break;
                case "N":
                    result = 0;
                    break;
            }
            return result;
        }

        private static void updateLoadPortConfig(Recipe recipe)
        {
            Boolean result = false;
            try
            {
                foreach(Node node in NodeManagement.GetList())
                {
                    switch (node.Name.ToUpper())
                    {
                        case "LOADPORT01":
                            node.CarrierType = recipe.port1_carrier_type;
                            node.Mode = getPortType(recipe.port1_type);
                            node.Enable = getEnable(recipe.port1_type) == 1 ? true : false;
                            node.OrgSearchComplete = false;
                            break;
                        case "LOADPORT02":
                            node.CarrierType = recipe.port2_carrier_type;
                            node.Mode = getPortType(recipe.port2_type);
                            node.Enable = getEnable(recipe.port2_type) == 1 ? true : false;
                            node.OrgSearchComplete = false;
                            break;
                        case "LOADPORT03":
                            node.CarrierType = recipe.port3_carrier_type;
                            node.Mode = getPortType(recipe.port3_type);
                            node.Enable = getEnable(recipe.port3_type) == 1 ? true : false;
                            node.OrgSearchComplete = false;
                            break;
                        case "LOADPORT04":
                            node.CarrierType = recipe.port4_carrier_type;
                            node.Mode = getPortType(recipe.port4_type);
                            node.Enable = getEnable(recipe.port4_type) == 1 ? true : false;
                            node.OrgSearchComplete = false;
                            break;
                        case "ROBOT01":
                            node.RArmActive = recipe.is_use_r_arm;
                            node.LArmActive = recipe.is_use_l_arm;
                            node.DoubleArmActive = recipe.is_use_double_arm;
                            break;
                        case "ALIGNER01":
                            node.ByPass = !recipe.is_use_aligner1;
                            break;
                        case "ALIGNER02":
                            node.ByPass = !recipe.is_use_aligner2;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update load port 資訊失敗! " + ex.StackTrace);
            }
        }
    }
}
