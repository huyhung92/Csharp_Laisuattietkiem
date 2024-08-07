namespace Csharp_Laisuattietkiem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtsotien = new TextBox();
            numsonam = new NumericUpDown();
            btntinh = new Button();
            labelketqua = new Label();
            lsbketqua = new ListBox();
            cbxlaisuat = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numsonam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(463, 35);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(449, 45);
            label1.TabIndex = 0;
            label1.Text = "Tính Lãi Suất Tiết Kiệm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(135, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 1;
            label2.Text = "Số Tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(135, 237);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 2;
            label3.Text = "Lãi Suất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(135, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(115, 24);
            label4.TabIndex = 3;
            label4.Text = "Số Năm Gửi";
            // 
            // txtsotien
            // 
            txtsotien.Font = new Font("Segoe UI", 10F);
            txtsotien.Location = new Point(349, 174);
            txtsotien.Margin = new Padding(4);
            txtsotien.Name = "txtsotien";
            txtsotien.Size = new Size(630, 30);
            txtsotien.TabIndex = 4;
            // 
            // numsonam
            // 
            numsonam.Font = new Font("Segoe UI", 10F);
            numsonam.Location = new Point(349, 289);
            numsonam.Margin = new Padding(6);
            numsonam.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numsonam.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numsonam.Name = "numsonam";
            numsonam.Size = new Size(630, 30);
            numsonam.TabIndex = 7;
            numsonam.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btntinh
            // 
            btntinh.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btntinh.Location = new Point(532, 360);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(325, 48);
            btntinh.TabIndex = 8;
            btntinh.Text = "TÍNH";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // labelketqua
            // 
            labelketqua.AutoSize = true;
            labelketqua.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelketqua.Location = new Point(142, 431);
            labelketqua.Name = "labelketqua";
            labelketqua.Size = new Size(94, 28);
            labelketqua.TabIndex = 9;
            labelketqua.Text = "Kết Quả";
            // 
            // lsbketqua
            // 
            lsbketqua.FormattingEnabled = true;
            lsbketqua.ItemHeight = 28;
            lsbketqua.Location = new Point(142, 479);
            lsbketqua.Name = "lsbketqua";
            lsbketqua.Size = new Size(785, 284);
            lsbketqua.TabIndex = 10;
            // 
            // cbxlaisuat
            // 
            cbxlaisuat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxlaisuat.FormattingEnabled = true;
            cbxlaisuat.Location = new Point(349, 225);
            cbxlaisuat.Name = "cbxlaisuat";
            cbxlaisuat.Size = new Size(630, 36);
            cbxlaisuat.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 788);
            Controls.Add(cbxlaisuat);
            Controls.Add(lsbketqua);
            Controls.Add(labelketqua);
            Controls.Add(btntinh);
            Controls.Add(numsonam);
            Controls.Add(txtsotien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numsonam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtsotien;
        private NumericUpDown numsonam;
        private Button btntinh;
        private Label labelketqua;
        private ListBox lsbketqua;
        private ComboBox cbxlaisuat;
    }
}
