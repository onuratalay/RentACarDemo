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
    public partial class CustomerUI : Form
    {
        private RentACarEntities _entities = new RentACarEntities();
        private RentACarContext context = new RentACarContext();
        private CustomerDal _customerDal = new CustomerDal();
        public CustomerUI()
        {
            InitializeComponent();
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            dgwCustomers.DataSource = _entities.GetCustomers();
        }

        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            PersonnelUI go = new PersonnelUI();
            go.Show();
            this.Hide();
        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            BranchUI go = new BranchUI();
            go.Show();
            this.Hide();
        }

        private void btnCarSettings_Click(object sender, EventArgs e)
        {
            CarUI go = new CarUI();
            go.Show();
            this.Hide();
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxCustomerId.Text = dgwCustomers.CurrentRow.Cells[0].Value.ToString();
            tbxBranchId.Text = dgwCustomers.CurrentRow.Cells[6].Value.ToString();
            tbxFullName.Text = dgwCustomers.CurrentRow.Cells[1].Value.ToString();
            tbxPhone.Text = dgwCustomers.CurrentRow.Cells[2].Value.ToString();
            tbxAge.Text = dgwCustomers.CurrentRow.Cells[3].Value.ToString();
            tbxBudget.Text = dgwCustomers.CurrentRow.Cells[4].Value.ToString();
            tbxDepozit.Text = dgwCustomers.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxCustomerId.Clear();
            tbxBranchId.Clear();
            tbxFullName.Clear();
            tbxAge.Clear();
            tbxPhone.Clear();
            tbxBudget.Clear();
            tbxDepozit.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _customerDal.Add(new Customer
            {
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                FullName = tbxFullName.Text,
                Phone = tbxPhone.Text,
                Age = Convert.ToInt32(tbxAge.Text),
                Budget = Convert.ToDecimal(tbxBudget.Text),
                Depozit = Convert.ToDecimal(tbxDepozit.Text)
            });
            LoadCustomers();
            MessageBox.Show("Customer Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _customerDal.Update(new Customer
            {
                CustomerId = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value),
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                FullName = tbxFullName.Text,
                Phone = tbxPhone.Text,
                Age = Convert.ToInt32(tbxAge.Text),
                Budget = Convert.ToDecimal(tbxBudget.Text),
                Depozit = Convert.ToDecimal(tbxDepozit.Text)
            });
            LoadCustomers();
            MessageBox.Show("Customer Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _customerDal.Delete(new Customer
            {
                CustomerId = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value)
            });
            LoadCustomers();
            MessageBox.Show("Customer Deleted!");
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentUI go = new RentUI();
            go.Show();
            this.Hide();
        }
    }
}
