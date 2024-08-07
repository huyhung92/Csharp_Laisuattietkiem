using System.Globalization;

namespace Csharp_Laisuattietkiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (double i = 0.01; i <= 0.101; i += 0.001)
            {
                cbxlaisuat.Items.Add(String.Format("{0:P1}", Math.Round(i, 3)));
            }
            txtsotien.Text = "10000000";
            cbxlaisuat.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Clear();
            double soTien = Convert.ToInt64(txtsotien.Text);
            int soNam = (int)numsonam.Value;
            double laisuat = double.Parse(cbxlaisuat.SelectedItem.ToString().Replace("%", "")) / 100;

            for (int i = 1; i <= soNam; i++)
            {
                double tienlai = soTien + laisuat;
                lsbketqua.Items.Add("Năm " + i + "Tiền gốc: " + soTien.ToString("N", new CultureInfo("en-US")) + " - Lãi: " + tienlai.ToString("N", new CultureInfo("en-US")));
                soTien += tienlai;
            }
        }
    }
}
