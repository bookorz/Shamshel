using Adam.UI_Update.Barcode;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TransferControl.Config;
using TransferControl.Engine;
using TransferControl.Management;
using TransferControl.Operation;

namespace Adam.Menu.WaferMapping
{
    public partial class FormWaferMapping : Adam.Menu.FormFrame
    {
        static ILog logger = LogManager.GetLogger(typeof(FormWaferMapping));

        public FormWaferMapping()
        {
            InitializeComponent();
        }

        private void FormWaferMapping_Load(object sender, EventArgs e)
        {
            Form form = this;
            foreach (Node port in NodeManagement.GetLoadPortList())
            {
                for (int i = 1; i <= 25; i++)
                {
                    Label present = form.Controls.Find(port.Name + "_Slot_" + i.ToString(), true).FirstOrDefault() as Label;
                    if (present != null)
                    {
                        switch (port.CarrierType.ToUpper())
                        {
                            case "FOSB":
                            case "FOUP":
                                present.Visible = true;
                                break;
                            case "OPEN":
                                if (i > 13)
                                {
                                    present.Visible = false;
                                }
                                else
                                {
                                    present.Visible = true;
                                }
                                break;
                        }

                    }
                }

            }
            Node al2 = NodeManagement.Get("ALIGNER02");
            if (al2 != null)
            {
                OCR02_pl.Visible = true;
                Aligner02_pl.Visible = true;
            }

        }
        private void RefreshMap()
        {
            fromPort = "";
            fromSlot = "";
            toPort = "";
            toSlot = "";
            Form form = this;
            foreach (Node p in NodeManagement.GetLoadPortList())//��s�Ҧ��ت��aslot�Q�諸���A
            {
                if (p.Enable && p.IsMapping)
                {
                    foreach (Job eachSlot in p.JobList.Values)
                    {
                        if (!eachSlot.MapFlag && !eachSlot.ErrPosition)//����slot
                        {

                            Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                            if (present != null)
                            {
                                if (eachSlot.ReservePort.Equals("") && eachSlot.ReserveSlot.Equals(""))
                                {//�S�Q��
                                    present.BackColor = Color.DimGray;
                                    present.ForeColor = Color.White;
                                }
                                else
                                {//�w�Q��
                                    present.BackColor = Color.Brown;
                                    present.ForeColor = Color.White;
                                }
                            }
                        }
                        if (eachSlot.MapFlag && !eachSlot.ErrPosition)//���wafer
                        {
                            Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                            if (present != null)
                            {
                                if (!eachSlot.Destination.Equals("") && !eachSlot.DestinationSlot.Equals("") /*&& (!eachSlot.Destination.Equals(eachSlot.Position) && !eachSlot.DestinationSlot.Equals(eachSlot.Slot))*/)
                                {//�w�Q��
                                    present.BackColor = Color.Brown;
                                    present.ForeColor = Color.White;
                                }
                                else
                                {//�S�Q��
                                    present.BackColor = Color.Green;
                                    present.ForeColor = Color.White;
                                }

                            }
                        }
                    }
                }
            }
        }


