using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDemo
{
    public partial class PersonnelUI : Form
    {
        private RentACarEntities _entities = new RentACarEntities();
        private PersonnelDal _personnelDal = new PersonnelDal();
        private RentACarContext context = new RentACarContext();
        public PersonnelUI()
        {
            InitializeComponent();
        }

        private void PersonnelUI_Load(object sender, EventArgs e)
        {
            cbBranchNames.DataSource = context.Branches.ToList();
            cbBranchNames.ValueMember = "BranchName";
        }

        private void dgwPersonnels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgwPersonnels.CurrentRow.Cells[0].Value.ToString();
            tbxBranchId.Text = dgwPersonnels.CurrentRow.Cells[2].Value.ToString();
            tbxFullName.Text = dgwPersonnels.CurrentRow.Cells[1].Value.ToString();
            tbxBranchName.Text = dgwPersonnels.CurrentRow.Cells[3].Value.ToString();
            tbxGender.Text = dgwPersonnels.CurrentRow.Cells[4].Value.ToString();
            tbxPhone.Text = dgwPersonnels.CurrentRow.Cells[5].Value.ToString();
            tbxTitle.Text = dgwPersonnels.CurrentRow.Cells[6].Value.ToString();
            tbxMail.Text = dgwPersonnels.CurrentRow.Cells[7].Value.ToString();
            tbxSalary.Text = dgwPersonnels.CurrentRow.Cells[8].Value.ToString();
            tbxUsername.Text = dgwPersonnels.CurrentRow.Cells[9].Value.ToString();
            tbxPassword.Text = dgwPersonnels.CurrentRow.Cells[10].Value.ToString();
            GenderControl();
        }

        private void ClearTextBoxes()
        {
            tbxId.Clear();
            tbxBranchId.Clear();
            tbxFullName.Clear();
            tbxPhone.Clear();
            tbxTitle.Clear();
            tbxMail.Clear();
            tbxSalary.Clear();
            tbxUsername.Clear();
            tbxPassword.Clear();
        }
        private void GenderControl()
        {
            if (dgwPersonnels.CurrentRow.Cells[4].Value.ToString() == "male" ||
                dgwPersonnels.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                pbxMaleAvatar.Visible = true;
                pbxFemaleAvatar.Visible = false;
            }

            else if (dgwPersonnels.CurrentRow.Cells[4].Value.ToString() == "female" ||
                     dgwPersonnels.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                pbxFemaleAvatar.Visible = true;
                pbxMaleAvatar.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _personnelDal.Add(new Personnel
            {
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                FullName = tbxFullName.Text,
                Phone = tbxPhone.Text,
                Title = tbxTitle.Text,
                Mail = tbxMail.Text,
                Salary = Convert.ToDecimal(tbxSalary.Text),
                Username = tbxUsername.Text,
                UserPassword = tbxPassword.Text,
                Gender = tbxGender.Text
            });
            LoadPersonnels();
            ClearTextBoxes();
            MessageBox.Show("Personnel Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _personnelDal.Update(new Personnel
            {
                PersonnelId = Convert.ToInt32(dgwPersonnels.CurrentRow.Cells[0].Value),
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                FullName = tbxFullName.Text,
                Phone = tbxPhone.Text,
                Title = tbxTitle.Text,
                Mail = tbxMail.Text,
                Salary = Convert.ToDecimal(tbxSalary.Text),
                Username = tbxUsername.Text,
                UserPassword = tbxPassword.Text,
                Gender = tbxGender.Text
            });
            LoadPersonnels();
            ClearTextBoxes();
            MessageBox.Show("Personnel Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _personnelDal.Delete(new Personnel
            {
                PersonnelId = Convert.ToInt32(dgwPersonnels.CurrentRow.Cells[0].Value)
            });
            LoadPersonnels();
            ClearTextBoxes();
            MessageBox.Show("Personnel Deleted!");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadPersonnels();
            ClearTextBoxes();
        }

        private void LoadPersonnels()
        {
            int BranchIndex = cbBranchNames.SelectedIndex + 1;
            dgwPersonnels.DataSource = _entities.GetPersonnelsWithBranchName(BranchIndex);
        }

        private void btnCarSettings_Click(object sender, EventArgs e)
        {
            CarUI go = new CarUI();
            go.Show();
            this.Hide();
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            BranchUI go = new BranchUI();
            go.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerUI go = new CustomerUI();
            go.Show();
            this.Hide();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentUI go = new RentUI();
            go.Show();
            this.Hide();
        }
    }
}
