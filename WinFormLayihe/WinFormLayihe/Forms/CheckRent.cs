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
    public partial class CheckRent : Form
    {
        WinFormLayiheDBEntities db;
        Rents Rent = new Rents();
        int ReceiveAdminId;
        public CheckRent(Rents rent, int adminId)
        {
            InitializeComponent();
            Rent = rent;
            ReceiveAdminId = adminId;
            db = new WinFormLayiheDBEntities();
            
            numPaid.Controls.RemoveAt(0);

            FillControls();
        }
         
        private void FillControls()
        {
            txtClient.Text = Rent.Clients.Surname + " " + Rent.Clients.Name;
            txtCar.Text = Rent.Cars.Number;
            dtpSell.Value =Convert.ToDateTime( Rent.SellDate);
            dtpPromise.Value = Convert.ToDateTime(Rent.PromiseDate);
            dtpReceive.Value = Rent.PromiseDate.Value.Date;
            numPaid.Value = (int)((Rent.PromiseDate - Rent.SellDate).Value.TotalDays + 1) * (int)Rent.Price;
            numPenalty.Value = (decimal)((dtpReceive.Value - dtpPromise.Value).TotalDays * (double)Rent.Price*1.2 );
        }

        private void dtpReceive_ValueChanged(object sender, EventArgs e)
        {
            numPenalty.Value = (decimal)((dtpReceive.Value - dtpPromise.Value).TotalDays * (double)Rent.Price * 1.2);
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {

            Rents rents = db.Rents.Find(Rent.Id);
            rents.ReceiveDate = dtpReceive.Value.Date;
            rents.PenaltyPrice = numPenalty.Value;
            rents.ReceiveAdminID = ReceiveAdminId;
            db.SaveChanges();
            MessageBox.Show("Car " + rents.Cars.Number+" received");
            this.Close();
        }
    }
}
