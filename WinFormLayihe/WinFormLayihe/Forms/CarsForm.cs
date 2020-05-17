using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLayihe.ModelsApp;

namespace WinFormLayihe.Forms
{
    public partial class CarsForm : Form
    {
        WinFormLayiheDBEntities db;
        public CarsForm()
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();

            FillDgvCars();
            FillCbBrands();
        }

        private void FillDgvCars()
        {
            dgvCars.Rows.Clear();
            foreach (Cars item in db.Cars)
            {
                dgvCars.Rows.Add(item.Id, item.Brands.Name, item.Models.Name, item.Number, item.Price, item.Year, 
                    item.PassportNumber, item.AddedDate);
            }
        }
        private void FillCbBrands()
        {
            cbBrands.Items.Add("Choose");
            cbBrands.SelectedItem = "Choose";
            cbBrands.Items.Clear();
            foreach (Brands item in db.Brands)
            {
                cbBrands.Items.Add(item.Name);
            }
        }
        private void FillCbModels(int brandId)
        {
            cbModels.Items.Add("Choose");
            cbModels.SelectedItem = "Choose";
            cbModels.Items.Clear();
            foreach (Models item in db.Models.Where(m=> m.BrandId==brandId))
            {
                cbModels.Items.Add(item.Name);
            }
        }

        private void cbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrands.Text != "Choose")
            {
                int BrandId = db.Brands.FirstOrDefault(b => b.Name == cbBrands.Text).Id;
                FillCbModels(BrandId);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FillCbBrands();
            cbModels.Items.Clear();
            if (cbBrands.Visible)
            {
                cbBrands.Visible = false;
                txtBrand.Visible = true;
                button1.Text = "-";

                cbModels.Visible = false;
                txtModel.Visible = true;
                button2.Text = "-";
            }
            else
            {
                cbBrands.Visible = true;
                txtBrand.Visible = false;
                button1.Text = "+";

                cbModels.Visible = true;
                txtModel.Visible = false;
                button2.Text = "+";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbModels.Text = "";
            cbModels.Items.Clear();

            if (cbModels.Visible)
            {
                cbModels.Visible = false;
                txtModel.Visible = true;
                button2.Text = "-";
            }
            else
            {
                cbModels.Visible = true;
                txtModel.Visible = false;
                button2.Text = "+";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cars car = new Cars();
            int brandId = 0;
            int modelId = 0;
            if (cbBrands.SelectedIndex < 0 && cbModels.SelectedIndex<0)
            {
                Brands brands = new Brands();
                brands.Name = txtBrand.Text;
                db.Brands.Add(brands);
                db.SaveChanges();
                brandId = db.Brands.FirstOrDefault(b => b.Name == txtBrand.Text).Id;

                Models models = new Models();
                models.BrandId = brandId;
                models.Name = txtModel.Text;
                db.Models.Add(models);
                db.SaveChanges();
                modelId = db.Models.FirstOrDefault(m => m.Name == txtModel.Text && m.BrandId == brandId).Id;
            }
            else if (cbBrands.SelectedIndex>=0 && cbModels.SelectedIndex<0)
            {
                brandId = db.Brands.FirstOrDefault(b => b.Name == cbBrands.Text).Id;

                Models models = new Models();
                models.BrandId = brandId;
                models.Name = txtModel.Text;
                db.Models.Add(models);
                db.SaveChanges();
                modelId = db.Models.FirstOrDefault(m => m.Name == txtModel.Text && m.BrandId == brandId).Id;
            }
            else
            {
                brandId = db.Brands.FirstOrDefault(b => b.Name == cbBrands.Text).Id;
                modelId = db.Models.FirstOrDefault(m=> m.Name==cbModels.Text).Id;

            }

            car.BrandId = brandId;
            car.ModelId = modelId;
            car.Number = txtNumber.Text;
            car.Price = numPrice.Value;
            car.Year = (int)numYear.Value;
            car.PassportNumber = txtPassportId.Text;
            car.AddedDate = DateTime.Now.Date;

            db.Cars.Add(car);
            db.SaveChanges();
            FillDgvCars();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
