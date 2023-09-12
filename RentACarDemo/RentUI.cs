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
    public partial class RentUI : Form
    {
        private RentACarContext _context = new RentACarContext();
        private RentACarEntities _entities = new RentACarEntities();
        private RentDal _rentDal = new RentDal();
        private CarDal _carDal = new CarDal();
        public RentUI()
        {
            InitializeComponent();
        }

        void ClearTextBoxes()
        {
            tbxBranchId.Clear();
            tbxCarId.Clear();
            tbxPlate.Clear();
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

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadNonRentalCars();
            ClearTextBoxes();
        }

        private void LoadNonRentalCars()
        {
            int BranchIndex = cbBranchNames.SelectedIndex + 1;
            dgwNonRentalCars.DataSource = _entities.GetNonRentalCars(BranchIndex);
        }

        private void RentUI_Load(object sender, EventArgs e)
        {
            cbBranchNames.DataSource = _context.Branches.ToList();
            cbBranchNames.ValueMember = "BranchName";

            cbBranchNames2.DataSource = _context.Branches.ToList();
            cbBranchNames2.ValueMember = "BranchName";
        }

        private void dgwNonRentalCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBranchId.Text = dgwNonRentalCars.CurrentRow.Cells[0].Value.ToString();
            tbxCarId.Text = dgwNonRentalCars.CurrentRow.Cells[1].Value.ToString();
            tbxPlate.Text = dgwNonRentalCars.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rent a = new Rent();
            a.CustomerId = Convert.ToInt32(tbxCustomerId.Text);
            a.CarId = Convert.ToInt32(tbxCarId.Text);
            a.BranchId = Convert.ToInt32(tbxBranchId.Text);
            a.RentalDate = DateTime.Parse(dtpRentalDate.Text);
            a.RentalPeriod = Convert.ToInt32(tbxRentalPeriod.Text);
            _rentDal.Add(a);
            _entities.UpdateRentId(a.RentId);
            LoadNonRentalCars();
            MessageBox.Show("Car Rented!");
            ClearTextBoxes();
        }

        private void dgwRentalCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxRentId.Text = dgwRentalCars.CurrentRow.Cells[0].Value.ToString();
            tbxCarId2.Text = dgwRentalCars.CurrentRow.Cells[1].Value.ToString();
            tbxBranchId2.Text = dgwRentalCars.CurrentRow.Cells[2].Value.ToString();
            tbxRentalPeriod2.Text = dgwRentalCars.CurrentRow.Cells[4].Value.ToString();
            tbxFullName.Text = dgwRentalCars.CurrentRow.Cells[5].Value.ToString();
            tbxAge.Text = dgwRentalCars.CurrentRow.Cells[6].Value.ToString();
            tbxPhone.Text = dgwRentalCars.CurrentRow.Cells[7].Value.ToString();
            tbxPlate2.Text = dgwRentalCars.CurrentRow.Cells[9].Value.ToString();
            tbxDepozit.Text = dgwRentalCars.CurrentRow.Cells[8].Value.ToString();

            try
            {
                if (dgwRentalCars.Rows[e.RowIndex].Cells[4].Value != null && dgwRentalCars.Rows[e.RowIndex].Cells[16].Value != null)
                {
                    int rentalPeriod = Convert.ToInt32(dgwRentalCars.Rows[e.RowIndex].Cells[4].Value);
                    decimal price = Convert.ToDecimal(dgwRentalCars.Rows[e.RowIndex].Cells[16].Value);

                    decimal totalPrice = rentalPeriod * price;
                    int roundedTotalPrice = (int)Math.Floor(totalPrice); // Tam sayıya yuvarlar
                    tbxTotalPrice.Text = roundedTotalPrice.ToString();
                }
                else
                {
                    tbxTotalPrice.Text = ""; // Boş değer varsa Text Box'ı temizle
                }
            }
            catch (Exception ex)
            {
                tbxTotalPrice.Text = ""; // Hata durumunda Text Box'ı temizle
            }
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            LoadRentalCars();
            ClearTextBoxes2();
        }

        private void LoadRentalCars()
        {
            int BranchIndex = cbBranchNames2.SelectedIndex + 1;
            dgwRentalCars.DataSource = _entities.GetRentalCars(BranchIndex);
        }

        private void ClearTextBoxes2()
        {
            tbxRentId.Clear();
            tbxCarId2.Clear();
            tbxBranchId2.Clear();
            tbxRentalPeriod2.Clear();
            tbxFullName.Clear();
            tbxAge.Clear();
            tbxPhone.Clear();
            tbxPlate2.Clear();
            tbxDepozit.Clear();
            tbxTotalPrice.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.CarId = Convert.ToInt32(dgwRentalCars.CurrentRow.Cells[1].Value);
            car.BranchId = Convert.ToInt32(tbxBranchId2.Text);
            car.RentId = Convert.ToInt32(null);
            car.Price = Convert.ToDecimal(dgwRentalCars.CurrentRow.Cells[16].Value);
            car.Plate = tbxPlate2.Text;
            car.Brand = dgwRentalCars.CurrentRow.Cells[10].Value.ToString();
            car.Model = dgwRentalCars.CurrentRow.Cells[11].Value.ToString();
            car.Year = Convert.ToInt32(dgwRentalCars.CurrentRow.Cells[12].Value.ToString());
            car.Color = dgwRentalCars.CurrentRow.Cells[13].Value.ToString();
            car.Gear = dgwRentalCars.CurrentRow.Cells[14].Value.ToString();
            car.Engine = dgwRentalCars.CurrentRow.Cells[15].Value.ToString();
            car.StockAmount = 1;
            _carDal.Update(car);

            LoadRentalCars();
            ClearTextBoxes2();
        }
    }
}
