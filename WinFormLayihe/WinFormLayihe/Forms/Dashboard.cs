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
    public partial class Dashboard : Form
    {
        int AdminId;
        WinFormLayiheDBEntities db;
        public Dashboard(int adminId)
        {
            InitializeComponent();
            this.db = new WinFormLayiheDBEntities();
            AdminId = adminId;
            GetLast10();
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            NewRent newRent = new NewRent(AdminId);
            newRent.Show();
        }

        private void btnReceiveCar_Click(object sender, EventArgs e)
        {
            ReceiveCar receiveCar = new ReceiveCar(AdminId);
            receiveCar.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.Show();
        }

        private void adminsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminsForm adminsForm = new AdminsForm();
            adminsForm.Show();
        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarsForm carsForm = new CarsForm();
            carsForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();

        }


        private void GetLast10()
        {
            List<Rents> rents = new List<Rents>();
            foreach (Rents item in db.Rents.Where(r => r.ReceiveDate==null))
            {
                rents.Add(item);
            }
            int i = 0;
            dgvRents.Rows.Clear();
            foreach (Rents item in rents.AsEnumerable().Reverse())
            {
                dgvRents.Rows.Add(item.Cars.Brands.Name +" "+item.Cars.Models.Name, item.Cars.Number,
                    item.Clients.Surname+" "+item.Clients.Name, item.SellDate.Value.ToShortDateString(),
                    item.PromiseDate.Value.ToShortDateString(),
                    ((item.PromiseDate - item.SellDate).Value.TotalDays + 1) * (double)item.Price, item.Admins.FullName);
                i++;
                if(i==10)
                    return;
            }

        }

    }
}
