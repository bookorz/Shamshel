using Adam.UI_Update.Layout;
using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferControl.Config;
using TransferControl.Management;

namespace Adam.Menu.SystemSetting
{
    public partial class FormRecipeSetting_1R1A2P : Form
    {
        public TreeNode previousSelectedNode = null;
        public FormRecipeSetting_1R1A2P()
        {
            InitializeComponent();
        }

        
        private void btnCreateRecipe_Click(object sender, EventArgs e)
        {
            //gbRecipe.Enabled = true;
            //btnCreateRecipe.Enabled = false;
            //btnModifyRecipe.Enabled = false;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            tbRecipeName.Text = "";
            tbRecipeID.Text = "";
            tbRecipeName.ReadOnly = false;
            tbRecipeID.ReadOnly = false;
            tbRecipeName.Focus();
            trvRecipe.Enabled = false;
            ////gbRecipeHeader.Enabled = true;
            //cbAutoFin1.SelectedIndex = 0;
            //cbAutoFin2.SelectedIndex = 0;
            //cbAutoGetRule.SelectedIndex = 0;
            //cbAutoPutRule.SelectedIndex = 0;
            //cbInputFin1.SelectedIndex = 0;
            //cbInputFin2.SelectedIndex = 0;
            //cbInputFin3.SelectedIndex = 0;
            //cbManualFin1.SelectedIndex = 0;
            //cbManualFin2.SelectedIndex = 0;
            //cbManualGetRule.SelectedIndex = 0;
            //cbManualPutRule.SelectedIndex = 0;
            //cbOutputFin1.SelectedIndex = 0;
            //cbOutputFin2.SelectedIndex = 0;
            //cbOutputFin3.SelectedIndex = 0;
            //cbP1CstType.SelectedIndex = 0;
            //cbP1LoadType.SelectedIndex = 0;
            //cbP1Seq.SelectedIndex = 0;
            //cbP1Seq.SelectedIndex = 0;
            //cbP2CstType.SelectedIndex = 0;
            //cbP2LoadType.SelectedIndex = 0;
            //cbP2Seq.SelectedIndex = 0;
            //cbP3CstType.SelectedIndex = 0;
            //cbP3LoadType.SelectedIndex = 0;
            //cbP3Seq.SelectedIndex = 0;
            //cbP4CstType.SelectedIndex = 0;
            //cbP4LoadType.SelectedIndex = 0;
            //cbP4Seq.SelectedIndex = 0;

            lblMode.Text = "新增模式";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DIOUpdate.UpdateControlButton("Start_btn", false);
            DIOUpdate.UpdateControlButton("ManualTranfer_btn", false);
            DIOUpdate.UpdateControlButton("Stop_btn", false);
            //檢查資料
            if (tbRecipeID.Text.Trim().Equals("") || tbRecipeName.Text.Trim().Equals(""))
            {
                MessageBox.Show("Recipe Name or recipe id should not be empty.", "Data check error");
                return;
            }
            //權限檢查
            using (var form = new FormConfirm("確認是否儲存 Recipe:" + tbRecipeID.Text))
            {
                var result = form.ShowDialog();
                if (result != DialogResult.OK)
                {
                    MessageBox.Show("Cancel.", "Notice");
                    return;
                }
            }
            //GUI 處理
            //gbRecipe.Enabled = false;
            btnCreateRecipe.Enabled = true;
            btnModifyRecipe.Enabled = true;
            btnDeleteRecipe.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            tbRecipeName.ReadOnly = true;
            tbRecipeID.ReadOnly = true;
            trvRecipe.Enabled = true;
            //Recipe 存檔
            Recipe recipe = Recipe.Get(tbRecipeID.Text);
            if (recipe == null)
            {
                recipe = Recipe.Get("template");
            }
            recipe.aligner1_speed = tbA1_speed.Text.Equals("") ? "20" : Int32.Parse(tbA1_speed.Text).ToString();

            recipe.is_use_aligner1 = cbUseA1.Checked;
            recipe.is_use_burnin = cbUseBurnIn.Checked;
            recipe.wafer_size = cbWaferSize.Text;

            recipe.ocr_ttl_config = "";//此機型不支援
            recipe.ocr_t7_config = "";//此機型不支援
            recipe.ocr_m12_config = "";//此機型不支援

            recipe.auto_fin_unclamp = "Y";//固定Y

            recipe.auto_get_constrict = "0";//此機型不支援取放片限制
            recipe.auto_proc_fin = "";// cbAutoFin1.Text + cbAutoFin2.Text;
            recipe.auto_put_constrict = //此機型不支援取放片限制;
            //recipe.equip_id = tbEqpID.Text;
            recipe.ffu_rpm_close = "";//此機型不支援FFU
            recipe.ffu_rpm_open = "";
            recipe.input_proc_fin =  cbInputFin1.Text + cbInputFin2.Text + cbInputFin3.Text;

            recipe.manual_fin_unclamp = "Y";//固定Y

            recipe.manual_get_constrict = "";//此機型不支援取放片限制;
            recipe.manual_proc_fin = "";// cbManualFin1.Text + cbManualFin2.Text;
            recipe.manual_put_constrict = "";//此機型不支援取放片限制;
            recipe.output_proc_fin =  cbOutputFin1.Text + cbOutputFin2.Text + cbOutputFin3.Text;

            recipe.port1_carrier_type = cbP1CstType.Text;
            recipe.port1_priority = 1;
            recipe.port1_type = cbP1LoadType.Text;

            recipe.port2_carrier_type = cbP2CstType.Text;
            recipe.port2_priority = 1;
            recipe.port2_type = cbP2LoadType.Text;

            
            recipe.recipe_id = tbRecipeID.Text.Trim();
            recipe.recipe_name = tbRecipeName.Text;
            recipe.robot1_speed = tbR1Speed.Text.Equals("") ? "20" : Int32.Parse(tbR1Speed.Text).ToString();
            recipe.robot2_speed = "20";//default tbR2Speed.Text.Equals("") ? "20" : Int32.Parse(tbR2Speed.Text).ToString();

            recipe.notch_angle = tbNotch_angle.Text.Equals("") ? "0" : Int32.Parse(tbNotch_angle.Text).ToString();
            

            recipe.is_use_l_arm = cbUseLArm.Checked;
            recipe.is_use_r_arm = cbUseRArm.Checked;
            recipe.is_use_double_arm = cbUserBothArm.Checked;
            //recipe.ocr_check_Rule = cbOcrCheckRule.Text; 不支援OCR
            recipe.get_slot_order = cbGetSlotOrder.Text;
            recipe.put_slot_order = cbPutSlotOrder.Text;

            Recipe.Set(recipe.recipe_id, recipe);

            string CurrentRecipe = SystemConfig.Get().CurrentRecipe;
            if (cbActive.Checked)//設定生效
            {
                SystemConfig config = SystemConfig.Get();
                config.CurrentRecipe = tbRecipeID.Text;
                config.Save();
                FormMainUpdate.UpdateRecipe(tbRecipeID.Text);
            }
            else if(CurrentRecipe.Equals(tbRecipeID.Text))//取消生效
            {
                SystemConfig config = SystemConfig.Get();
                config.CurrentRecipe = "default";
                config.Save();
                //update node config
                FormMainUpdate.UpdateRecipe("default");
            }
            //紀錄修改Log
            if (tbRecipeID.Enabled)
                Util.SanwaUtil.addActionLog("Recipe", "Create", Global.currentUser, "建立 Recipe:" + recipe.recipe_id);
            if (tbRecipeID.Enabled)
                Util.SanwaUtil.addActionLog("Recipe", "Modify", Global.currentUser, "修改 Recipe:" + recipe.recipe_id);

            refreshList();
            lblMode.Text = "瀏覽模式";
            MessageBox.Show("Execute successfully.", "Success");
        }

