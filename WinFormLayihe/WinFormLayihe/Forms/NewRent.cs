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
    public partial class NewRent : Form
    {
        int AdminId;
        WinFormLayiheDBEntities db;
        public NewRent(int adminId)
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();
            AdminId = adminId;
            FillCBClients();
            dtpSell.Value = DateTime.Now.Date;
            dtpPromise.Value = DateTime.Now.Date;
            FillCBCars();
            numYear.Controls.RemoveAt(0);
            lblAdmin.Text += db.Admins.Find(adminId).FullName;
        }
        private void FillCBClients()
        {
            cbClients.Items.Add("Choose");
            cbClients.SelectedItem="Choose";
            cbClients.Items.Clear();
            foreach (Clients item in db.Clients)
            {
                cbClients.Items.Add(item.Surname + " " + item.Name + " ," + item.Birth.Value.Year);
            }
        }
        private void FillCBCars()
        {
            cbCars.Items.Add("Choose");
            cbCars.SelectedItem = "Choose";
            cbCars.Items.Clear();
            foreach (Cars item in db.Cars)
            {
                cbCars.Items.Add(item.Brands.Name + " ," + item.Models.Name + " ," + item.Number);
            }
            foreach (Rents item in db.Rents.Where(r=> r.ReceiveDate==null))
            {
                if ((dtpSell.Value.Date >= item.SellDate && dtpSell.Value.Date <= item.PromiseDate) ||
                    (dtpPromise.Value.Date >= item.SellDate && dtpPromise.Value.Date <= item.PromiseDate) ||
                    (dtpSell.Value.Date <= item.SellDate && dtpPromise.Value.Date >= item.PromiseDate))
                {
                    cbCars.Items.Remove(item.Cars.Brands.Name + " ," + item.Cars.Models.Name + " ," + item.Cars.Number);
                }
            }
        }

        private void dtpPromise_ValueChanged(object sender, EventArgs e)
        {
            FillCBCars();
        }
        private void dtpSell_ValueChanged(object sender, EventArgs e)
        {
            FillCBCars();
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            Rents rent = new Rents();
            rent.CarId = db.Cars.FirstOrDefault(c => cbCars.Text.Contains(c.Number)).Id;
            rent.ClientId = db.Clients.FirstOrDefault(c => cbClients.Text.Contains(c.Name) && cbClients.Text.Contains(c.Surname)).Id;
            rent.SellDate = dtpSell.Value;
            rent.PromiseDate = dtpPromise.Value;
            rent.Price = numPrice.Value;
            rent.AdminId = AdminId;
            db.Rents.Add(rent);
            db.SaveChanges();
            MessageBox.Show("Car " +  rent.Cars.Number+ " rented");
            this.Close();
        }
        private void cbCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCars.Text!="Choose")
            {
                numPrice.Value= (decimal)db.Cars.FirstOrDefault(c => cbCars.Text.Contains(c.Number)).Price;
                numYear.Value = (decimal)db.Cars.FirstOrDefault(c => cbCars.Text.Contains(c.Number)).Year;
            }
            else
            {
                numPrice.Value = numYear.Value = numTotalPrice.Value = 0;
            }
        }

       

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            numTotalPrice.Value = (decimal)((dtpPromise.Value - dtpSell.Value).TotalDays+ 1) * numPrice.Value;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
            this.Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
            this.Close();
        }
    }
}
