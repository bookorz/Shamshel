using GUI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferControl.Config;
using TransferControl.Config.DIO;

namespace Adam.Menu.SystemSetting
{
    public partial class FormSimpleSetting : Form
    {
        

        private void UpdateConfigView()
        {

            dgvMysql.DataSource = DioSetting.GetAll();

            foreach (DataGridViewColumn column in dgvMysql.Columns)
            {
                if (column.HeaderText.EndsWith("_r"))
                {
                    column.ReadOnly = true;
                    column.DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    column.ReadOnly = false;
                    column.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormSimpleSetting_Load(object sender, EventArgs e)
        {
           
            UpdateConfigView();
        }

        private void FormSimpleSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        public FormSimpleSetting(Config_Type config_Type)
        {
        
            InitializeComponent();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
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
                DioSetting.Update((List<DioSetting>)dgvMysql.DataSource);
                
                MessageBox.Show("Update 成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
