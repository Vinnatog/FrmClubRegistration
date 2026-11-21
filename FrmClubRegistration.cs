using System;
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

        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
            clubRegistrationQuery.DisplayList();
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");
            cmbprogram.Items.Add("Bachelor of Science in Information Technology");
            cmbprogram.Items.Add("Bachelor of Science in Computer Science");
            cmbprogram.Items.Add("Bachelor of Science in Information System");
            cmbprogram.Items.Add("Bachelor of Science in Computer Engineering");
            cmbprogram.Items.Add("Bachelor of Science in Electronics Engineering");

        }
        public int RegistrationID()
        {
            Count++;
            return Count;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {

            ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
           
          if (txtfname.Text == "" || txtmname.Text == "" || txtlname.Text == "" || txtage.Text == "" || cmbgender.SelectedIndex == -1 || cmbprogram.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill up all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StudentID = long.Parse(txtstuid.Text);
                FirstName = txtfname.Text;
                MiddleName = txtmname.Text;
                LastName = txtlname.Text;
                Age = int.Parse(txtage.Text);
                Gender = cmbgender.SelectedItem.ToString();
                Program = cmbprogram.SelectedItem.ToString();
                if (clubRegistrationQuery.RegisterStudent(StudentID, FirstName, MiddleName, LastName, Age, Gender, Program))
                {
                    MessageBox.Show("Student has been successfully registered.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            RefreshListOfClubMembers();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
        FrmUpdateMember frmUpdateMember = new FrmUpdateMember();
        frmUpdateMember.ShowDialog();


    }
    }

