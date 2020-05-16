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
    public partial class ClientsForm : Form
    {
        WinFormLayiheDBEntities db;
        public ClientsForm()
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();
            FillDgvClients();
        }
        int ClickedClientID;

        private void FillDgvClients()
        {
            dgvClients.Rows.Clear();
            foreach (Clients item in db.Clients)
            {
                dgvClients.Rows.Add( item.Id, item.Name, item.Surname, item.RealId,
                    item.DrivingLicence, item.Phone, item.Email, item.Birth );
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.Name = txtName.Text;
            client.Surname = txtSurname.Text;
            client.RealId = txtClientId.Text;
            client.DrivingLicence = txtDrivingId.Text;
            client.Phone = txtPhone.Text;
            client.Email = txtEmail.Text;
            client.Birth = dtpbirth.Value.Date;

            db.Clients.Add(client);
            db.SaveChanges();
            FillDgvClients();
            Reset();
        }

        private void dgvClients_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickedClientID = (int)dgvClients.Rows[e.RowIndex].Cells[0].Value;
            txtName.Text = dgvClients.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dgvClients.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtClientId.Text = dgvClients.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDrivingId.Text = dgvClients.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhone.Text = dgvClients.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dgvClients.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtpbirth.Value = Convert.ToDateTime(dgvClients.Rows[e.RowIndex].Cells[7].Value);

            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void Reset()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtClientId.Text = string.Empty;
            txtDrivingId.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpbirth.Value = DateTime.Now;
            ClickedClientID = 0;

            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Clients client = db.Clients.Find(ClickedClientID);

            client.Name = txtName.Text;
            client.Surname = txtSurname.Text;
            client.RealId = txtClientId.Text;
            client.DrivingLicence = txtDrivingId.Text;
            client.Phone = txtPhone.Text;
            client.Email = txtEmail.Text;
            client.Birth = dtpbirth.Value.Date;

            db.SaveChanges();
            FillDgvClients();
            Reset();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clients client = db.Clients.Find(ClickedClientID);
            db.Clients.Remove(client);
            db.SaveChanges();
            FillDgvClients();
            Reset();
        }
    }
}