        private Boolean checkOCRConfig(bool isUse, string content)
        {
            Boolean result = false;
            if (!isUse)
            {
                result = true;
            }else if (content.Trim().Equals("")|| content.Contains("."))
            {
                result = false;
            }
            else
            {
                try
                {
                    string[] configs = content.Split(',');
                    foreach (string id in configs)
                    {
                        if (Int32.Parse(id) > 50)
                        {
                            result = false;
                            return result;
                        }
                    }
                    result = true;
                }
                catch (Exception e)
                {
                    result = false;
                }
            }
            return result;
        }


        private void btnModifyRecipe_Click(object sender, EventArgs e)
        {
            if(trvRecipe.SelectedNode == null)
            {
                MessageBox.Show("Please select a recipe first.", "Notice");
                return;
            }
            lblMode.Text = "編輯模式";//往前移避免 stack overflow
            updateInfo(trvRecipe.SelectedNode.Text);
            //gbRecipe.Enabled = true;
            //gbRecipeBody.Enabled = true;
            //gbRecipeHeader.Enabled = false;
            //btnCreateRecipe.Enabled = true;
            //btnModifyRecipe.Enabled = true;
            //btnDeleteRecipe.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            tbRecipeName.ReadOnly = true;
            tbRecipeID.ReadOnly = true;
            //trvRecipe.Enabled = false;20190708 取消
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //gbRecipe.Enabled = false;
            //btnCreateRecipe.Enabled = true;
            //btnModifyRecipe.Enabled = true;
            //btnDeleteRecipe.Enabled = true;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            tbRecipeName.ReadOnly = true;
            tbRecipeID.ReadOnly = true;
            trvRecipe.Enabled = true;
            lblMode.Text = "瀏覽模式";
        }

