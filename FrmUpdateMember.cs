using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();

        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();

            cmbgender1.Items.AddRange(new object[] { "Male", "Female" });
            cmbprogram1.Items.AddRange(new object[] { "Bachelor of Science in Information Technology", "Bachelor of Science in Computer Science", "Bachelor of Science in Electronics Engineering", "Bachelor of Science in Information System", "Bachelor of Science in Business Administration" });

            if (clubRegistrationQuery.DisplayList())
            {
                foreach (DataRow row in clubRegistrationQuery.datatable.Rows)
                {
                    cmbstuid.Items.Add(row["StudentID"].ToString());
                }
            }
        }

        private void cmbstuid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(cmbstuid.SelectedItem.ToString(), out long studentID))
            {
                MessageBox.Show("Invalid Student ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            else
            {
                MessageBox.Show("Failed to retrieve student details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
            

        
    

