namespace FrmClubRegistration
{
    partial class FrmClubRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClubRegistration));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            txtstuid = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtlname = new TextBox();
            txtfname = new TextBox();
            txtmname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtage = new TextBox();
            cmbgender = new ComboBox();
            cmbprogram = new ComboBox();
            groupBox1 = new GroupBox();
            dgvlist = new DataGridView();
            btnreg = new Button();
            btnupdate = new Button();
            btnrefresh = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 85);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 45);
            label2.Name = "label2";
            label2.Size = new Size(295, 20);
            label2.TabIndex = 1;
            label2.Text = "Fill in the details blank below to join the club";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 12);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 0;
            label1.Text = "Club Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 104);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 1;
            label3.Text = "Student ID:";
            // 
            // txtstuid
            // 
            txtstuid.Location = new Point(7, 128);
            txtstuid.Margin = new Padding(3, 4, 3, 4);
            txtstuid.Name = "txtstuid";
            txtstuid.Size = new Size(130, 27);
            txtstuid.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 104);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 104);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 104);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "Middle Name:";
            // 
            // txtlname
            // 
            txtlname.Location = new Point(158, 128);
            txtlname.Margin = new Padding(3, 4, 3, 4);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(130, 27);
            txtlname.TabIndex = 6;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(311, 128);
            txtfname.Margin = new Padding(3, 4, 3, 4);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(130, 27);
            txtfname.TabIndex = 7;
            // 
            // txtmname
            // 
            txtmname.Location = new Point(465, 128);
            txtmname.Margin = new Padding(3, 4, 3, 4);
            txtmname.Name = "txtmname";
            txtmname.Size = new Size(130, 27);
            txtmname.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 199);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 10;
            label8.Text = "Age:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(176, 199);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 11;
            label9.Text = "Gender:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(328, 199);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 12;
            label10.Text = "Program:";
            // 
            // txtage
            // 
            txtage.Location = new Point(7, 223);
            txtage.Margin = new Padding(3, 4, 3, 4);
            txtage.Name = "txtage";
            txtage.Size = new Size(130, 27);
            txtage.TabIndex = 13;
            // 
            // cmbgender
            // 
            cmbgender.FormattingEnabled = true;
            cmbgender.Location = new Point(158, 223);
            cmbgender.Margin = new Padding(3, 4, 3, 4);
            cmbgender.Name = "cmbgender";
            cmbgender.Size = new Size(130, 28);
            cmbgender.TabIndex = 14;
            // 
            // cmbprogram
            // 
            cmbprogram.FormattingEnabled = true;
            cmbprogram.Location = new Point(311, 227);
            cmbprogram.Margin = new Padding(3, 4, 3, 4);
            cmbprogram.Name = "cmbprogram";
            cmbprogram.Size = new Size(283, 28);
            cmbprogram.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvlist);
            groupBox1.Location = new Point(14, 283);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(581, 225);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "List Of Members";
            // 
            // dgvlist
            // 
            dgvlist.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.Wheat;
            dgvlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvlist.BackgroundColor = Color.Tan;
            dgvlist.BorderStyle = BorderStyle.None;
            dgvlist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvlist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvlist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Sienna;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvlist.DefaultCellStyle = dataGridViewCellStyle3;
            dgvlist.EnableHeadersVisualStyles = false;
            dgvlist.GridColor = Color.Tan;
            dgvlist.Location = new Point(7, 29);
            dgvlist.Margin = new Padding(3, 4, 3, 4);
            dgvlist.Name = "dgvlist";
            dgvlist.ReadOnly = true;
            dgvlist.RowHeadersVisible = false;
            dgvlist.RowHeadersWidth = 51;
            dgvlist.Size = new Size(567, 188);
            dgvlist.TabIndex = 0;
            // 
            // btnreg
            // 
            btnreg.BackColor = Color.Green;
            btnreg.FlatStyle = FlatStyle.Flat;
            btnreg.ForeColor = SystemColors.ButtonHighlight;
            btnreg.Location = new Point(72, 532);
            btnreg.Margin = new Padding(3, 4, 3, 4);
            btnreg.Name = "btnreg";
            btnreg.Size = new Size(119, 52);
            btnreg.TabIndex = 17;
            btnreg.Text = "Register";
            btnreg.UseVisualStyleBackColor = false;
            btnreg.Click += btnreg_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(255, 128, 0);
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.ForeColor = SystemColors.ButtonHighlight;
            btnupdate.Location = new Point(231, 532);
            btnupdate.Margin = new Padding(3, 4, 3, 4);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(119, 52);
            btnupdate.TabIndex = 18;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.MidnightBlue;
            btnrefresh.FlatStyle = FlatStyle.Flat;
            btnrefresh.ForeColor = SystemColors.ButtonHighlight;
            btnrefresh.Location = new Point(391, 532);
            btnrefresh.Margin = new Padding(3, 4, 3, 4);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(119, 52);
            btnrefresh.TabIndex = 19;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // FrmClubRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(608, 600);
            Controls.Add(btnrefresh);
            Controls.Add(btnupdate);
            Controls.Add(btnreg);
            Controls.Add(groupBox1);
            Controls.Add(cmbprogram);
            Controls.Add(cmbgender);
            Controls.Add(txtage);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(txtmname);
            Controls.Add(txtfname);
            Controls.Add(txtlname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtstuid);
            Controls.Add(label3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClubRegistration";
            Text = "Form1";
            Load += FrmClubRegistration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvlist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtstuid;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtlname;
        private TextBox txtfname;
        private TextBox txtmname;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtage;
        private ComboBox cmbgender;
        private ComboBox cmbprogram;
        private GroupBox groupBox1;
        private Button btnupdate;
        private Button btnreg;
        private Button btnrefresh;
        private DataGridView dgvlist;
    }
}
