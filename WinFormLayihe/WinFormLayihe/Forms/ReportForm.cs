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
    public partial class ReportForm : Form
    {
        WinFormLayiheDBEntities db;
        public ReportForm()
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();

            FillCbBrands();
            FillCbCarNumbers();
            FillCbClients();
            FillCbSellAdmin();
            FillCbReceiveAdmin();
        }

        private void FillDgvRents( List<Rents> rents )
        {
            dgvRents.Rows.Clear();
            foreach (Rents item in rents)
            {
                dgvRents.Rows.Add(item.Id, item.Cars.Brands.Name, item.Cars.Models.Name, item.Cars.Number, 
                    item.Clients.Surname+" "+item.Clients.Name, item.SellDate.Value.ToShortDateString(), 
                    item.PromiseDate.Value.ToShortDateString() , item.ReceiveDate!=null ? item.ReceiveDate.Value.ToShortDateString():"",
                    item.Price,((item.PromiseDate-item.SellDate).Value.TotalDays+1)* (double)item.Price , 
                    item.ReceiveDate==null ? "": ((item.ReceiveDate-item.PromiseDate).Value.TotalDays*(double)item.Price*1.2).ToString(),
                    item.ReceiveDate==null ? "": (((item.PromiseDate - item.SellDate).Value.TotalDays + 1) * (double)item.Price+
                    (item.ReceiveDate - item.PromiseDate).Value.TotalDays * (double)item.Price * 1.2).ToString(),
                    item.Admins.FullName, item.ReceiveAdminID==null ? "" :  db.Admins.Find(item.ReceiveAdminID).FullName );
            }
        }


        private void FillCbBrands()
        {
            cbBrands.Items.Clear();
            cbBrands.Items.Add("Choose");
            cbBrands.SelectedItem = "Choose";
            foreach (Brands item in db.Brands)
            {
                cbBrands.Items.Add(item.Name);
            }
        }
        private void FillCbModels(int brandId)
        {
            cbModels.Items.Clear();
            cbModels.Items.Add("Choose");
            cbModels.SelectedItem = "Choose";
            foreach (Models item in db.Models.Where(m => m.BrandId == brandId))
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

            cbCarNumbers.Items.Clear();
            cbCarNumbers.Items.Add("Choose");
            cbCarNumbers.SelectedItem = "Choose";
            foreach (Cars item in db.Cars.Where(c=> c.BrandId== db.Brands.FirstOrDefault(b=> b.Name==cbBrands.Text).Id))
            {
                cbCarNumbers.Items.Add(item.Number);
            }

        }


        private void FillCbCarNumbers()
        {
            cbCarNumbers.Items.Clear();
            cbCarNumbers.Items.Add("Choose");
            cbCarNumbers.SelectedItem = "Choose";
            foreach (Cars item in db.Cars)
            {
                cbCarNumbers.Items.Add(item.Number);
            }
        }

        private void FillCbClients()
        {
            cbClients.Items.Clear();
            cbClients.Items.Add("Choose");
            cbClients.SelectedItem = "Choose";
            foreach (Clients item in db.Clients)
            {
                cbClients.Items.Add(item.Surname + " " + item.Name);
            }
        }

        private void FillCbSellAdmin()
        {
            cbSellAdmin.Items.Clear();
            cbSellAdmin.Items.Add("Choose");
            cbSellAdmin.SelectedItem = "Choose";
            foreach (Admins item in db.Admins)
            {
                cbSellAdmin.Items.Add(item.FullName);
            }
        }
        private void FillCbReceiveAdmin()
        {
            cbReceiveAdmin.Items.Clear();
            cbReceiveAdmin.Items.Add("Choose");
            cbReceiveAdmin.SelectedItem = "Choose";
            foreach (Admins item in db.Admins)
            {
                cbReceiveAdmin.Items.Add(item.FullName);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? BrandId = null;
            if (db.Brands.FirstOrDefault(b=> b.Name == cbBrands.Text) != null)
            {
                BrandId = db.Brands.FirstOrDefault(b => b.Name == cbBrands.Text).Id;
            }

            int? ModelId = null;
            if(db.Models.FirstOrDefault(m=> m.Name==cbModels.Text && m.BrandId == BrandId) != null)
            {
                ModelId = db.Models.FirstOrDefault(m => m.Name == cbModels.Text && m.BrandId == BrandId).Id;
            }

            int? CarId = null;
            if (db.Cars.FirstOrDefault( c=> c.Number==cbCarNumbers.Text )!=null)
            {
                CarId = db.Cars.FirstOrDefault(c => c.Number == cbCarNumbers.Text).Id;
            }

            int? ClientId = null;
            if (db.Clients.FirstOrDefault(c=> c.Surname + " " + c.Name==cbClients.Text)!=null)
            {
                ClientId = db.Clients.FirstOrDefault(c => c.Surname + " " + c.Name == cbClients.Text).Id;
            }

            int? SellAdminId = null;
            if (db.Admins.FirstOrDefault(a=> a.FullName==cbSellAdmin.Text)!=null)
            {
                SellAdminId = db.Admins.FirstOrDefault(a => a.FullName == cbSellAdmin.Text).Id;
            }

            int? ReceiveAdminId = null;
            if (db.Admins.FirstOrDefault( a=> a.FullName== cbReceiveAdmin.Text)!=null)
            {
                ReceiveAdminId = db.Admins.FirstOrDefault(a => a.FullName == cbReceiveAdmin.Text).Id;
            }

            List<Rents> rents = db.Rents.Where(r => (BrandId != null ? r.Cars.BrandId == BrandId : true) &&
                                                    (ModelId != null ? r.Cars.ModelId == ModelId : true) &&
                                                    (CarId != null ? r.Cars.Id == CarId : true) &&
                                                    (ClientId != null ? r.ClientId == ClientId : true) &&
                                                    (SellAdminId != null ? r.AdminId == SellAdminId : true) &&
                                                    (ReceiveAdminId != null ? r.ReceiveAdminID == ReceiveAdminId : true) &&
                                                    (numPriceMin.Value != 0 ? r.Price >= numPriceMin.Value : true) &&
                                                    (numPriceMax.Value != 0 ? r.Price <= numPriceMax.Value : true)&&
                                                    (r.SellDate>=dtpSellStart.Value.Date)&&
                                                    (r.SellDate<=dtpSellEnd.Value.Date)&&
                                                    (r.ReceiveDate!=null ? r.ReceiveDate>=dtpReceiveStart.Value.Date : r.PromiseDate>=dtpReceiveStart.Value.Date )&&
                                                    (r.ReceiveDate!=null? r.ReceiveDate<=dtpReceiveEnd.Value.Date : r.PromiseDate<=dtpReceiveEnd.Value.Date)
                                                    ).ToList();


            FillDgvRents(rents);






        }

        private void cbModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCarNumbers.Items.Clear();
            cbCarNumbers.Items.Add("Choose");
            cbCarNumbers.SelectedItem = "Choose";

            foreach (Cars item in db.Cars.Where(c => c.BrandId == db.Brands.FirstOrDefault(b => b.Name == cbBrands.Text).Id && 
            c.ModelId==db.Models.FirstOrDefault(m=> m.Name==cbModels.Text).Id))
            {
                cbCarNumbers.Items.Add(item.Number);
            }
        }
    }
}
