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
    public partial class BranchUI : Form
    {
        public BranchUI()
        {
            InitializeComponent();
        }

        private BranchDal _branchDal = new BranchDal();
        private void BranchUI_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void LoadBranches()
        {
            dgwBranches.DataSource = _branchDal.GetAll();
        }

        private void dgwBranches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgwBranches.CurrentRow.Cells[0].Value.ToString();
            tbxName.Text = dgwBranches.CurrentRow.Cells[1].Value.ToString();
            tbxEmployees.Text = dgwBranches.CurrentRow.Cells[2].Value.ToString();
            tbxEndorsement.Text = dgwBranches.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _branchDal.Add(new Branch
            {
                BranchName = tbxName.Text,
                NumberOfEmployees = Convert.ToInt32(tbxEmployees.Text),
                Endorsement = Convert.ToDecimal(tbxEndorsement.Text)
            });
            ClearTextBoxes();
            LoadBranches();
            MessageBox.Show("Branch Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _branchDal.Update(new Branch
            {
                BranchId = Convert.ToInt32(dgwBranches.CurrentRow.Cells[0].Value),
                BranchName = tbxName.Text,
                NumberOfEmployees = Convert.ToInt32(tbxEmployees.Text),
                Endorsement = Convert.ToDecimal(tbxEndorsement.Text)
            });
            ClearTextBoxes();
            LoadBranches();
            MessageBox.Show("Branch Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _branchDal.Delete(new Branch
            {
                BranchId = Convert.ToInt32(dgwBranches.CurrentRow.Cells[0].Value)
            });
            ClearTextBoxes();
            LoadBranches();
            MessageBox.Show("Branch Deleted!");
        }

        private void ClearTextBoxes()
        {
            tbxName.Clear();
            tbxEmployees.Clear();
            tbxEndorsement.Clear();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            PersonnelUI go = new PersonnelUI();
            go.Show();
            this.Hide();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerUI go = new CustomerUI();
            go.Show();
            this.Hide();
        }

        private void btnCarSettings_Click(object sender, EventArgs e)
        {
            CarUI go = new CarUI();
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