        private Node SearchLoadport()
        {
            Node result = null;
            var AvailableWafers = from job in JobManagement.GetJobList()
                                  where job.NeedProcess
                                  orderby job.AssignTime
                                  select job;
            if (AvailableWafers.Count() != 0)
            {
                result = NodeManagement.Get(AvailableWafers.First().Position);
            }
            return result;
        }
        private void Assign_finish_btn_Click(object sender, EventArgs e)
        {

            if (XfeCrossZone.Running)
            {
                MessageBox.Show("�Х���������l��");
            }
            else
            {
                Node Loadport = SearchLoadport();
                if (Loadport == null)
                {
                    MessageBox.Show("�䤣��" + Loadport.Name);
                }
                else
                {

                    if (!FormMain.xfe.Start(Loadport.Name))
                    {
                        MessageBox.Show("xfe.Start fail!");
                    }
                    else
                    {
                        this.Enabled = false;
                        fromPort = "";
                        fromSlot = "";
                        toPort = "";
                        toSlot = "";

                    }
                }
            }


        }
        public static string fromPort = "";
        public static string fromSlot = "";
        public static string toPort = "";
        public static string toSlot = "";
        bool bypass = true;
        private void Slot_Click(object sender, EventArgs e)
        {
            Label Slot_Label = (Label)sender;
            string PortName = Slot_Label.Name.Substring(0, Slot_Label.Name.IndexOf("_Slot")).ToUpper();
            string SlotNo = Slot_Label.Name.Substring(Slot_Label.Name.IndexOf("_Slot") + 6);
            Node port = NodeManagement.Get(PortName);
            Job s;
            if (!port.JobList.TryGetValue(SlotNo, out s))
            {
                return;
            }

            if ((PortName.Equals(fromPort) && SlotNo.Equals(fromSlot) && toPort.Equals("") && toSlot.Equals("")) || (fromPort.Equals("") && fromSlot.Equals("")))
            {//��ܨӷ�slot
                if (s.MapFlag && !s.ErrPosition)
                {
                    if (Slot_Label.BackColor == Color.SkyBlue)
                    {// ������ܨӷ�slot                     
                        if (s.Destination.Equals("") && s.DestinationSlot.Equals(""))
                        {//�٨S��
                            Slot_Label.BackColor = Color.Green;
                            Slot_Label.ForeColor = Color.White;
                        }
                        else
                        {//�w��
                            Slot_Label.BackColor = Color.Brown;
                            Slot_Label.ForeColor = Color.White;
                        }
                        fromPort = "";
                        fromSlot = "";

                        Form form = Application.OpenForms["FormWaferMapping"];
                        foreach (Node p in NodeManagement.GetLoadPortList())//��s�Ҧ��ت��aslot�Q�諸���A
                        {
                            if (p.Enable && p.IsMapping)
                            {
                                foreach (Job eachSlot in p.JobList.Values)
                                {
                                    if (!eachSlot.MapFlag && !eachSlot.ErrPosition)//����slot
                                    {

                                        Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                        if (present != null)
                                        {
                                            if (eachSlot.ReservePort.Equals("") && eachSlot.ReserveSlot.Equals(""))
                                            {//�S�Q��
                                                present.BackColor = Color.DimGray;
                                                present.ForeColor = Color.White;
                                            }
                                            else
                                            {//�w�Q��
                                                present.BackColor = Color.Brown;
                                                present.ForeColor = Color.White;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {// ��ܨӷ�
                        Form form = Application.OpenForms["FormWaferMapping"];
                        Job lastSlot;
                        if (!bypass)
                        {
                            foreach (Node p in NodeManagement.GetLoadPortList()) //�аO����諸��m
                            {
                                if (p.Enable && p.IsMapping)
                                {
                                    foreach (Job eachSlot in p.JobList.Values)
                                    {
                                        if (eachSlot.MapFlag && !eachSlot.ErrPosition)
                                        {
                                            //�u��ѤU���W���A�аO�������Wafer
                                            if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out lastSlot))
                                            {
                                                if ((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals("")))
                                                {
                                                    Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                                    if (present != null)
                                                    {//�⤣�����slot�аO
                                                        present.ForeColor = Color.Red;
                                                    }
                                                }
                                            }
                                        }

                                    }
                                }
                            }


                            //�P�_�ण���A�����N����
                            Node pt = NodeManagement.Get(PortName);

                            if (pt.JobList.TryGetValue((Convert.ToInt16(SlotNo) - 1).ToString(), out lastSlot))
                            {
                                if ((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals("")))
                                {
                                    Label present = form.Controls.Find(pt.Name + "_Slot_" + SlotNo, true).FirstOrDefault() as Label;
                                    if (present != null)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                        //�аO��w�ӷ�
                        Slot_Label.BackColor = Color.SkyBlue;
                        Slot_Label.ForeColor = Color.White;
                        fromPort = PortName;
                        fromSlot = SlotNo;

                        foreach (Node p in NodeManagement.GetLoadPortList()) //�аO��񪺦�m
                        {
                            if (p.Enable && p.IsMapping)
                            {
                                foreach (Job eachSlot in p.JobList.Values)
                                {
                                    if (!eachSlot.MapFlag && !eachSlot.ErrPosition)
                                    {//����slot

                                        Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                        if (present != null)
                                        {

                                            if (eachSlot.ReservePort.Equals("") && eachSlot.ReserveSlot.Equals(""))
                                            {//�Ӫ�slot�S�Q�w��
                                                if (!bypass)
                                                {
                                                    Job nextSlot = null;
                                                    if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out nextSlot))
                                                    {
                                                        if (!nextSlot.ReservePort.Equals(""))
                                                        {
                                                            continue;//�P�_�O�_��q�W���U��SLOT�A����񪺸ܴN���аO
                                                        }
                                                    }
                                                }

                                                present.BackColor = Color.White;
                                                present.ForeColor = Color.Black;
                                            }
                                            else
                                            {//��slot�w�Q��w
                                                if (eachSlot.ReservePort.ToUpper().Equals(fromPort.ToUpper()) && eachSlot.ReserveSlot.ToUpper().Equals(fromSlot.ToUpper()))
                                                {//�Q�ثe��ܪ��ӷ��j�w
                                                    present.BackColor = Color.Yellow;
                                                    present.ForeColor = Color.Black;
                                                    toPort = eachSlot.Position;
                                                    toSlot = eachSlot.Slot;
                                                }
                                                else
                                                {//�Q��L�j�w
                                                    present.BackColor = Color.Brown;
                                                    present.ForeColor = Color.White;
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }

                }
            }
            else if ((PortName.Equals(toPort) && SlotNo.Equals(toSlot)) || (toPort.Equals("") && toSlot.Equals("")))
            {//select to
             //�P�_�i���i�H��
                Job lastSlot;

                Form form = Application.OpenForms["FormWaferMapping"];
                if (!bypass)
                {
                    Node pt = NodeManagement.Get(PortName);
                    //�u��ѤW���U��
                    if (pt.JobList.TryGetValue((Convert.ToInt16(SlotNo) - 1).ToString(), out lastSlot))
                    {
                        if (!lastSlot.ReservePort.Equals(""))
                        {
                            Label present = form.Controls.Find(pt.Name + "_Slot_" + SlotNo, true).FirstOrDefault() as Label;
                            if (present != null)
                            {
                                return;//�p�G�U����slot���F��A���椣����
                            }
                        }
                    }
                }
                if (!s.MapFlag && !s.ErrPosition)
                {
                    if (Slot_Label.BackColor == Color.Yellow)
                    {// ������ܥت��a
                        Slot_Label.BackColor = Color.White;
                        Slot_Label.ForeColor = Color.Black;

                        Node fPort = NodeManagement.Get(fromPort);
                        if (fPort != null)
                        {
                            Job fSlot;
                            if (fPort.JobList.TryGetValue(fromSlot, out fSlot))
                            {
                                fSlot.UnAssignPort();//�����j�w

                            }
                        }
                        if (!bypass)
                        {
                            Node tPort = NodeManagement.Get(toPort);
                            if (tPort != null)
                            {
                                Job tSlot;
                                if (tPort.JobList.TryGetValue((Convert.ToInt16(toSlot) + 1).ToString(), out tSlot))
                                {
                                    Label present = form.Controls.Find(toPort + "_Slot_" + (Convert.ToInt16(toSlot) + 1).ToString(), true).FirstOrDefault() as Label;
                                    if (!tSlot.MapFlag && !tSlot.ErrPosition && tSlot.ReservePort.Equals(""))
                                    {//�p�G�W�@�h�٨S�Q�����A�аO���i�Q��
                                        present.BackColor = Color.White;
                                        present.ForeColor = Color.Black;

                                    }
                                    else if (tSlot.MapFlag && !tSlot.ErrPosition && tSlot.Destination.Equals(""))
                                    {//�p�G�W�@�h�٨S�Q�����A�аO���i�Q��
                                        if (!tSlot.Slot.Equals(fromSlot) || !port.Name.ToUpper().Equals(fromPort))
                                        {
                                            present.BackColor = Color.Green;
                                            present.ForeColor = Color.White;
                                        }
                                    }
                                }
                            }
                        }
                        foreach (Node p in NodeManagement.GetLoadPortList())
                        {
                            if (p.Enable && p.IsMapping)
                            {
                                foreach (Job eachSlot in p.JobList.Values)
                                {
                                    if (eachSlot.MapFlag && !eachSlot.ErrPosition)
                                    {
                                        //�u��ѤU���W���A�аO�����Wafer
                                        if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out lastSlot))
                                        {
                                            Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                            if (present != null)
                                            {
                                                if (((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals(""))) && !bypass)
                                                {
                                                    //�U���@�hSlot���Q��A�h�аO�����i��
                                                    present.ForeColor = Color.Red;
                                                }
                                                else
                                                {  //�аO�i��
                                                    present.ForeColor = Color.White;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        toPort = "";
                        toSlot = "";
                    }
                    else if (s.ReservePort.Equals("") && s.ReserveSlot.Equals(""))
                    {// not select
                        Slot_Label.BackColor = Color.Yellow;
                        Slot_Label.ForeColor = Color.Black;

                        toPort = PortName;
                        toSlot = SlotNo;
                        Node fPort = NodeManagement.Get(fromPort);
                        if (fPort != null)
                        {
                            Job fSlot;
                            if (fPort.JobList.TryGetValue(fromSlot, out fSlot))
                            {
                                fSlot.AssignPort(toPort, toSlot);
                                Label present = form.Controls.Find(fromPort + "_Slot_" + fromSlot.ToString(), true).FirstOrDefault() as Label;
                                present.Text += "";
                            }
                        }
                        if (!bypass)
                        {
                            Node tPort = NodeManagement.Get(toPort);//�p�G�W�@�h�٨S�Q�����A�аO�����i�Q��
                            if (tPort != null)
                            {
                                Job tSlot;
                                if (tPort.JobList.TryGetValue((Convert.ToInt16(toSlot) + 1).ToString(), out tSlot))
                                {
                                    Label present = form.Controls.Find(toPort + "_Slot_" + (Convert.ToInt16(toSlot) + 1).ToString(), true).FirstOrDefault() as Label;
                                    if (!tSlot.MapFlag && !tSlot.ErrPosition && tSlot.ReservePort.Equals(""))
                                    {
                                        present.BackColor = Color.DimGray;
                                        present.ForeColor = Color.White;

                                    }
                                    else if (tSlot.MapFlag && !tSlot.ErrPosition && tSlot.Destination.Equals(""))
                                    {
                                        present.BackColor = Color.Green;
                                        present.ForeColor = Color.White;
                                    }
                                }
                            }

                            foreach (Node p in NodeManagement.GetLoadPortList())
                            {
                                if (p.Enable && p.IsMapping)
                                {
                                    foreach (Job eachSlot in p.JobList.Values)
                                    {
                                        if (p.Name.ToUpper().Equals(fromPort.ToUpper()) && eachSlot.Slot.Equals(fromSlot))
                                        {
                                            continue;
                                        }
                                        if (eachSlot.MapFlag && !eachSlot.ErrPosition)
                                        {
                                            //�u��ѤU���W���A�аO�����Wafer
                                            if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out lastSlot))
                                            {
                                                Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                                if (present != null)
                                                {
                                                    if (((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals(""))))
                                                    {

                                                        present.ForeColor = Color.Red;
                                                    }
                                                    else
                                                    {
                                                        present.ForeColor = Color.White;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (s.MapFlag && !s.ErrPosition && !(PortName.Equals(fromPort) && SlotNo.Equals(fromSlot)))
            {//�w�g�粒�ӷ��ڥت���A�I�t�@�Өӷ�
             //reset all from slot 
                Job lastSlot;
                Form form = Application.OpenForms["FormWaferMapping"];
                if (!bypass)
                {
                    //�P�_�ण���
                    Node pt = NodeManagement.Get(PortName);
                    //�u��ѤU���W���A�аO�����Wafer
                    if (pt.JobList.TryGetValue((Convert.ToInt16(SlotNo) - 1).ToString(), out lastSlot))
                    {
                        if ((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals("")))
                        {
                            Label present = form.Controls.Find(pt.Name + "_Slot_" + SlotNo, true).FirstOrDefault() as Label;
                            if (present != null)
                            {
                                return;
                            }
                        }
                    }
                }

                foreach (Node p in NodeManagement.GetLoadPortList())
                {
                    if (p.Enable && p.IsMapping)
                    {
                        foreach (Job eachSlot in p.JobList.Values)
                        {
                            if (eachSlot.MapFlag && !eachSlot.ErrPosition)
                            {

                                Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                if (present != null)
                                {
                                    if (eachSlot.Destination.Equals("") && eachSlot.DestinationSlot.Equals(""))
                                    {
                                        present.BackColor = Color.Green;
                                        if (!bypass)
                                        {
                                            //�u��ѤU���W���A�аO�����Wafer
                                            if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out lastSlot))
                                            {

                                                if (present != null)
                                                {
                                                    if (((lastSlot.MapFlag && lastSlot.Destination.Equals("")) || (!lastSlot.MapFlag && !lastSlot.ReservePort.Equals(""))) && !bypass)
                                                    {

                                                        present.ForeColor = Color.Red;
                                                    }
                                                    else
                                                    {
                                                        present.ForeColor = Color.White;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        present.BackColor = Color.Brown;
                                        present.ForeColor = Color.White;
                                    }
                                }
                            }
                        }
                    }
                }
                if (!s.Destination.Equals("") && !s.DestinationSlot.Equals(""))//��쪺�O�w�j�w��slot
                {
                    Slot_Label.BackColor = Color.SkyBlue;
                    Slot_Label.ForeColor = Color.White;
                    fromPort = PortName;
                    fromSlot = SlotNo;
                    //Form form = Application.OpenForms["FormWaferMapping"];
                    foreach (Node p in NodeManagement.GetLoadPortList())
                    {
                        if (p.Enable && p.IsMapping)
                        {
                            foreach (Job eachSlot in p.JobList.Values)
                            {
                                if (!eachSlot.MapFlag && !eachSlot.ErrPosition)
                                {//����slot

                                    Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                    if (present != null)
                                    {

                                        if (eachSlot.ReservePort.Equals("") && eachSlot.ReserveSlot.Equals(""))
                                        {//�o�Ӫ�slot�٨S�Q�j�w
                                            Job nextSlot;
                                            if (p.JobList.TryGetValue((Convert.ToInt16(eachSlot.Slot) - 1).ToString(), out nextSlot))
                                            {
                                                Form tform = Application.OpenForms["FormWaferMapping"];
                                                //Label tpresent = form.Controls.Find(p.Name + "_Slot_" + nextSlot.Slot, true).FirstOrDefault() as Label;
                                                if (!nextSlot.ReservePort.Equals("") && !bypass)
                                                {//�U�hslot�w�Q�j�w

                                                    if (nextSlot.ReservePort.Equals(""))
                                                    {

                                                        present.BackColor = Color.White;
                                                        present.ForeColor = Color.Black;

                                                    }
                                                    else
                                                    {//�U�h�w�Q�j�w�A������

                                                        present.BackColor = Color.DimGray;
                                                        present.ForeColor = Color.White;
                                                    }

                                                }
                                                else
                                                {//bypass
                                                    present.BackColor = Color.White;
                                                    present.ForeColor = Color.Black;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (eachSlot.ReservePort.ToUpper().Equals(fromPort.ToUpper()) && eachSlot.ReserveSlot.ToUpper().Equals(fromSlot.ToUpper()))
                                            {
                                                present.BackColor = Color.Yellow;
                                                present.ForeColor = Color.Black;
                                                toPort = eachSlot.Position;
                                                toSlot = eachSlot.Slot;
                                            }
                                            else
                                            {
                                                present.BackColor = Color.Brown;
                                                present.ForeColor = Color.White;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    fromPort = PortName;
                    fromSlot = SlotNo;
                    toPort = "";
                    toSlot = "";


                    //�b�w�g��ܨӷ��P�ت���A�I��s���ӷ�slot
                    Slot_Label.BackColor = Color.SkyBlue;
                    Slot_Label.ForeColor = Color.White;
                    fromPort = PortName;
                    fromSlot = SlotNo;
                    // Form form = Application.OpenForms["FormWaferMapping"];
                    foreach (Node p in NodeManagement.GetLoadPortList())
                    {
                        if (p.Enable && p.IsMapping)
                        {
                            foreach (Job eachSlot in p.JobList.Values)
                            {
                                if (!eachSlot.MapFlag && !eachSlot.ErrPosition)
                                {//���Ū�slot

                                    Label present = form.Controls.Find(p.Name + "_Slot_" + eachSlot.Slot, true).FirstOrDefault() as Label;
                                    if (present != null)
                                    {
                                        if (eachSlot.ReservePort.Equals("") && eachSlot.ReserveSlot.Equals(""))
                                        {//��slot�٨S�Q�j�w
                                            Form tform = Application.OpenForms["FormWaferMapping"];
                                            Label tpresent = form.Controls.Find(p.Name + "_Slot_" + (Convert.ToInt16(eachSlot.Slot) + 1).ToString(), true).FirstOrDefault() as Label;
                                            Job tSlot;
                                            if (p.JobList.TryGetValue(toSlot, out tSlot) && !bypass)
                                            {

                                                if (tSlot.ReservePort.Equals(""))//�ˬd�U�hslot�O�_�w�Q�j�w�A���ܥثeslot����A
                                                {
                                                    //���Q�j�w
                                                    tpresent.BackColor = Color.White;
                                                    tpresent.ForeColor = Color.Black;

                                                }
                                                else
                                                {
                                                    //�w�Q�j�w
                                                    tpresent.BackColor = Color.DimGray;
                                                    tpresent.ForeColor = Color.White;
                                                }
                                            }

                                        }
                                        else
                                        {
                                            present.BackColor = Color.Brown;
                                            present.ForeColor = Color.White;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        private void AutoAssign_btn_Click(object sender, EventArgs e)
        {
            if (Source_cb.Text.Equals(To_cb.Text))
            {
                MessageBox.Show("Not support assign to the same loadport");
                return;
            }

            Node Loadport = NodeManagement.Get(Source_cb.Text);
            Node UnLoadport = NodeManagement.Get(To_cb.Text);
            if (Loadport == null)
            {
                MessageBox.Show("Source loadport not found!");
                return;
            }
            if (UnLoadport == null)
            {
                MessageBox.Show("To loadport not found!");
                return;
            }
            var LD_Jobs = (from wafer in Loadport.JobList.Values
                          where wafer.MapFlag && !wafer.ErrPosition && wafer.Destination.Equals("")                         
                          select wafer).OrderByDescending(x => Convert.ToInt16(x.Slot));
            if (Recipe.Get(SystemConfig.Get().CurrentRecipe).get_slot_order.Equals("BOTTOM_UP"))
            {
                LD_Jobs = (from wafer in Loadport.JobList.Values
                           where wafer.MapFlag && !wafer.ErrPosition && wafer.Destination.Equals("")
                           select wafer).OrderBy(x => Convert.ToInt16(x.Slot));
            }

            int assignCnt = LD_Jobs.Count();


            bool isAssign = false;

            var ULD_Jobs = (from Slot in UnLoadport.JobList.Values
                            where !Slot.MapFlag && !Slot.ErrPosition && !Slot.IsAssigned
                            select Slot).OrderByDescending(x => Convert.ToInt16(x.Slot));
            if (Recipe.Get(SystemConfig.Get().CurrentRecipe).put_slot_order.Equals("BOTTOM_UP"))
            {
                ULD_Jobs = (from Slot in UnLoadport.JobList.Values
                            where !Slot.MapFlag && !Slot.ErrPosition && !Slot.IsAssigned
                            select Slot).OrderBy(x => Convert.ToInt16(x.Slot));
            }

            foreach (Job wafer in LD_Jobs)
            {//�ˬdLD���Ҧ�WAFER

                isAssign = false;
                foreach (Job Slot in ULD_Jobs)
                {//�j�M�Ҧ�FOSB Slot �����     
                    if (Recipe.Get(SystemConfig.Get().CurrentRecipe).manual_put_constrict.Equals("1") && UnLoadport.CheckPreviousPresence(Slot.Slot) && Recipe.Get(SystemConfig.Get().CurrentRecipe).put_slot_order.Equals("TOP_DOWN"))
                    {//�U�@�h�����ҥH�����
                        Slot.Locked = true;
                    }
                    else if (Recipe.Get(SystemConfig.Get().CurrentRecipe).manual_put_constrict.Equals("2") && UnLoadport.CheckForwardPresence(Slot.Slot) && Recipe.Get(SystemConfig.Get().CurrentRecipe).put_slot_order.Equals("TOP_DOWN"))
                    {//�U��Ҧ������঳��
                        Slot.Locked = true;
                    }
                    else
                    {
                        wafer.NeedProcess = true;
                        wafer.ProcessFlag = false;
                        wafer.AssignPort(UnLoadport.Name, Slot.Slot);
                        isAssign = true;

                        Slot.IsAssigned = true;
                        logger.Debug("Assign booktest2 from " + Loadport.Name + " slot:" + wafer.Slot + " to " + UnLoadport.Name + " slot:" + Slot.Slot);

                        break;
                    }
                }
                if (!isAssign)
                {
                    break;
                }
            }
            if (assignCnt != 0)
            {

                LD_Jobs = (from wafer in Loadport.JobList.Values
                               where wafer.NeedProcess && !wafer.IsReversed
                               select wafer).OrderByDescending(x => Convert.ToInt16(x.Slot));
                if (Recipe.Get(SystemConfig.Get().CurrentRecipe).get_slot_order.Equals("BOTTOM_UP"))
                {
                    LD_Jobs = (from wafer in Loadport.JobList.Values
                               where wafer.NeedProcess && !wafer.IsReversed
                               select wafer).OrderBy(x => Convert.ToInt16(x.Slot));
                }
                
                Node Rbt = NodeManagement.Get("ROBOT01");
                if (!Recipe.Get(SystemConfig.Get().CurrentRecipe).put_slot_order.Equals(Recipe.Get(SystemConfig.Get().CurrentRecipe).get_slot_order))
                {
                    if (Rbt.RArmActive && Rbt.LArmActive && Rbt.DoubleArmActive)
                    {
                        for (int i = 1; i < LD_Jobs.Count(); i = i + 2)
                        {//���s�Ƨǥت��afor��Arm
                            Job upper = LD_Jobs.ToList()[i];
                            Job lower = LD_Jobs.ToList()[i - 1];
                            if (upper.Destination.Equals(lower.Destination) && upper.NeedProcess && lower.NeedProcess && Math.Abs(Convert.ToInt16(upper.DestinationSlot) - Convert.ToInt16(lower.DestinationSlot)) == 1)
                            {//�ت��aSlot�۾F �~�i��
                                string swapDes = upper.Destination;
                                string swapSlot = upper.DestinationSlot;
                                upper.AssignPort(lower.Destination, lower.DestinationSlot);
                                lower.AssignPort(swapDes, swapSlot);
                                logger.Debug("Reverse booktest2 from " + Loadport.Name + " slot:" + upper.Slot + " to " + upper.Destination + " slot:" + upper.DestinationSlot);
                                logger.Debug("Reverse booktest2 from " + Loadport.Name + " slot:" + lower.Slot + " to " + upper.Destination + " slot:" + lower.DestinationSlot);
                                logger.Debug("Reverse booktest2 ---------- ");
                                
                            }
                        }
                        foreach(Job each in Loadport.JobList.Values)
                        {
                            if (!each.Destination.Equals(""))
                            {
                                each.IsReversed = true;
                            }
                        }
                    }
                }
            }
            RefreshMap();

        }

        private void LOADPORT_FID_Click(object sender, EventArgs e)
        {
            string PortName = ((TextBox)sender).Name.Substring(0, ((TextBox)sender).Name.IndexOf("_"));
            Node port = NodeManagement.Get(PortName);
            if (port.OrgSearchComplete && port.Foup_Placement)
            {
                Barcodeupdate.UpdateLoadport(PortName, true);
            }
            else
            {
                if (port.OrgSearchComplete)
                {
                    MessageBox.Show("Please excute org search");
                }
                if (!port.Foup_Placement)
                {
                    MessageBox.Show("No Foup exist");
                }

            }
        }

        private void Unload_btn(object sender, EventArgs e)
        {
            string PortName = ((Button)sender).Name.Substring(0, ((Button)sender).Name.IndexOf("_"));
            Node port = NodeManagement.Get(PortName);
            if (port == null)
            {
                MessageBox.Show(PortName + " not found");
            }
            if (port.Enable)
            {
                FoupInfo foup = FoupInfo.Get(port.Name);
                if (foup != null)
                {
                    foup.SetAllUnloadTime(DateTime.Now);
                }
                else
                {
                    foup = new Adam.FoupInfo(SystemConfig.Get().CurrentRecipe, Global.currentUser, port.FoupID);
                    foreach (Job j in port.JobList.Values)
                    {
                        if (j.MapFlag && !j.ErrPosition)
                        {
                            int slot = Convert.ToInt16(j.Slot);
                            foup.record[slot - 1] = new Adam.waferInfo(port.Name, port.FoupID, j.Slot, j.FromPort, j.FromFoupID, j.FromPortSlot, j.ToPort, j.ToFoupID, j.ToPortSlot);
                            foup.record[slot - 1].SetStartTime(j.StartTime);
                            foup.record[slot - 1].setM12(j.OCR_M12_Result);
                            foup.record[slot - 1].setT7(j.OCR_T7_Result);
                            foup.record[slot - 1].SetEndTime(j.EndTime);
                            foup.record[slot - 1].SetLoadTime(port.LoadTime);
                            foup.record[slot - 1].SetUnloadTime(DateTime.Now);
                            foup.record[slot - 1].setM12Score(j.OCR_M12_Score);
                            foup.record[slot - 1].setT7Score(j.OCR_T7_Score);
                        }
                    }
                }
                foup.Save();
                ((Button)sender).Enabled = false;
                string TaskName = "LOADPORT_CLOSE_NOMAP";
                string Message = "";
                Dictionary<string, string> param1 = new Dictionary<string, string>();
                param1.Add("@Target", port.Name);
                TaskJobManagment.CurrentProceedTask tmpTask;
                RouteControl.Instance.TaskJob.Excute(Guid.NewGuid().ToString() + "Unload_btn", out Message, out tmpTask, TaskName, param1);
            }
            else
            {
                MessageBox.Show(PortName + " is disabled");
            }
        }
    }
}