        private void FormRecipeSetting_Load(object sender, EventArgs e)
        {
            refreshList();
            lblMode.Text = "瀏覽模式";
            if (Global.currentUser.Equals("SANWA"))
                cbUseBurnIn.Visible = true;
            else
                cbUseBurnIn.Visible = false;

        }

        private void refreshList()
        {
            trvRecipe.Nodes.Clear();
            DirectoryInfo d = new DirectoryInfo(@".\recipe");
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Json files
            TreeNode firstNode = null;
            foreach (FileInfo file in Files)
            {
                string recipeId = file.Name.Replace(".json", "");
                TreeNode tmp = new TreeNode(recipeId);
                trvRecipe.Nodes.Add(tmp);
                if (firstNode == null)
                    firstNode = tmp;
            }
            trvRecipe.ExpandAll();
            if (firstNode != null)
                trvRecipe.SelectedNode = firstNode;
            //if(trvRecipe.Nodes.Count>0)
            //    trvRecipe.Nodes.
        }

        private void trvRecipe_AfterSelect(object sender, TreeViewEventArgs e)
        {
            updateInfo(trvRecipe.SelectedNode.Text);
            if (previousSelectedNode != null)
            {
                previousSelectedNode.BackColor = trvRecipe.BackColor;
                previousSelectedNode.ForeColor = trvRecipe.ForeColor;
            }
        }

