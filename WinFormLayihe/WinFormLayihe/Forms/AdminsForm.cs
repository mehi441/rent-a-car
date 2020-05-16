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
    public partial class AdminsForm : Form
    {

        WinFormLayiheDBEntities db;
        public AdminsForm()
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();
            FillDgvAdmins();
        }
        int ClickedAdminID;

        private void FillDgvAdmins()
        {
            dgvAdmins.Rows.Clear();
            foreach (Admins item in db.Admins)
            {
                dgvAdmins.Rows.Add(item.Id, item.FullName, item.Birth, item.Phone, item.Email, item.Password, item.AdedDate);
            }
        }

        private void Reset()
        {
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            dtpbirth.Value = DateTime.Now;
            ClickedAdminID = 0;

            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admins admins = new Admins();

            admins.FullName = txtName.Text;
            admins.Birth = dtpbirth.Value.Date;
            admins.Phone = txtPhone.Text;
            admins.Email = txtEmail.Text;
            admins.Password = txtPassword.Text;
            admins.AdedDate = DateTime.Now.Date;

            db.Admins.Add(admins);
            db.SaveChanges();
            FillDgvAdmins();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Admins  admins = db.Admins.Find(ClickedAdminID);
            db.Admins.Remove(admins);
            db.SaveChanges();
            FillDgvAdmins();
            Reset();
        }

        private void dgvAdmins_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ClickedAdminID = (int)dgvAdmins.Rows[e.RowIndex].Cells[0].Value;

            txtName.Text = dgvAdmins.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpbirth.Value = Convert.ToDateTime(dgvAdmins.Rows[e.RowIndex].Cells[2].Value);
            txtPhone.Text = dgvAdmins.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvAdmins.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvAdmins.Rows[e.RowIndex].Cells[5].Value.ToString();
            

            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admins  admins = db.Admins.Find(ClickedAdminID);

            admins.FullName = txtName.Text;
            admins.Birth = dtpbirth.Value.Date;
            admins.Phone = txtPhone.Text;
            admins.Email = txtEmail.Text;
            admins.Password = txtPassword.Text;

            db.SaveChanges();
            FillDgvAdmins();
            Reset();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
