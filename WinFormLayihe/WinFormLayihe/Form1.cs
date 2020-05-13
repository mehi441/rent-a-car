using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormLayihe.Forms;
using WinFormLayihe.ModelsApp;

namespace WinFormLayihe
{
    public partial class Form1 : Form
    {
        WinFormLayiheDBEntities db;
        public Form1()
        {
            InitializeComponent();
            db = new WinFormLayiheDBEntities();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblResult.Text = "Fill all !!";
            }
            else if (db.Admins.FirstOrDefault(a => a.Email == txtEmail.Text && a.Password == txtPassword.Text) != null)
            {
                Dashboard dashboard = new Dashboard(db.Admins.FirstOrDefault(a => a.Email == txtEmail.Text).Id);
                dashboard.Show();
            }
            else
            {
                lblResult.Text = "Please check info ";
            }            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblResult.Text = string.Empty;
        }
    }
}
