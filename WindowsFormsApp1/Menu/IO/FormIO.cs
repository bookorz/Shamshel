using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TransferControl.Digital_IO.Config;
using TransferControl.Engine;

namespace Adam.Menu.IO
{
    public partial class FormIO : Adam.Menu.FormFrame
    {
        public FormIO()
        {
            InitializeComponent();
        }

        private void FormIO_Load(object sender, EventArgs e)
        {
            foreach(ParamConfig each in RouteControl.Instance.DIO.GetDIOSetting())
            {
                InsertDIO(each.Parameter,each.Type);
            }
        }
        int currentY_I = 15;
        int currentY_O = 15;
        private Label InsertDIO(string Name, string Type)
        {
            Form form = Application.OpenForms["FormIO"];
            Panel P;
            Label value = new Label();
            int currentY = 0;
            if (Type.ToUpper().Equals("DIN"))
            {
                currentY = currentY_I;
                currentY_I += 30;
                P = form.Controls.Find("Digital_I_List", true).FirstOrDefault() as Panel;
            }
            else
            {
                currentY = currentY_O;
                currentY_O += 30;
                P = form.Controls.Find("Digital_O_List", true).FirstOrDefault() as Panel;
            }

            value.Name = Name + "_" + Type;
            value.Text = "■";//"●"
                             //value.ForeColor = Color.Red;
            value.ForeColor = Color.DimGray;//預設為未知
            value.Location = new System.Drawing.Point(0, currentY);
            value.Font = new Font(new FontFamily(value.Font.Name), 16, value.Font.Style);
            //value.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            value.Size = new System.Drawing.Size(20, 20);
            P.Controls.Add(value);

            Label id = new Label();
            id.Text = Name;
            id.Location = new System.Drawing.Point(20, currentY);
            if (Type.ToUpper().Equals("DIN"))
            {
                id.Size = new System.Drawing.Size(330, 20);
            }
            else
            {
                id.Size = new System.Drawing.Size(180, 20);
            }
            //id.Font = new Font(new FontFamily(id.Font.Name), 12, id.Font.Style);
            id.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //hint.SetToolTip(id, desc);
            P.Controls.Add(id);

            if (Type.ToUpper().Equals("DOUT"))
            {
                Button On = new Button();
                On.Text = "On";

                On.Name = Name + "_" + Type + "_ON";
                //On.Name = AddressNo + "_" + ID + "_" + Type + "_ON";
                On.Click += On_IO_Click;
                On.Location = new System.Drawing.Point(200, currentY);
                //On.Font = new Font(new FontFamily(On.Font.Name), 9, On.Font.Style);
                On.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                On.Size = new System.Drawing.Size(38, 25);
                P.Controls.Add(On);

                Button Off = new Button();
                Off.Text = "Off";

                Off.Name = Name + "_" + Type + "_OFF";
                //Off.Name = AddressNo + "_" + ID + "_" + Type + "_OFF";
                Off.Click += On_IO_Click;
                Off.Location = new System.Drawing.Point(240, currentY);
                //Off.Font = new Font(new FontFamily(On.Font.Name), 9, On.Font.Style);
                Off.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Off.Size = new System.Drawing.Size(38, 25);
                P.Controls.Add(Off);
            }

            return value;
        }
        private void On_IO_Click(object sender, EventArgs e)
        {
            string key = ((Button)sender).Name;
            string value = key.Substring(key.LastIndexOf("_") + 1);
            key = key.Substring(0, key.LastIndexOf("_"));
            key = key.Substring(0, key.LastIndexOf("_"));
            switch (value.ToUpper())
            {
                case "ON":
                    RouteControl.Instance.DIO.SetIO(key, "TRUE");
                    break;
                case "OFF":
                    RouteControl.Instance.DIO.SetIO(key, "FALSE");
                    break;
            }
        }
    }
}
