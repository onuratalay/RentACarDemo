using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarDemo
{
    public partial class CarUI : Form
    {
        private RentACarEntities _entities = new RentACarEntities();
        private RentACarContext context = new RentACarContext();
        private CarDal _carDal = new CarDal();
        public CarUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _carDal.Add(new Car
            {
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                Price = Convert.ToDecimal(tbxPrice.Text),
                Plate = tbxPlate.Text,
                Brand = tbxBrand.Text,
                Model = tbxModel.Text,
                Year = Convert.ToInt32(tbxYear.Text),
                Engine = tbxEngine.Text,
                Gear = tbxGear.Text,
                Color = tbxColor.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            ClearTextBoxes();
            LoadCars();
            MessageBox.Show("Car Added!");
        }

        private void ClearTextBoxes()
        {
            tbxId.Clear();
            tbxBranchId.Clear();
            tbxPrice.Clear();
            tbxPlate.Clear();
            tbxBrand.Clear();
            tbxModel.Clear();
            tbxYear.Clear();
            tbxEngine.Clear();
            tbxGear.Clear();
            tbxColor.Clear();
            tbxStockAmount.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _carDal.Update(new Car
            {
                CarId = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value),
                BranchId = Convert.ToInt32(tbxBranchId.Text),
                Price = Convert.ToDecimal(tbxPrice.Text),
                Plate = tbxPlate.Text,
                Brand = tbxBrand.Text,
                Model = tbxModel.Text,
                Year = Convert.ToInt32(tbxYear.Text),
                Engine = tbxEngine.Text,
                Gear = tbxGear.Text,
                Color = tbxColor.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            ClearTextBoxes();
            LoadCars();
            MessageBox.Show("Car Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _carDal.Delete(new Car
            {
                CarId = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value)
            });
            ClearTextBoxes();
            LoadCars();
            MessageBox.Show("Car Deleted!");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int BranchIndex = cbBranchNames.SelectedIndex + 1;
            dgwCars.DataSource = _entities.GetCarsWithBranchName(BranchIndex);
            ClearTextBoxes();
        }

        private void CarUI_Load(object sender, EventArgs e)
        {
            //LoadCars();
            cbBranchNames.DataSource = context.Branches.ToList();
            cbBranchNames.ValueMember = "BranchName";
            //int BranchIndex = cbBranchNames.SelectedIndex+1;
            //Branch selected = cbBranchNames.Items[BranchIndex] as Branch;
            //if (selected != null)
            //{
            //    string branchName = selected.BranchName;
            //}

        }

        private void LoadCars()
        {
            int BranchIndex = cbBranchNames.SelectedIndex + 1;
            dgwCars.DataSource = _entities.GetCarsWithBranchName(BranchIndex);
        }

        

        private void dgwCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgwCars.CurrentRow.Cells[0].Value.ToString();
            tbxPrice.Text = dgwCars.CurrentRow.Cells[1].Value.ToString();
            tbxPlate.Text = dgwCars.CurrentRow.Cells[2].Value.ToString();
            tbxBrand.Text = dgwCars.CurrentRow.Cells[3].Value.ToString();
            tbxModel.Text = dgwCars.CurrentRow.Cells[4].Value.ToString();
            tbxYear.Text = dgwCars.CurrentRow.Cells[5].Value.ToString();
            tbxEngine.Text = dgwCars.CurrentRow.Cells[6].Value.ToString();
            tbxColor.Text = dgwCars.CurrentRow.Cells[7].Value.ToString();
            tbxStockAmount.Text = dgwCars.CurrentRow.Cells[8].Value.ToString();
            tbxGear.Text = dgwCars.CurrentRow.Cells[9].Value.ToString();
            tbxBranchId.Text = dgwCars.CurrentRow.Cells[10].Value.ToString();

            ControlBrand();
        }

        private void ControlBrand()
        {
            if ((tbxBrand.Text == "audi" || tbxBrand.Text == "Audi"))
            {
                pbxAudi.Visible = true;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "bmw" || tbxBrand.Text == "Bmw")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = true;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "mercedes" || tbxBrand.Text == "Mercedes")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = true;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "nissan" || tbxBrand.Text == "Nissan")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = true;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "toyota" || tbxBrand.Text == "Toyota")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = true;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "fiat" || tbxBrand.Text == "Fiat")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = true;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "ford" || tbxBrand.Text == "Ford")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = true;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "hyundai" || tbxBrand.Text == "Hyundai")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = true;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "mitsubishi" || tbxBrand.Text == "Mitsubishi")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = true;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "peugeot" || tbxBrand.Text == "Peugeot")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = true;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "volkswagen" || tbxBrand.Text == "Volkswagen")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = true;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "renault" || tbxBrand.Text == "Renault")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = true;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "suzuki" || tbxBrand.Text == "Suzuki")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = true;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "volvo" || tbxBrand.Text == "Volvo")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = true;
                pbxTogg.Visible = false;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "togg" || tbxBrand.Text == "Togg")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = true;
                pbxTesla.Visible = false;
            }
            else if (tbxBrand.Text == "tesla" || tbxBrand.Text == "Tesla")
            {
                pbxAudi.Visible = false;
                pbxBmw.Visible = false;
                pbxMercedes.Visible = false;
                pbxNissan.Visible = false;
                pbxToyota.Visible = false;
                pbxFiat.Visible = false;
                pbxFord.Visible = false;
                pbxHyundai.Visible = false;
                pbxMitsubishi.Visible = false;
                pbxPeugeot.Visible = false;
                pbxVolkswagen.Visible = false;
                pbxRenault.Visible = false;
                pbxSuzuki.Visible = false;
                pbxVolvo.Visible = false;
                pbxTogg.Visible = false;
                pbxTesla.Visible = true;
            }
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
