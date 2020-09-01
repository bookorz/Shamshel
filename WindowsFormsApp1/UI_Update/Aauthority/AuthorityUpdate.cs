using Adam.Util;
using log4net;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransferControl.Comm;
using TransferControl.Config;
using TransferControl.Config.Authorization;

namespace Adam.UI_Update.Authority
{
    class AuthorityUpdate
    {
        static ILog logger = LogManager.GetLogger(typeof(AuthorityUpdate));

        delegate void UpdateLogin(string Id, string Name, string Group);
        delegate void UpdateLogout();
        delegate void UpdateFuncEnable_D(string Form, string Control, bool active);
        public static Dictionary<string, TabPage> tabPages = new Dictionary<string, TabPage>();

        public static void UpdateLoginInfo(string Id, string Name, string Group)
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];

                if (form == null)
                    return;

                if (form.InvokeRequired)
                {
                    UpdateLogin ph = new UpdateLogin(UpdateLoginInfo);
                    form.BeginInvoke(ph, Id, Name, Group);
                }
                else
                {
                    //lbl_login_name
                    Label lbl_login_id = form.Controls.Find("lbl_login_id", true).FirstOrDefault() as Label;
                    Label lbl_login_name = form.Controls.Find("lbl_login_name", true).FirstOrDefault() as Label;
                    Label lbl_login_group = form.Controls.Find("lbl_login_group", true).FirstOrDefault() as Label;
                    Label lbl_login_date = form.Controls.Find("lbl_login_date", true).FirstOrDefault() as Label;
                    if (lbl_login_id != null)
                        lbl_login_id.Text = Id;
                    if (lbl_login_name != null)
                        lbl_login_name.Text = Name;
                    if (lbl_login_group != null)
                        lbl_login_group.Text = Group;
                    if (lbl_login_date != null)
                        lbl_login_date.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH：mm：ss");
                    Button btnLogout = form.Controls.Find("btnLogInOut", true).FirstOrDefault() as Button;
                    if (btnLogout.Text.Equals("Login"))
                        btnLogout.Text = "Logout";
                    if (btnLogout.Text.Equals("登录"))
                        btnLogout.Text = "登出";
                    Button btnEdit = form.Controls.Find("btnChgPWD", true).FirstOrDefault() as Button;
                    btnEdit.Visible = true;
                    //AuthorityUpdate.UpdateFuncAssign(Group);
                    AuthorityUpdate.UpdateFuncGroupEnable(Group);

                }


            }
            catch
            {
                logger.Error("UpdateLoginInfo: Update fail.");
            }
        }

        public static void UpdateLogoutInfo()
        {
            try
            {
                Form form = Application.OpenForms["FormMain"];

                if (form == null)
                    return;

                if (form.InvokeRequired)
                {
                    UpdateLogout ph = new UpdateLogout(UpdateLogoutInfo);
                    form.BeginInvoke(ph);
                }
                else
                {
                    bool isCn = SystemConfig.Get().Language.Equals("CN");
                    ILog log = LogManager.GetLogger("Database");
                    //lbl_login_name
                    Label lbl_login_id = form.Controls.Find("lbl_login_id", true).FirstOrDefault() as Label;
                    Label lbl_login_name = form.Controls.Find("lbl_login_name", true).FirstOrDefault() as Label;
                    Label lbl_login_group = form.Controls.Find("lbl_login_group", true).FirstOrDefault() as Label;
                    Label lbl_login_date = form.Controls.Find("lbl_login_date", true).FirstOrDefault() as Label;
                    string user_id = lbl_login_id.Text;
                    string user_name = lbl_login_name.Text;
                    if (lbl_login_id != null)
                        lbl_login_id.Text = isCn ? "账户" : "ID";
                    if (lbl_login_name != null)
                        lbl_login_name.Text = isCn ? "名称" : "Name";
                    if (lbl_login_group != null)
                        lbl_login_group.Text = isCn ? "群组" : "Group";
                    if (lbl_login_date != null)
                        lbl_login_date.Text = "";
                    Button btn = form.Controls.Find("btnLogInOut", true).FirstOrDefault() as Button;
                    if (btn.Text.Equals("Logout"))
                        btn.Text = "Login";
                    if (btn.Text.Equals("登出"))
                        btn.Text = "登录";
                    string msg = "{\"user_id\": " + user_id + ", \"name\": \"" + user_name + "\", \"action\": \"Logout\"}";
                    log.Info(msg);
                    //SanwaUtil.addActionLog("Authority", "Logout", user_id);// add record to log_system_action

                }
            }
            catch
            {
                logger.Error("UpdateLoginInfo: Update fail.");
            }
        }

        //public static void UpdateFuncGroupEnable(string Group)
        //{
        //    //set SQL
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("\n SELECT ugf.user_group_id, ugf.fun_id, ugf.active, f.fun_form, f.fun_ref");
        //    sql.Append("\n   FROM user_group_function ugf");
        //    sql.Append("\n   LEFT JOIN function f");
        //    sql.Append("\n     ON ugf.fun_id = f.fun_id");
        //    sql.Append("\n  WHERE user_group_id = @user_group_id ");
        //    //set parameter
        //    Dictionary<string, object> param = new Dictionary<string, object>();
        //    param.Add("@user_group_id", Group);
        //    //Query
        //    DBUtil dBUtil = new DBUtil();
        //    DataTableReader rs = dBUtil.GetDataReader(sql.ToString(), param);
        //    if (rs != null)
        //    {
        //        string fun_form = "";
        //        string fun_ref = "";
        //        string active = "";
        //        while (rs.Read())
        //        {
        //            fun_form = (string)rs["fun_form"];
        //            fun_ref = (string)rs["fun_ref"];
        //            active = (string)rs["active"];
        //            UpdateFuncAssign(fun_form, fun_ref, active);
        //        }
        //        rs.Close();
        //    }
        //}

        public static void UpdateFuncGroupEnable(string Group)
        {



            foreach (UserGroupFunction each in UserGroupFunction.Get(Group))
            {
                FunctionGroup fg = FunctionGroup.Get(each.functionId);
                UpdateFuncAssign(fg.form, fg.reference, each.active);
            }

        }



        public static void UpdateFuncAssign(string Form, string Control, bool active)
        {
            try
            {
                Form form = Application.OpenForms[Form];

                if (form == null)
                    return;

                if (form.InvokeRequired)
                {
                    UpdateFuncEnable_D ph = new UpdateFuncEnable_D(UpdateFuncAssign);
                    form.BeginInvoke(ph, Form, Control, active);
                }
                else
                {
                    //20190531 Add tab controller 移除頁面功能
                    if (Control.IndexOf(".") > 0)
                    {
                        string tabCtrlName = Control.Substring(0, Control.IndexOf("."));
                        TabControl control = form.Controls.Find(tabCtrlName, true).FirstOrDefault() as TabControl;
                        string tabPageName = Control.Substring(Control.IndexOf(".") + 1);
                        tabPages.TryGetValue(tabPageName, out TabPage foo);
                        if (control != null && foo != null)
                        {
                            if (active)
                            {

                                if (!control.Contains(foo))
                                {
                                    control.TabPages.Add(foo);
                                }
                            }
                            else
                            {
                                if (control.Contains(foo))
                                {
                                    control.TabPages.Remove(foo);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Control not found. Form:" + Form + " Control:" + tabPageName + " active" + active);
                        }
                    }
                    else
                    {
                        Control control = form.Controls.Find(Control, true).FirstOrDefault() as Control;
                        if (control != null)
                        {
                            
                               control.Enabled = active;
                                   
                            
                        }
                        else
                        {
                            MessageBox.Show("Control not found. Form:" + Form + " Control:" + Control + " active" + active);
                        }
                    }


                }
            }
            catch
            {
                logger.Error("UpdateFuncAssign: Update fail. Form:" + Form + " Control:" + Control + " active" + active);
            }
        }

       
    }
}
