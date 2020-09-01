using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using Adam.UI_Update.Monitoring;
using GUI;
using TransferControl.Comm;
using TransferControl.Config.SignalTower;

namespace Adam.Menu.SystemSetting
{
    public partial class FormSignalTower : Adam.Menu.SystemSetting.FormSettingFram
    {
        public FormSignalTower()
        {
            InitializeComponent();
        }



        private void FormSignalTtower_Load(object sender, EventArgs e)
        {

            DataTable dtTemp = new DataTable();
            string strSql = string.Empty;

            try
            {
                UpdateList();

                lsbCondition.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void lsbCondition_Click(object sender, EventArgs e)
        {
            if (lsbCondition.SelectedIndex == -1)
            {
                return;
            }
            txbEqpStatus.Text = string.Empty;
            txbIsAlarm.Text = string.Empty;
            cmbBlue.SelectedIndex = -1;
            cmbGreen.SelectedIndex = -1;
            cmbRad.SelectedIndex = -1;
            cmbYellow.SelectedIndex = -1;
            cmbBuzzer1.SelectedIndex = -1;
            cmbBuzzer2.SelectedIndex = -1;

            try
            {
                SignalTowerSetting s = SignalTowerSetting.Get(lsbCondition.SelectedItem.ToString().Replace("-Alarm", ""), lsbCondition.SelectedItem.ToString().Contains("-Alarm"));

                txbEqpStatus.Text = s.eqpStatus;
                txbIsAlarm.Text = s.hasAlarm?"TRUE":"FALSE";
                cmbBlue.SelectedItem = s.blue;
                cmbGreen.SelectedItem = s.green;
                cmbRad.SelectedItem = s.red;
                cmbYellow.SelectedItem = s.orange;
                cmbBuzzer1.SelectedItem = s.buzzer1;
                cmbBuzzer2.SelectedItem = s.buzzer2;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (lsbCondition.SelectedIndex < 0)
            {
                MessageBox.Show("Choose the condition.", this.Name, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
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

            string strSql = string.Empty;
            Dictionary<string, object> keyValues = new Dictionary<string, object>();

            try
            {
                SignalTowerSetting s = SignalTowerSetting.Get(lsbCondition.SelectedItem.ToString().Replace("-Alarm", ""), lsbCondition.SelectedItem.ToString().Contains("-Alarm"));
                s.red = cmbRad.Text.ToString();
                s.orange = cmbYellow.Text.ToString();
                s.green = cmbGreen.Text.ToString();
                s.blue = cmbBlue.Text.ToString();
                s.buzzer1 = cmbBuzzer1.Text.ToString();
                s.buzzer2 = cmbBuzzer2.Text.ToString();

                SignalTowerSetting.Update(s);


                MessageBox.Show("Done it.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

              

                UpdateList();

                txbEqpStatus.Text = string.Empty;
                txbIsAlarm.Text = string.Empty;
                cmbBlue.SelectedIndex = -1;
                cmbGreen.SelectedIndex = -1;
                cmbRad.SelectedIndex = -1;
                cmbYellow.SelectedIndex = -1;
                cmbBuzzer1.SelectedIndex = -1;
                cmbBuzzer2.SelectedIndex = -1;
                lsbCondition.SelectedIndex = -1;
                //改設定後套用
                NodeStatusUpdate.InitialSetting();
                NodeStatusUpdate.UpdateCurrentState(FormMain.RouteCtrl.EqpState);
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
                lsbCondition.Items.Clear();
                foreach (SignalTowerSetting each in SignalTowerSetting.GetAll())
                {
                    lsbCondition.Items.Add(each.eqpStatus + (each.hasAlarm ? "-Alarm" : ""));
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
    }
}
