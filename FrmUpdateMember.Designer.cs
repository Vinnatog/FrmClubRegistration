namespace FrmClubRegistration
{
    partial class FrmUpdateMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            txtMname1 = new TextBox();
            btnConfirm = new Button();
            cmbstuid = new ComboBox();
            cmbprogram1 = new ComboBox();
            cmbgender1 = new ComboBox();
            txtage1 = new TextBox();
            txtfname1 = new TextBox();
            txtlname1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMname1);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(cmbstuid);
            panel1.Controls.Add(cmbprogram1);
            panel1.Controls.Add(cmbgender1);
            panel1.Controls.Add(txtage1);
            panel1.Controls.Add(txtfname1);
            panel1.Controls.Add(txtlname1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(120, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 568);
            panel1.TabIndex = 0;
            // 
            // txtMname1
            // 
            txtMname1.Location = new Point(130, 197);
            txtMname1.Name = "txtMname1";
            txtMname1.Size = new Size(154, 27);
            txtMname1.TabIndex = 16;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(75, 491);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(122, 52);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // cmbstuid
            // 
            cmbstuid.FormattingEnabled = true;
            cmbstuid.Location = new Point(130, 18);
            cmbstuid.Margin = new Padding(3, 4, 3, 4);
            cmbstuid.Name = "cmbstuid";
            cmbstuid.Size = new Size(154, 28);
            cmbstuid.TabIndex = 12;
            cmbstuid.SelectedIndexChanged += cmbstuid_SelectedIndexChanged;
            // 
            // cmbprogram1
            // 
            cmbprogram1.FormattingEnabled = true;
            cmbprogram1.Location = new Point(130, 373);
            cmbprogram1.Margin = new Padding(3, 4, 3, 4);
            cmbprogram1.Name = "cmbprogram1";
            cmbprogram1.Size = new Size(154, 28);
            cmbprogram1.TabIndex = 11;
            // 
            // cmbgender1
            // 
            cmbgender1.FormattingEnabled = true;
            cmbgender1.Location = new Point(130, 313);
            cmbgender1.Margin = new Padding(3, 4, 3, 4);
            cmbgender1.Name = "cmbgender1";
            cmbgender1.Size = new Size(154, 28);
            cmbgender1.TabIndex = 10;
            // 
            // txtage1
            // 
            txtage1.Location = new Point(130, 252);
            txtage1.Margin = new Padding(3, 4, 3, 4);
            txtage1.Name = "txtage1";
            txtage1.Size = new Size(154, 27);
            txtage1.TabIndex = 9;
            // 
            // txtfname1
            // 
            txtfname1.Location = new Point(130, 138);
            txtfname1.Margin = new Padding(3, 4, 3, 4);
            txtfname1.Name = "txtfname1";
            txtfname1.Size = new Size(154, 27);
            txtfname1.TabIndex = 8;
            // 
            // txtlname1
            // 
            txtlname1.Location = new Point(130, 77);
            txtlname1.Margin = new Padding(3, 4, 3, 4);
            txtlname1.Name = "txtlname1";
            txtlname1.Size = new Size(154, 27);
            txtlname1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 377);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 6;
            label7.Text = "Program:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 317);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 256);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 256);
            label4.Name = "label4";
            label4.Size = new Size(13, 20);
            label4.TabIndex = 3;
            label4.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 142);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 81);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 204);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 17;
            label8.Text = "Middle Name:";
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(608, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmUpdateMember";
            Text = "FrmUpdateMember";
            Load += FrmUpdateMember_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtlname1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnConfirm;
        private ComboBox cmbstuid;
        private ComboBox cmbprogram1;
        private ComboBox cmbgender1;
        private TextBox txtage1;
        private TextBox txtfname1;
        private TextBox txtmname;
        private TextBox txtMname1;
        private Label label8;
    }
}