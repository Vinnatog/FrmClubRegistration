using System;
using System.Data;
using System.Windows.Forms;

namespace FrmClubRegistration;

public partial class FrmClubRegistration : Form
{
    private ClubRegistrationQuery clubRegistrationQuery;
    int ID, Age, Count;
    string FirstName, MiddleName, LastName, Gender, Program;
    long StudentID;

    public FrmClubRegistration()
    {
        InitializeComponent();
    }

    public void RefreshListOfClubMembers()
    {
        try
        {
            clubRegistrationQuery = new ClubRegistrationQuery();
            clubRegistrationQuery.DisplayList();
            dgvlist.DataSource = clubRegistrationQuery.bindingSource;
            dgvlist.Columns["StudentID"].HeaderText = "Student ID";
            dgvlist.Columns["FirstName"].HeaderText = "First Name";
            dgvlist.Columns["MiddleName"].HeaderText = "Middle Name";
            dgvlist.Columns["LastName"].HeaderText = "Last Name";
            dgvlist.Columns["Age"].HeaderText = "Age";
            dgvlist.Columns["Gender"].HeaderText = "Gender";
            dgvlist.Columns["Program"].HeaderText = "Program";
            dgvlist.ClearSelection();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to load the list of members.\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void FrmClubRegistration_Load(object sender, EventArgs e)
    {
        try
        {
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");
            cmbprogram.Items.Add("Bachelor of Science in Information Technology");
            cmbprogram.Items.Add("Bachelor of Science in Computer Science");
            cmbprogram.Items.Add("Bachelor of Science in Information System");
            cmbprogram.Items.Add("Bachelor of Science in Computer Engineering");
            cmbprogram.Items.Add("Bachelor of Science in Electronics Engineering");

            dgvlist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvlist.MultiSelect = false;
            RefreshListOfClubMembers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public int RegistrationID()
    {
        Count++;
        ClubRegistrationQuery query = new ClubRegistrationQuery();
        if (query.DisplayList())
            Count = query.datatable.Rows.Count;
        return Count;
    }

    private void btnreg_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtstuid.Text.Trim() == "" || txtfname.Text.Trim() == "" || txtmname.Text.Trim() == "" ||
                txtlname.Text.Trim() == "" || txtage.Text.Trim() == "" ||
                cmbgender.SelectedIndex == -1 || cmbprogram.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill up all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!long.TryParse(txtstuid.Text.Trim(), out StudentID) || StudentID <= 0)
            {
                MessageBox.Show("Student ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstuid.Focus();
                return;
            }

            if (!int.TryParse(txtage.Text.Trim(), out Age) || Age <= 0 || Age > 120)
            {
                MessageBox.Show("Age must be a valid number (1 - 120).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtage.Focus();
                return;
            }

            if (clubRegistrationQuery != null &&
                clubRegistrationQuery.datatable.Select("StudentID = " + StudentID).Length > 0)
            {
                MessageBox.Show("This Student ID is already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstuid.Focus();
                return;
            }

            FirstName = txtfname.Text.Trim();
            MiddleName = txtmname.Text.Trim();
            LastName = txtlname.Text.Trim();
            Gender = cmbgender.SelectedItem.ToString();
            Program = cmbprogram.SelectedItem.ToString();

            ClubRegistrationQuery query = new ClubRegistrationQuery();

            if (query.RegisterStudent(StudentID, FirstName, MiddleName, LastName, Age, Gender, Program))
            {
                int regNo = RegistrationID();
                MessageBox.Show("Student has been successfully registered.\nRegistration No: " + regNo,
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshListOfClubMembers();

                txtstuid.Clear();
                txtfname.Clear();
                txtmname.Clear();
                txtlname.Clear();
                txtage.Clear();
                cmbgender.SelectedIndex = -1;
                cmbprogram.SelectedIndex = -1;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Registration failed.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnrefresh_Click(object sender, EventArgs e)
    {
        try
        {
            RefreshListOfClubMembers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnupdate_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvlist.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvlist.SelectedRows[0];

            FrmUpdateMember updateMemberForm = new FrmUpdateMember(
                row.Cells["StudentID"].Value?.ToString() ?? "",
                row.Cells["FirstName"].Value?.ToString() ?? "",
                row.Cells["MiddleName"].Value?.ToString() ?? "",
                row.Cells["LastName"].Value?.ToString() ?? "",
                row.Cells["Age"].Value?.ToString() ?? "",
                row.Cells["Gender"].Value?.ToString() ?? "",
                row.Cells["Program"].Value?.ToString() ?? "");

            updateMemberForm.ShowDialog();
            RefreshListOfClubMembers();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Unable to open the update form.\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}