        private void updateInfo(string recipeID)
        {
            try
            {
                //gbRecipe.Enabled = true;
                Recipe recipe = Recipe.Get(recipeID);
                tbA1_speed.Text = recipe.aligner1_speed;

                //recipe.auto_fin_unclamp = "Y";//固定Y 無UI

                //tbEqpID.Text = recipe.equip_id;

                cbInputFin1.SelectedItem = recipe.input_proc_fin.Substring(0, 1);
                cbInputFin2.SelectedItem = recipe.input_proc_fin.Substring(1, 1);
                cbInputFin3.SelectedItem = recipe.input_proc_fin.Substring(2, 1);

                //recipe.manual_fin_unclamp = "Y";//固定Y 無UI

                cbOutputFin1.SelectedItem = recipe.output_proc_fin.Substring(0, 1);
                cbOutputFin2.SelectedItem = recipe.output_proc_fin.Substring(1, 1);
                cbOutputFin3.SelectedItem = recipe.output_proc_fin.Substring(2, 1);

                cbWaferSize.Text = recipe.wafer_size;
                cbP1CstType.SelectedItem = recipe.port1_carrier_type;
                cbP1LoadType.SelectedItem = recipe.port1_type;

                cbP2CstType.SelectedItem = recipe.port2_carrier_type;
                cbP2LoadType.SelectedItem = recipe.port2_type;

                cbGetSlotOrder.SelectedItem = recipe.get_slot_order;
                cbPutSlotOrder.SelectedItem = recipe.put_slot_order;

                tbRecipeID.Text = recipe.recipe_id;
                tbRecipeName.Text = recipe.recipe_name;
                tbR1Speed.Text = recipe.robot1_speed;
                //tbR2Speed.Text = recipe.robot2_speed;

                tbNotch_angle.Text = recipe.notch_angle;

                cbUseA1.Checked = recipe.is_use_aligner1;

                cbUseLArm.Checked = recipe.is_use_l_arm;
                cbUseRArm.Checked = recipe.is_use_r_arm;
                cbUserBothArm.Checked = recipe.is_use_double_arm;

                cbUseBurnIn.Checked = recipe.is_use_burnin;

                //gbRecipe.Enabled = false;
                string CurrentRecipe = SystemConfig.Get().CurrentRecipe;
                if (CurrentRecipe.Equals(tbRecipeID.Text))//取消生效
                {
                    cbActive.Checked = true;
                }
                else
                {
                    cbActive.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recipe 格式錯誤，讀取失敗! " + ex.StackTrace);
            }
        }

        private void digit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar.Equals(',') || e.KeyChar.Equals('.'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void modeCheck(object sender, EventArgs e)
        {
            
            //if (!btnSave.Enabled)
            if (lblMode.Text.Equals("瀏覽模式"))
            {
                //DialogResult myResult = MessageBox.Show
                //("目前為瀏覽模式，是否要編輯?", "Change Mode?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //if (myResult == DialogResult.Yes)
                //{
                //    btnModifyRecipe_Click(null, null);
                //}
                btnModifyRecipe_Click(null, null);
            }
            else
            {
                return;
            }

        }

        private void trvRecipe_Validating(object sender, CancelEventArgs e)
        {
            trvRecipe.SelectedNode.BackColor = SystemColors.Highlight;
            trvRecipe.SelectedNode.ForeColor = Color.White;
            previousSelectedNode = trvRecipe.SelectedNode;
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (trvRecipe.SelectedNode == null)
            {
                MessageBox.Show("Please select a recipe first.", "Notice");
                return;
            }
            Recipe recipe = Recipe.Get(trvRecipe.SelectedNode.Text);
            if (recipe.recipe_id.Equals("default"))
            {
                MessageBox.Show("default recipe 不得刪除.", "Notice");
                return;
            }
            else if (SystemConfig.Get().CurrentRecipe.Equals(recipe.recipe_id))
            {
                MessageBox.Show("Recipe 使用中，請先切換 recipe 後再刪除.", "Notice");
                return;
            }
            using (var form = new FormConfirm("確認是否刪除 Recipe:" + recipe.recipe_id))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (Recipe.Delete(recipe.recipe_id))
                    {
                        refreshList();
                        Util.SanwaUtil.addActionLog("Recipe", "Delete", Global.currentUser, "刪除 Recipe:" + recipe.recipe_id);
                        MessageBox.Show("Delete completed.", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Delete fail.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Cancel.", "Notice");
                }
            }
        }

        private void cbUseRArm_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name.Equals("cbUseRArm"))
            {
                if (!cbUseRArm.Checked || !cbUseLArm.Checked)
                {
                    cbUserBothArm.Checked = false;
                }
            }
        }

        private void cbUseLArm_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name.Equals("cbUseLArm"))
            {
                if (!cbUseRArm.Checked || !cbUseLArm.Checked)
                {
                    cbUserBothArm.Checked = false;
                }
            }
        }

        private void cbUserBothArm_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Name.Equals("cbUserBothArm"))
            {
                if (cbUserBothArm.Checked)
                {
                    cbUseRArm.Checked = true;
                    cbUseLArm.Checked = true;
                    cbUserBothArm.Checked = true;
                }
            }
        }


        private void modeCheck(object sender, PreviewKeyDownEventArgs e)
        {
            modeCheck(sender, new EventArgs());
        }
    }
}
