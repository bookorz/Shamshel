﻿using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Adam.UI_Update.DifferentialMonitor
{

    class DifferentialMonitorUpdate
    {

        static ILog logger = LogManager.GetLogger(typeof(DifferentialMonitorUpdate));
        delegate void UpdateDIO(string Parameter, string Value);
        delegate void UpdateValue(string Value);
        delegate void UpdateUI(bool Enable);
        static List<double> tmpDataCol = new List<double>();

        public static void EnableUI(bool Enable)
        {
            try
            {
                Form form = Application.OpenForms["FormDifferentialMonitor"];

                if (form == null)
                    return;

                GroupBox ctrl = form.Controls.Find("ControlGrop", true).FirstOrDefault() as GroupBox;

                if (ctrl == null)
                    return;

                if (ctrl.InvokeRequired)
                {
                    UpdateUI ph = new UpdateUI(EnableUI);
                    ctrl.BeginInvoke(ph, Enable);
                }
                else
                {
                    ctrl.Enabled = Enable;
                }


            }
            catch (Exception e)
            {
                logger.Error("UpdateFFU: Update fail. err:" + e.StackTrace);
            }
        }
        public static void UpdateFFU(string Value)
        {
            try
            {
                Form form = Application.OpenForms["FormDifferentialMonitor"];

                if (form == null)
                    return;

                Label rpm = form.Controls.Find("FFU_rpm_lb", true).FirstOrDefault() as Label;

                if (rpm == null)
                    return;

                if (rpm.InvokeRequired)
                {
                    UpdateValue ph = new UpdateValue(UpdateFFU);
                    rpm.BeginInvoke(ph,  Value);
                }
                else
                {
                    rpm.Text = Value;
                }


            }
            catch (Exception e)
            {
                logger.Error("UpdateFFU: Update fail. err:" + e.StackTrace);
            }
        }
        public static void UpdateChart(string Parameter, string Value)
        {
            try
            {
                Form form = Application.OpenForms["FormDifferentialMonitor"];

                if (form == null)
                    return;

                Chart chart = form.Controls.Find("chartDifferential", true).FirstOrDefault() as Chart;

                if (chart == null)
                    return;

                if (chart.InvokeRequired)
                {
                    UpdateDIO ph = new UpdateDIO(UpdateChart);
                    chart.BeginInvoke(ph, Parameter, Value);
                }
                else
                {
                    double val = 0;
                    if (double.TryParse(Value, out val))
                    {
                        tmpDataCol.Add(val);
                        if (tmpDataCol.Count > 100)
                        {
                            tmpDataCol.RemoveAt(0);
                        }
                        //標題 最大數值
                        Series series1 = new Series("壓力差", 10);
                        series1.Color = Color.Red;
                        series1.BorderWidth = 5;
                        series1.ChartType = SeriesChartType.Line;
                       // series1.IsValueShownAsLabel = true;
                        
                        for (int i =0; i<tmpDataCol.Count;i++)
                        {
                            series1.Points.AddXY(i, tmpDataCol[i]);
                        }
                        chart.Series.Clear();
                        chart.Series.Add(series1);
                        chart.ChartAreas[0].AxisY.Maximum = 5;
                        chart.ChartAreas[0].AxisY.Minimum = 0;
                        
                        //chart.Titles.Add("壓差計數值");
                        Label CurrentVal = form.Controls.Find("CurrentVal_lb", true).FirstOrDefault() as Label;
                        if (CurrentVal != null)
                        {
                            CurrentVal.Text = Value;
                        }
                    }
                    else
                    {
                        logger.Error("UpdateChart: Value "+Value+" parse fail.");
                    }
                }


            }
            catch (Exception e)
            {
                logger.Error("UpdateChart: Update fail. err:" + e.StackTrace);
            }
        }
    }
}
