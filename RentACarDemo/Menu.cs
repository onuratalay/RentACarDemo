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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCarSettings_Click(object sender, EventArgs e)
        {
            CarUI go = new CarUI();
            go.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnBranches_Click(object sender, EventArgs e)
        {
            BranchUI go = new BranchUI();
            go.Show();
            this.Hide();
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

        private void btnRent_Click(object sender, EventArgs e)
        {
            RentUI go = new RentUI();
            go.Show();
            this.Hide();
        }
    }
}
