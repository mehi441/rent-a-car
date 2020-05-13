using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormLayihe.Forms
{
    public partial class Dashboard : Form
    {
        int AdminId;
        public Dashboard(int adminId)
        {
            InitializeComponent();
            AdminId = adminId;
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
    }
}
