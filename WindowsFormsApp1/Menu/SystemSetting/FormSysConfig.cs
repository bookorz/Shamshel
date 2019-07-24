﻿using Adam.UI_Update.Layout;
using GUI;
using System;
using System.IO;
using System.Windows.Forms;
using TransferControl.Config;

namespace Adam.Menu.SystemSetting
{
    public partial class FormSysConfig : Form
    {
        public TreeNode previousSelectedNode = null;
        public FormSysConfig()
        {
            InitializeComponent();
        }

        private void FormSysConfig_Load(object sender, EventArgs e)
        {
            //init recipe combobox
            cbRecipe.Items.Clear(); DirectoryInfo d = new DirectoryInfo(@".\recipe");
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Json files
            foreach (FileInfo file in Files)
            {
                string recipeId = file.Name.Replace(".json", "");
                cbRecipe.Items.Add(recipeId);
            }
            //set gui data
            SystemConfig config = SystemConfig.Get();
            tbConnString.Text = config.DBConnectionString;
            tbEqpId.Text = config.EquipmentID;
            tbOcr1Exe.Text = config.OCR1ExePath;
            tbOcr1ImgBak.Text = config.OCR1ImgToJpgPath;
            tbOcr1ImgSrc.Text = config.OCR1ImgSourcePath;
            tbOcr2Exe.Text = config.OCR2ExePath;
            tbOcr2ImgBak.Text = config.OCR2ImgToJpgPath;
            tbOcr2ImgSrc.Text = config.OCR2ImgSourcePath;
            tbSysMode.Text = config.SystemMode;
            tbTxfLogPath.Text = config.FoupTxfLogPath;
            cbChkBypass.Checked = config.SaftyCheckByPass;
            cbFakeData.Checked = config.FakeData;
            cbRecipe.SelectedItem = config.CurrentRecipe;
            cbNoticeInitFin.SelectedItem = config.NoticeInitFin;
            cbNoticeProcFin.SelectedItem = config.NoticeProcFin;
        }

        private void btnSave_Click(object sender, EventArgs e)
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

            SystemConfig config = SystemConfig.Get();
            //目前只開放更新以下資料
            config.EquipmentID = tbEqpId.Text;
            config.OCR1ImgToJpgPath = tbOcr1ImgBak.Text;
            config.OCR2ImgToJpgPath = tbOcr2ImgBak.Text;
            config.FoupTxfLogPath = tbTxfLogPath.Text;
            config.CurrentRecipe = cbRecipe.SelectedItem.ToString();
            config.NoticeInitFin = cbNoticeInitFin.SelectedItem.ToString();//初始化鈴聲提示
            config.NoticeProcFin = cbNoticeProcFin.SelectedItem.ToString();//完工鈴聲提示

            config.Save();
            MessageBox.Show("Update Completed.","Success");
            FormMainUpdate.UpdateRecipe(config.CurrentRecipe);
        }
    }
}
