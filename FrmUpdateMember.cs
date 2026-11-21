using System;
using System.Data;
using System.Windows.Forms;

namespace FrmClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        private string _id, _firstName, _middleName, _lastName, _age, _gender, _program;
        private ClubRegistrationQuery query = new ClubRegistrationQuery();

        public FrmUpdateMember()
        {
            InitializeComponent();
            btnConfirm.Click += btnConfirm_Click;
        }

        public FrmUpdateMember(string id, string firstName, string middleName,
                               string lastName, string age, string gender, string program)
            : this()
        {
            _id = id;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _age = age;
            _gender = gender;
            _program = program;
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            try
            {
                cmbgender1.Items.Add("Male");
                cmbgender1.Items.Add("Female");
                cmbprogram1.Items.Add("Bachelor of Science in Information Technology");
                cmbprogram1.Items.Add("Bachelor of Science in Computer Science");
                cmbprogram1.Items.Add("Bachelor of Science in Information System");
                cmbprogram1.Items.Add("Bachelor of Science in Computer Engineering");
                cmbprogram1.Items.Add("Bachelor of Science in Electronics Engineering");

                cmbstuid.DropDownStyle = ComboBoxStyle.DropDownList;
                if (query.DisplayList())
                {
                    foreach (DataRow r in query.datatable.Rows)
                        cmbstuid.Items.Add(r["StudentID"].ToString());
                }

                txtlname1.Text = _lastName;
                txtfname1.Text = _firstName;
                txtMname1.Text = _middleName;
                txtage1.Text = _age;
                cmbgender1.Text = _gender;
                cmbprogram1.Text = _program;

                cmbstuid.SelectedIndex = cmbstuid.FindStringExact(_id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load member information.\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbstuid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbstuid.SelectedItem == null) return;

                if (!long.TryParse(cmbstuid.SelectedItem.ToString(), out long id)) return;

                DataRow[] rows = query.datatable.Select("StudentID = " + id);
                if (rows.Length == 0) return;

                DataRow r = rows[0];
                txtlname1.Text = r["LastName"].ToString();
                txtfname1.Text = r["FirstName"].ToString();
                txtMname1.Text = r["MiddleName"].ToString();
                txtage1.Text = r["Age"].ToString();
                cmbgender1.Text = r["Gender"].ToString();
                cmbprogram1.Text = r["Program"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbstuid.SelectedItem == null || txtfname1.Text.Trim() == "" ||
                    txtMname1.Text.Trim() == "" || txtlname1.Text.Trim() == "" ||
                    txtage1.Text.Trim() == "" ||
                    cmbgender1.SelectedIndex == -1 || cmbprogram1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill up all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!long.TryParse(cmbstuid.SelectedItem.ToString(), out long id))
                {
                    MessageBox.Show("Invalid Student ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtage1.Text.Trim(), out int age) || age <= 0 || age > 120)
                {
                    MessageBox.Show("Age must be a valid number (1 - 120).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtage1.Focus();
                    return;
                }

                if (query.UpdateMember(id, txtfname1.Text.Trim(), txtMname1.Text.Trim(), txtlname1.Text.Trim(),
                                       age, cmbgender1.SelectedItem.ToString(),
                                       cmbprogram1.SelectedItem.ToString()))
                {
                    MessageBox.Show("Member information has been updated.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}