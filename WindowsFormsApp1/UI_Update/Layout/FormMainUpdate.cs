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
                Recipe.updateDBConfig(Value);//更新DB資料
                if (lblRecipe.InvokeRequired)
                {
                    UpdateValue ph = new UpdateValue(UpdateRecipe);
                    lblRecipe.BeginInvoke(ph, Value);
                }
                else
                {
                    lblRecipe.Text = Value;
                   
                    
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

        
    }
}
