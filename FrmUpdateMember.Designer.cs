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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.Location = new Point(134, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 426);
            panel1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Green;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = SystemColors.ButtonHighlight;
            btnConfirm.Location = new Point(66, 368);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(107, 39);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // cmbstuid
            // 
            cmbstuid.FormattingEnabled = true;
            cmbstuid.Location = new Point(84, 10);
            cmbstuid.Name = "cmbstuid";
            cmbstuid.Size = new Size(135, 23);
            cmbstuid.TabIndex = 12;
            cmbstuid.SelectedIndexChanged += cmbstuid_SelectedIndexChanged;
            // 
            // cmbprogram1
            // 
            cmbprogram1.FormattingEnabled = true;
            cmbprogram1.Location = new Point(84, 237);
            cmbprogram1.Name = "cmbprogram1";
            cmbprogram1.Size = new Size(135, 23);
            cmbprogram1.TabIndex = 11;
            // 
            // cmbgender1
            // 
            cmbgender1.FormattingEnabled = true;
            cmbgender1.Location = new Point(84, 192);
            cmbgender1.Name = "cmbgender1";
            cmbgender1.Size = new Size(135, 23);
            cmbgender1.TabIndex = 10;
            // 
            // txtage1
            // 
            txtage1.Location = new Point(84, 146);
            txtage1.Name = "txtage1";
            txtage1.Size = new Size(135, 23);
            txtage1.TabIndex = 9;
            // 
            // txtfname1
            // 
            txtfname1.Location = new Point(84, 100);
            txtfname1.Name = "txtfname1";
            txtfname1.Size = new Size(135, 23);
            txtfname1.TabIndex = 8;
            // 
            // txtlname1
            // 
            txtlname1.Location = new Point(84, 54);
            txtlname1.Name = "txtlname1";
            txtlname1.Size = new Size(135, 23);
            txtlname1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 240);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 6;
            label7.Text = "Program:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 195);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 5;
            label6.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 149);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 4;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 149);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 3;
            label4.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 103);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID:";
            // 
            // FrmUpdateMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(532, 450);
            Controls.Add(panel1);
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
    }
}