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
    public partial class ReceiveCar : Form
    {
        int ReceiveAdminId;
        WinFormLayiheDBEntities db;
        public ReceiveCar(int receiveAdminId)
        {
            InitializeComponent();
            ReceiveAdminId = receiveAdminId;
            db = new WinFormLayiheDBEntities();
            FillDgvRents();
        }
        
        private void FillDgvRents() 
        {
            foreach (Rents item in db.Rents.Where(r => r.ReceiveDate == null))
            {
                dgvRents.Rows.Add(item.Cars.Brands.Name + " " + item.Cars.Models.Name, item.Cars.Number,
                    item.Clients.Surname + " " + item.Clients.Name, item.SellDate.Value.ToShortDateString() , 
                    item.PromiseDate.Value.ToShortDateString(),
                    (decimal)((item.PromiseDate - item.SellDate).Value.TotalDays + 1) * item.Price, item.Admins.FullName);
            }
        }

        private void dgvRents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string CarNumber = dgvRents.Rows[e.RowIndex].Cells[1].Value.ToString();
            DateTime SellDate = Convert.ToDateTime(dgvRents.Rows[e.RowIndex].Cells[3].Value);
            Rents rent = db.Rents.FirstOrDefault(r => r.Cars.Number == CarNumber && r.SellDate == SellDate);
            CheckRent checkRent = new CheckRent(rent, ReceiveAdminId);
            checkRent.Show();
        }



    }
}
