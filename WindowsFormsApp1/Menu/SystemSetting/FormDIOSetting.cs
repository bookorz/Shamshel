using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using TransferControl.Engine;
using TransferControl.Comm;
using TransferControl.Config.DIO;

namespace Adam.Menu.SystemSetting
{
    public partial class FormDIOSetting : Adam.Menu.SystemSetting.FormSettingFram
    {
        public FormDIOSetting()
        {
            InitializeComponent();
        }




        private void FormDIOSetting_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void UpdateList()
        {
            string strSql = string.Empty;

            try
            {



                lsbCondition.DataSource = DioSetting.GetAll();
                lsbCondition.DisplayMember = "Parameter";
                lsbCondition.ValueMember = "Parameter";
                lsbCondition.SelectedIndex = -1;


                txbDIOName.Text = string.Empty;
                nudAddress.Value = 0;
                txbParameter.Text = string.Empty;
                txbAbnormal.Text = string.Empty;
                txbType.Text = string.Empty;
                txbErrorCode.Text = string.Empty;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void lsbCondition_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsbCondition.SelectedIndex >= 0)
                {



                    txbDIOName.Text = ((DioSetting)lsbCondition.SelectedItem).DeviceName;
                    //nudAddress.Value = ((DioSetting)lsbCondition.SelectedItem).address;
                    txbParameter.Text = ((DioSetting)lsbCondition.SelectedItem).Parameter;
                    txbAbnormal.Text = ((DioSetting)lsbCondition.SelectedItem).abnormal;
                    txbType.Text = ((DioSetting)lsbCondition.SelectedItem).Type;
                    txbErrorCode.Text = ((DioSetting)lsbCondition.SelectedItem).error_code;

                }
                else
                {
                    txbDIOName.Text = string.Empty;
                    nudAddress.Value = 0;
                    txbParameter.Text = string.Empty;
                    txbAbnormal.Text = string.Empty;
                    txbType.Text = string.Empty;
                    txbErrorCode.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbParameter.Text.Trim().ToString().Equals(string.Empty))
            {
                MessageBox.Show("Parameter is empty.", "Alart", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                txbParameter.Focus();
                return;
            }

                ((DioSetting)lsbCondition.SelectedItem).abnormal = txbAbnormal.Text.Trim();
            ((DioSetting)lsbCondition.SelectedItem).error_code = txbErrorCode.Text.Trim();

            DioSetting.Update(((DioSetting)lsbCondition.SelectedItem));



            MessageBox.Show("Done it.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);


            //改設定後套用
            RouteControl.Instance.DIO.Initial();

        }
    }
}
