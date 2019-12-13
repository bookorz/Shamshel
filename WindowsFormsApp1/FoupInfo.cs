﻿using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferControl.Config;

namespace Adam
{
    public class FoupInfo
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(FoupInfo));
        private string recipe_file;
        private string login_user;
        private string foup_id;
        private string file_name;
        public waferInfo[] record;
        static Dictionary<string, FoupInfo> TmpCol = new Dictionary<string, FoupInfo>(); 

        public FoupInfo(string recipe_file, string login_user, string foup_id,string PortName)
        {
            this.recipe_file = recipe_file;
            this.login_user = login_user;
            this.foup_id = foup_id;
            string date = System.DateTime.Now.ToString("yyyyMMdd");
            string time = System.DateTime.Now.ToString("HHmmss");
            this.file_name = SystemConfig.Get().EquipmentID + "_"+ PortName+"_" + foup_id + "_" + date + "_" + time + ".csv";
            record = new waferInfo[25];
        }
        public static FoupInfo Get(string portName)
        {
            FoupInfo result = null;
            TmpCol.TryGetValue(portName, out result);
            if (TmpCol.ContainsKey(portName))
            {
                TmpCol.Remove(portName);
            }
            return result;
        }
        public void SaveTmp(string portName)
        {
            if (TmpCol.ContainsKey(portName))
            {
                TmpCol.Remove(portName);
            }
            TmpCol.Add(portName, this);
        }
        public void Save()
        {
            try
            {
                
                //string fullPath = @"d:\log\foup\" + file_name;
                string path = SystemConfig.Get().FoupTxfLogPath.Replace("\\","/");
                path = path.EndsWith("/") ? path : path + "/" ;
                string date = System.DateTime.Now.ToString("yyyyMMdd");
                string fullPath = path + date  + "/" + file_name;
                FileInfo fi = new FileInfo(fullPath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                //StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
                StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                string data = "";
                //寫出列名稱
                data = "port,foup_id,slot,from_port,from_id,from_slot,to_port_id,to_id,to_slot,t7,t7_score,m12,m12_score,start_datedime,end_datetime,load_datetime,unload_datetime,recipe_file,login_user";
                sw.WriteLine(data);
                //寫出各行數據
                for (int i = 0; i < record.Length; i++)
                {
                    if (record[i] == null)
                    {
                        continue;
                    }
                    data = "";
                    string[] column = record[i].getData();
                    for (int j = 0; j < column.Length; j++)
                    {
                        string str = column[j] == null ? "" : column[j].ToString();
                        str = string.Format("\"{0}\"", str).Replace("\r", "\\r").Replace("\n", "\\n");
                        data += str;
                        data += ",";
                    }
                    data += recipe_file + ",";
                    data += login_user;
                    sw.WriteLine(data);
                }
                sw.Close();
                fs.Close();
                //Process.Start(fullPath);打開檔案
            }
            catch (Exception ex)
            {
                logger.Error(ex.StackTrace);
            }
        }
        public void SetAllUnloadTime(DateTime timeStamp)
        {
            foreach(waferInfo foo in record)
            {
                if (foo != null)
                {
                    foo.SetUnloadTime(timeStamp);
                }
            }
        }
    }
    public class waferInfo{
        string port = "";
        string foup_id = "";
        string slot = "";
        string from_port = "";
        string from_id = "";
        string from_slot = "";
        string to_port_id = "";
        string to_id = "";
        string to_slot = "";
        string t7 = "";
        string t7_score = "";
        string m12 = "";
        string m12_score = "";
        string start_datetime = "";
        string end_datetime = "";
        string load_datetime = "";
        string unload_datetime = "";

        public string[] getData()
        {
            return new string[] { port, foup_id, slot, from_port, from_id, from_slot, to_port_id, to_id, to_slot, t7, t7_score, m12, m12_score, start_datetime, end_datetime, load_datetime, unload_datetime };
        }
        public waferInfo(string port, string id, string slot, string from_port, string from_id, string from_slot, string to_port_id, string to_id, string to_slot)
        {
            this.port = port;
            this.foup_id = id;
            this.slot = slot;
            this.from_port = from_port;
            this.from_id = from_id;
            this.from_slot = from_slot;
            this.to_port_id = to_port_id;
            this.to_id = to_id;
            this.to_slot = to_slot;
        }

        public void SetStartTime(DateTime timeStamp)
        {
            this.start_datetime = timeStamp.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        public void SetEndTime(DateTime timeStamp)
        {
            this.end_datetime = timeStamp.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        public void setM12(string m12)
        {
            this.m12 = m12;
        }
        public void setM12Score(string m12_score)
        {
            this.m12_score = m12_score;
        }
        public void setT7(string t7)
        {
            this.t7 = t7;
        }
        public void setT7Score(string t7_score)
        {
            this.t7_score = t7_score;
        }
        public void SetLoadTime(DateTime timeStamp)
        {
            this.load_datetime = timeStamp.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        public void SetUnloadTime(DateTime timeStamp)
        {
            this.unload_datetime = timeStamp.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
    }
}
